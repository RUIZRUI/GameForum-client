using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;

namespace GameForum
{
    public partial class FansForm : Form
    {
        private int fanCount;       // 粉丝数

        public FansForm()
        {
            InitializeComponent();

            if (LoginInfo.CurrentUser.UserId != "")
            {
                // 注册用户
                fanCount = fillData();
            }
        }


        private void backPanelInit()
        {
            this.backPanel.Controls.Add(this.title);
            this.backPanel.Controls.Add(this.fanNum);
            this.backPanel.Controls.Add(this.panel1);
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

        private void personalList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = this.personalList.SelectedIndex;
            if (index == 0)
            {
                PersonalCenterForm personalCenterForm = new PersonalCenterForm();
                this.Close();
                personalCenterForm.Show();
            }
            else if (index == 1)
            {
                CollectionForm collectionForm = new CollectionForm();
                this.Close();
                collectionForm.Show();
            }
            else if (index == 2)
            {
                FollowsForm followsForm = new FollowsForm();
                this.Close();
                followsForm.Show();
            }
            else if (index == 3)
            {
                // nothing
            }
            else if (index == 4)
            {
                CommentForm commentForm = new CommentForm();
                this.Close();
                commentForm.Show();
            }
        }


        /// <summary>
        /// 获取粉丝列表
        /// </summary>
        /// <returns></returns>
        private List<RelationUser> getFanUser()
        {
            string url = "http://localhost:8080/gameforum/v1/follow/getFans?userId=" + LoginInfo.CurrentUser.UserId;
            string value = HttpHelper.sendGetRequest(url);

            JObject message = JObject.Parse(value);
            if (message["fanList"].ToString() == "null")
            {
                return null;
            }
            else
            {
                var arrData = JArray.Parse(message["fanList"].ToString());
                List<RelationUser> fanList = arrData.ToObject<List<RelationUser>>();
                return fanList;
            }
        }



        /// <summary>
        /// 填充数据
        /// </summary>
        /// <returns></returns>
        private int fillData()
        {
            List<RelationUser> fanList = getFanUser();
            if (fanList == null)
            {
                return 0;
            }
            int index = 0;
            foreach(RelationUser relationUser in fanList)
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

                // 相互关注
                Button mutualFollow = new Button();
                mutualFollow.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(155)))), ((int)(((byte)(213)))));
                mutualFollow.Font = new Font("宋体", 11F);
                mutualFollow.ForeColor = Color.White;
                mutualFollow.Location = new Point(638, 90 + 70 * (index - 1));
                mutualFollow.Margin = new Padding(3, 3, 3, 3);
                mutualFollow.Name = "mutualFollow_" + relationUser.User_Id;
                mutualFollow.Size = new Size(100, 35);
                mutualFollow.Text = "相互关注";
                mutualFollow.UseVisualStyleBackColor = false;
                mutualFollow.Click += new EventHandler(this.mutualFollow_Click);
                this.backPanel.Controls.Add(mutualFollow);


                // 分割线
                Panel panel = new Panel();
                panel.BorderStyle = BorderStyle.FixedSingle;
                panel.Location = new Point(38, 142 + 70 * (index - 1));
                panel.Margin = new Padding(3, 3, 3, 3);
                panel.Name = "panel" + index;
                panel.Size = new Size(700, 1);
                this.backPanel.Controls.Add(panel);

            }
            this.fanNum.Text = "共" + index + "人";
            return index;
        }



        /// <summary>
        /// 相互关注按钮实现
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mutualFollow_Click(object sender, EventArgs e)
        {
            string btnName = ((Button)sender).Name;
            int userId = Convert.ToInt32(btnName.Substring(13));

            // 发送post请求，添加关注
            string url = "http://localhost:8080/gameforum/v1/follow/followUser";
            string postData = "idolUserId=" + userId + "&fanUserId=" + LoginInfo.CurrentUser.UserId;

            string value = HttpHelper.sendPostRequest(url, postData);
            JObject message = JObject.Parse(value);
            string result = message["result"].ToString();
            if (result == "success")
            {
                // 相互关注成功，刷新
                this.backPanel.Controls.Clear();
                backPanelInit();
                fanCount = fillData();

                LoginInfo.CurrentUser.FollowNum = LoginInfo.CurrentUser.FollowNum + 1;
            }
            else
            {
                MessageBox.Show("相互关注失败: " + result, "相互关注", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // 查找控件
            /* Control control = this.backPanel.Controls.Find(otherUserLabelName, true)[0];
            if(control != null)
            {
                // 转为 Label
                Label otherUserLabel = control as Label;
                string otherUserName = otherUserLabel.Text;

                // 发送Post请求，相互关注（添加关注)
                string url = "http://localhost:8080/forum/AddFollow";
                string postData = "userName=" + LoginInfo.CurrentUser.UserName + "&otherUserName=" + otherUserName;

                string value = HttpHelper.sendPostRequest(url, postData);
                JObject message = JObject.Parse(value);
                if (message["result"].ToString() == "success")
                {
                    // 相互关注成功，刷新
                    FansForm fansForm = new FansForm();
                    this.Close();
                    fansForm.Show();
                }
                else
                {
                    MessageBox.Show("error, " + message["result"].ToString());
                }

            }
            else
            {
                MessageBox.Show("没有找到对应用户名");
            } */
        }

    }
}
