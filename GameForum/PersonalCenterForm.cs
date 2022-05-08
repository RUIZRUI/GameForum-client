using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameForum
{
    public partial class PersonalCenterForm : Form
    {
        public PersonalCenterForm()
        {
            InitializeComponent();

            // 头像由方框改为圆形
            this.avatar.Image = ImageHelper.CutEllipse(this.avatar.Image, new Rectangle(0, 0, this.avatar.Image.Width, this.avatar.Image.Height), new Size(this.avatar.Image.Width, this.avatar.Image.Height));

            // 填充数据
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



        /// <summary>
        /// 填充数据
        /// </summary>
        private void fillData()
        {
            if(LoginInfo.CurrentUser.UserId == "")
            {
                // 游客
                this.changeAvatar.Hide();
                this.editInformation.Hide();
                this.userId.Hide();
                this.fansNum.Hide();
                this.focusNum.Hide();
                this.userEmail.Hide();
                this.userPhone.Hide();
                this.userSex.Hide();
                this.userBirthday.Hide();
                this.userJoinTime.Hide();
                this.userName.Hide();
                this.avatar.Hide();
                this.panel2.Hide();
            }
            else
            {
                // 注册用户
                this.userId.Text = "ID：" + LoginInfo.CurrentUser.UserId;
                this.focusNum.Text = "关注：" + LoginInfo.CurrentUser.FollowNum;
                this.fansNum.Text = "粉丝：" + LoginInfo.CurrentUser.FanNum;
                this.userName.Text = "昵称：" + LoginInfo.CurrentUser.UserName;
                this.userEmail.Text = "邮箱：" + LoginInfo.CurrentUser.UserEmail;
                this.userPhone.Text = "手机号：" + LoginInfo.CurrentUser.UserPhone;
                this.userSex.Text = "性别：" + LoginInfo.CurrentUser.UserSex;
                this.userBirthday.Text = "生日：" + LoginInfo.CurrentUser.UserBirthday;
                this.userJoinTime.Text = "入坑时间：" + LoginInfo.CurrentUser.UserJoinTime;

                // [done] todo: 填充头像
                this.avatar.Load(LoginInfo.CurrentUser.UserAvatarUrl);
                // 头像由方框改为圆形
                this.avatar.Image = ImageHelper.SimpleCutEllipse(this.avatar.Image);
            }
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
                if (fileInfo.Length > 2*1024*1024)
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

        private void editInformation_Click(object sender, EventArgs e)
        {
            AccountSetForm accountSetForm = new AccountSetForm();
            this.Close();
            accountSetForm.Show();
        }

        private void personalList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = this.personalList.SelectedIndex;
            if (index == 0)
            {
                // nothing
            }
            else if(index == 1)
            {
                CollectionForm collectionForm = new CollectionForm();
                this.Close();
                collectionForm.Show();
            }
            else if(index == 2)
            {
                FollowsForm followsForm = new FollowsForm();
                this.Close();
                followsForm.Show();
            }
            else if(index == 3)
            {
                FansForm fansForm = new FansForm();
                this.Close();
                fansForm.Show();
            }
            else if(index == 4)
            {
                CommentForm commentForm = new CommentForm();
                this.Close();
                commentForm.Show();
            }
        }

        private void returnImg_Click(object sender, EventArgs e)
        {
            // todo: 返回上一个窗口
            // 暂时返回主窗口
            SingleForm singleForm = (SingleForm)MainWindow.MainForm;
            this.Close();
            singleForm.Show();
        }
    }
}
