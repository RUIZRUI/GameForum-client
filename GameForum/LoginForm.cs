using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameForum
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            formInit();

            IsClose = false;
        }



        // 窗口初始化
        private void formInit()
        {
            this.KeyPreview = true;         // 窗体将接收所有 KeyPress、KeyDown 和 KeyUp 事件，窗体处理完之后，传递给具有焦点的控件
        }




        private void toRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            this.Hide();
            registerForm.ShowDialog();
        }

        public bool IsClose
        {
            get; set;
        }




        private void login_Click(object sender, EventArgs e)
        {
            if(this.userName.Text.Trim() == "" || this.userPass.Text.Trim() == "")
            {
                MessageBox.Show("用户名和密码不能为空，请重新输入", "登录提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
            else
            {
                // 发送post请求，完成登录验证
                string url = "http://localhost:8080/gameforum/v1/user/login";
                string postData = "userName=" + this.userName.Text + "&userPass=" + this.userPass.Text;
                string value = HttpHelper.sendPostRequest(url, postData);

                JObject message = JObject.Parse(value);
                if (message["result"].ToString() == "success")
                {
                    // 登录成功
                    // 发送get请求，获取用户信息
                    url = "http://localhost:8080/gameforum/v1/user/getUserInfo?userName=" + this.userName.Text;
                    value = HttpHelper.sendGetRequest(url);

                    message = JObject.Parse(value);
                    LoginInfo.CurrentUser.UserId = message["id"].ToString();
                    LoginInfo.CurrentUser.UserName = message["name"].ToString();
                    LoginInfo.CurrentUser.UserEmail = message["email"].ToString();
                    LoginInfo.CurrentUser.UserPhone = message["phone"].ToString();
                    LoginInfo.CurrentUser.UserSex = message["sex"].ToString();
                    LoginInfo.CurrentUser.UserBirthday = message["birthday"].ToString();
                    // LoginInfo.CurrentUser.UserJoinTime = message["joinTime"].ToString();
                    LoginInfo.CurrentUser.UserJoinTime = TimeHelper.GetTime(long.Parse(message["joinTime"].ToString()), true).ToString("yyyy-MM-dd");
                    LoginInfo.CurrentUser.FollowNum = int.Parse(message["followNum"].ToString());
                    LoginInfo.CurrentUser.FanNum = int.Parse(message["fanNum"].ToString());
                    LoginInfo.CurrentUser.UserAvatarUrl = message["avatarUrl"].ToString();

                    // 将登录信息写入配置文件
                    JsonHelper.writeJson("userInfo.json", value);

                    // MessageBox.Show(LoginInfo.CurrentUser.ToString());
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    // 登录失败
                    MessageBox.Show(message["result"].ToString(), "登录提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                }
            }
        }


        /// <summary>
        /// 关闭窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            IsClose = true;
            this.Close();
        }

        
        /// <summary>
        /// 游客登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void visitorLogin_Click(object sender, EventArgs e)
        {
            // todo: 发送get请求，增加日访问量
            DialogResult result =  MessageBox.Show("您正在已游客身份浏览，建议您注册使用，可以享受更多权限！", "游客登录提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (result == DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
            }
        }


        /// <summary>
        /// 键盘事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                // enter 键处理
                this.login_Click(sender, e);

            }
        }
    }
}
