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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            formInit();
        }

        // 窗口初始化
        private void formInit()
        {
            this.KeyPreview = true;         // 窗体将接收所有 KeyPress、KeyDown 和 KeyUp 事件，窗体处理完之后，传递给具有焦点的控件
        }


        /// <summary>
        /// 清空输入框数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void reset_Click(object sender, EventArgs e)
        {
            this.userName.Text = "";
            this.userPass.Text = "";
            this.userPassCheck.Text = "";
            this.userEmail.Text = "";
            this.userPhone.Text = "";
        }

        private void register_Click(object sender, EventArgs e)
        {
            // 检测输入是否合法
            if(this.userPass.Text != this.userPassCheck.Text)
            {
                MessageBox.Show("两次密码不一样，请重新输入");
                return;
            }

            string url = "http://localhost:8080/gameforum/v1/user/register";
            string postData = "userName=" + this.userName.Text;
            postData += "&userPass=" + this.userPass.Text;
            postData += "&userEmail=" + this.userEmail.Text;
            postData += "&userPhone=" + this.userPhone.Text;

            string value = HttpHelper.sendPostRequest(url, postData);

            JObject message = JObject.Parse(value);
            String result = message["result"].ToString();
            if(result == "success")
            {
                // 转到登录页面
                MessageBox.Show("注册成功，即将跳转到登录页面", "注册提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show(result, "注册提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void toLogin_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void RegisterForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.register_Click(sender, e);
            }
        }
    }
}
