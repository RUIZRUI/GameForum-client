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
    public partial class UserManageForm : Form
    {
        private int userCount;          // 用户数量

        public UserManageForm()
        {
            InitializeComponent();

            if (LoginInfo.CurrentUser.UserId != "")
            {
                // 注册用户
                userCount = fillData();
            }
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

        private void manageList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = this.manageList.SelectedIndex;
            if(index == 0)
            {
                SystemManagerForm systemManagerForm = new SystemManagerForm();
                this.Close();
                systemManagerForm.Show();
            }
            else if(index == 1)
            {
                // nothing
            }
        }


        /// <summary>
        /// 系统管理员获取用户列表
        /// </summary>
        /// <returns></returns>
        private List<RelationUser> getUser()
        {
            // get 请求
            string url = "http://localhost:8080/gameforum/v1/system/getUsersBySystem?userId=" + LoginInfo.CurrentUser.UserId + "&userName=" + LoginInfo.CurrentUser.UserName;
            string value = HttpHelper.sendGetRequest(url);

            JObject message = JObject.Parse(value);
            if(message["result"].ToString() == "success")
            {
                // 成功获取
                var arrData = JArray.Parse(message["userList"].ToString());
                List<RelationUser> userList = arrData.ToObject<List<RelationUser>>();
                return userList;
            }
            else if(message["result"].ToString() == "insufficientPermission")
            {
                MessageBox.Show("对不起，您的权限不足!", "系统管理", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                return null;
            }
            else
            {
                MessageBox.Show("error, " + message["result"].ToString(), "系统管理", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return null;
            }
        }



        /// <summary>
        /// 填充数据
        /// </summary>
        /// <returns></returns>
        private int fillData()
        {
            List<RelationUser> userList = getUser();
            int index = 0;
            foreach (RelationUser relationUser in userList)
            {
                index++;
                // 用户头像
                PictureBox userAvatar = new PictureBox();
                ((System.ComponentModel.ISupportInitialize)(userAvatar)).BeginInit();
                userAvatar.Load(relationUser.User_avatar);      // 加载图像
                userAvatar.Location = new Point(38, 82 + 70 * (index - 1));
                userAvatar.Margin = new Padding(3, 3, 3, 3);
                userAvatar.Name = "userAvatar" + index;
                userAvatar.Size = new Size(50, 50);
                userAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
                // 头像由方框改为圆形
                userAvatar.Image = ImageHelper.CutEllipse(userAvatar.Image, new Rectangle(0, 0, userAvatar.Image.Width, userAvatar.Image.Height), new Size(userAvatar.Image.Width, userAvatar.Image.Height));
                this.backPanel.Controls.Add(userAvatar);

                // 用户名
                Label userName = new Label();
                userName.AutoSize = true;
                userName.Font = new Font("宋体", 12F);
                userName.Location = new Point(98, 98 + 70 * (index - 1));
                userName.Margin = new Padding(3, 0, 3, 0);
                userName.Name = "userName" + index;
                userName.Text = relationUser.User_name;
                this.backPanel.Controls.Add(userName);


                // 更改权限
                Button userChange = new Button();
                userChange.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(155)))), ((int)(((byte)(213)))));
                userChange.Font = new Font("宋体", 11F);
                userChange.ForeColor = Color.White;
                userChange.Location = new Point(721, 90 + 70 * (index - 1));
                userChange.Margin = new Padding(3, 3, 3, 3);
                userChange.Name = "userChange" + relationUser.User_Id;
                userChange.Size = new Size(100, 35);
                userChange.Text = "更改权限";
                userChange.UseVisualStyleBackColor = false;
                userChange.Click += new EventHandler(this.userChange_Click);
                this.backPanel.Controls.Add(userChange);


                // 分割线
                Panel panel = new Panel();
                panel.BorderStyle = BorderStyle.FixedSingle;
                panel.Location = new Point(38, 142 + 70 * (index - 1));
                panel.Margin = new Padding(3, 3, 3, 3);
                panel.Name = "panel" + index;
                panel.Size = new Size(783, 1);
                this.backPanel.Controls.Add(panel);


                // 删除图标
                PictureBox deleteImg = new PictureBox();
                ((System.ComponentModel.ISupportInitialize)(deleteImg)).BeginInit();
                deleteImg.Image = global::GameForum.Properties.Resources.u225;
                deleteImg.Location = new Point(667, 93 + 70 * (index - 1));
                deleteImg.Margin = new Padding(3, 3, 3, 3);
                deleteImg.Name = "deleteImg" + relationUser.User_Id;
                deleteImg.Size = new Size(30, 30);
                deleteImg.SizeMode = PictureBoxSizeMode.StretchImage;
                deleteImg.Click += new EventHandler(this.deleteImg_Click);
                this.backPanel.Controls.Add(deleteImg);

            }
            this.userNum.Text = "共" + index + "人";

            return index;
        }



        private void userChange_Click(object sender, EventArgs e)
        {
            string btnName = ((Button)sender).Name;
            int user_id = int.Parse(btnName.Substring(10));

            MessageBox.Show("功能开发中 --- " + user_id, "权限更改", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void deleteImg_Click(object sender, EventArgs e)
        {
            string pictureBoxName = ((PictureBox)sender).Name;
            int user_id = int.Parse(pictureBoxName.Substring(9));

            // 发送Post请求，删除用户
            string url = "http://localhost:8080/forum/UserDelete";
            string postData = "userId=" + LoginInfo.CurrentUser.UserId + "&userName=" + LoginInfo.CurrentUser.UserName;
            postData += "&deletedUserId=" + user_id;

            string value = HttpHelper.sendPostRequest(url, postData);
            JObject message = JObject.Parse(value);
            if(message["result"].ToString() == "success")
            {
                // 删除用户成功
                UserManageForm userManageForm = new UserManageForm();
                this.Close();
                userManageForm.Show();
            }
            else
            {
                MessageBox.Show("error, " + message["result"].ToString(), "删除用户", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
    }
}
