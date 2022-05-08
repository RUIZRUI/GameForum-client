using Newtonsoft.Json.Linq;
using System;
using System.IO;
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
    public partial class AccountSetForm : Form
    {
        public AccountSetForm()
        {
            InitializeComponent();

            fillData();
        }


        // 自绘Item
        private void personalList_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(e.BackColor), e.Bounds);
            if (e.Index >= 0)
            {
                StringFormat stringFormat = new StringFormat();
                stringFormat.LineAlignment = StringAlignment.Center;
                e.Graphics.DrawString(((ListBox)sender).Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds, stringFormat);
            }
            e.DrawFocusRectangle();
        }

        private void personalList_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = 40;
        }


        private void changeAvatar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "图像(*.jpg)|*.jpg|图像(*.png)|*.png|所有文件(*.*)|*.*";
            openFileDialog.RestoreDirectory = false;    // 打开上次的目录
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // 文件路径
                string filePath = openFileDialog.FileName;
                // 文件后缀
                string extension = Path.GetExtension(filePath);
                // 声明允许的后缀
                string[] extensions = new string[] { ".jpg", ".png", ".jpge", ".gif" };
                if (!extensions.Contains(extension))
                {
                    MessageBox.Show("可以上传图片的格式有 jpg, png, jpge, gif", "头像更改", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                // 获取用户选择的头像
                FileInfo fileInfo = new FileInfo(filePath);
                // 判断文件大小不能超过 2MB
                // fileInof.Length 单位：字节
                if (fileInfo.Length > 2 * 1024 * 1024)
                {
                    MessageBox.Show("上传头像不能大于2M", "头像更改", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                // 头像上传到服务器
                string url = "http://localhost:8080/forum/AvatarChange";
                string method = "post";
                string fieldName = "avatar";
                Dictionary<string, string> forms = new Dictionary<string, string>();
                forms.Add("userId", LoginInfo.CurrentUser.UserId);
                forms.Add("userName", HttpHelper.URLEncode(LoginInfo.CurrentUser.UserName));
                string response = string.Empty;

                bool result = HttpHelper.uploadFileWithForm(url, method, fieldName, filePath, forms, out response);

                if (result)
                {
                    // 解析response
                    JObject message = JObject.Parse(response);
                    if (message["result"].ToString() == "success")
                    {
                        // 更改头像成功
                        MessageBox.Show("更改头像成功：" + message["result"].ToString());
                        string avatarUrl = message["avatarUrl"].ToString();
                        LoginInfo.CurrentUser.UserAvatarUrl = avatarUrl;

                        // 刷新头像
                        this.avatar.Load(avatarUrl);
                        this.avatar.Image = ImageHelper.SimpleCutEllipse(this.avatar.Image);
                    }
                    else
                    {
                        // 服务端抛出异常
                        MessageBox.Show("更改头像失败：" + message["result"].ToString(), "头像更改", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // 客户端抛出异常
                    MessageBox.Show("更改头像失败：" + response, "头像更改", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("您正在编辑个人信息");
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            PersonalCenterForm personalCenterForm = new PersonalCenterForm();
            this.Close();
            personalCenterForm.Show();
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            // 发送post请求，更改个人信息
            string url = "http://localhost:8080/forum/AccountSet";
            string postData = "userId=" + LoginInfo.CurrentUser.UserId + "&userName=" + this.userName.Text + "&userEmail=" + this.userEmail.Text + "&userPhone=" + this.userPhone.Text;
            string sex = "";
            if(this.male.Checked == true)
            {
                sex = "男"; 
            }
            else
            {
                sex = "女";
            }
            postData += "&userSex=" + sex + "&userBirthday=" + this.userBirthday.Text;

            string value = HttpHelper.sendPostRequest(url, postData);
            JObject message = JObject.Parse(value);
            if(message["result"].ToString() == "success")
            {
                // 成功，则更改 LoginInfo
                LoginInfo.CurrentUser.UserName = this.userName.Text;
                LoginInfo.CurrentUser.UserEmail = this.userEmail.Text;
                LoginInfo.CurrentUser.UserPhone = this.userPhone.Text;
                LoginInfo.CurrentUser.UserSex = sex;
                LoginInfo.CurrentUser.UserBirthday = this.userBirthday.Text;

                // 返回到 个人资料窗口
                PersonalCenterForm personalCenterForm = new PersonalCenterForm();
                this.Close();
                personalCenterForm.Show();
            }
            else
            {
                MessageBox.Show("更改个人信息失败，请更改后重试", "更改信息提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
        }


        private void fillData()
        {
            this.userId.Text = "ID：" + LoginInfo.CurrentUser.UserId;
            this.fansNum.Text = "粉丝：" + LoginInfo.CurrentUser.FanNum.ToString();
            this.focusNum.Text = "关注：" + LoginInfo.CurrentUser.FollowNum.ToString();
            this.userName.Text = LoginInfo.CurrentUser.UserName;
            this.userEmail.Text = LoginInfo.CurrentUser.UserEmail;
            this.userPhone.Text = LoginInfo.CurrentUser.UserPhone;
            if(LoginInfo.CurrentUser.UserSex == "男")
            {
                this.male.Checked = true;
            }
            else
            {
                this.female.Checked = true;
            }
            this.userBirthday.Text = LoginInfo.CurrentUser.UserBirthday;
            this.userJoinTime.Text = LoginInfo.CurrentUser.UserJoinTime;

            // 头像
            this.avatar.Load(LoginInfo.CurrentUser.UserAvatarUrl);
            // 将头像由方框改为圆形
            this.avatar.Image = ImageHelper.SimpleCutEllipse(this.avatar.Image);
        }
    }
}
