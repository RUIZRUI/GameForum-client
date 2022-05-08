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
    public partial class CommentForm : Form
    {
        private int commentCountToMe;       // 回复我的评论数
        private int commentCountFromMe;     // 我发布的评论数
        private bool commentToMe = true;    // 当前是否是“回复我的评论”

        public CommentForm()
        {
            InitializeComponent();

            if (LoginInfo.CurrentUser.UserId != "")
            {
                // 注册用户
                commentCountToMe = fillDataWithCommentToMe();
            }
        }


        /// <summary>
        /// backPanel 重新添加顶部控件
        /// </summary>
        private void backPanelInit()
        {
            this.backPanel.Controls.Add(this.title1);

            this.backPanel.Controls.Add(this.title2);

            this.backPanel.Controls.Add(this.panel1);

            this.backPanel.Controls.Add(this.commentNum);
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
                FansForm fansForm = new FansForm();
                this.Close();
                fansForm.Show();
            }
            else if (index == 4)
            {
                // nothing
            }
        }


        /// <summary>
        /// 获取回复给用户的评论列表
        /// </summary>
        /// <param name="commentType">GetCommentToMe | GetCommentFromMe</param>
        /// <returns></returns>
        private List<MyComment> GetCommentToMe(string commentType)
        {
            string url = "http://localhost:8080/forum/" + commentType + "?userId=" + LoginInfo.CurrentUser.UserId;
            string value = HttpHelper.sendGetRequest(url);

            JObject message = JObject.Parse(value);
            if (message["result"].ToString() == "null")
            {
                MessageBox.Show("获取用户的评论失败", "我的评论", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            else
            {
                var arrData = JArray.Parse(message["result"].ToString());
                List<MyComment> commentList = arrData.ToObject<List<MyComment>>();
                return commentList;
            }
        }



        /// <summary>
        /// 回复我的评论填充数据
        /// </summary>
        /// <returns></returns>
        private int fillDataWithCommentToMe()
        {
            List<MyComment> commentList = GetCommentToMe("GetCommentToMe");
            if (commentList == null)
            {
                return 0;
            }
            int index = 0;
            foreach(MyComment comment in commentList)
            {
                index++;
                // 游戏标签
                Label gameLabel = new Label();
                gameLabel.AutoSize = true;
                gameLabel.BorderStyle = BorderStyle.FixedSingle;
                gameLabel.Font = new Font("宋体", 11F);
                gameLabel.ForeColor = Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
                gameLabel.Location = new Point(38, 80 + 70 * (index - 1));
                gameLabel.Margin = new Padding(3, 0, 3, 0);
                gameLabel.Name = "gameLabel" + index;
                gameLabel.Padding = new Padding(1, 4, 1, 4);
                gameLabel.Text = comment.Game_belong;
                this.backPanel.Controls.Add(gameLabel);


                // 用户名
                Label userName = new Label();
                userName.AutoSize = true;
                userName.Font = new Font("宋体", 12F);
                userName.ForeColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(155)))), ((int)(((byte)(213)))));
                userName.Location = new Point(gameLabel.Location.X + gameLabel.Width + 10, 84 + 70*(index - 1));
                userName.Margin = new Padding(3, 0, 3, 0);
                userName.Name = "userName" + index;
                userName.Text = comment.Other_name;
                this.backPanel.Controls.Add(userName);


                // 旁白文本
                Label gameTxt = new Label();
                gameTxt.AutoSize = true;
                gameTxt.Font = new Font("宋体", 12F);
                gameTxt.Location = new Point(userName.Location.X + userName.Width, 84 + 70 * (index - 1));
                gameTxt.Margin = new Padding(3, 0, 3, 0);
                gameTxt.Name = "gameTxt" + index;
                gameTxt.Text = "回复了你的评论";
                this.backPanel.Controls.Add(gameTxt);


                // 游戏名
                Label gameName = new Label();
                gameName.AutoSize = true;
                gameName.Font = new Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                gameName.Location = new Point(38, 115 + 70 * (index - 1));
                gameName.Margin = new Padding(3, 0, 3, 0);
                gameName.Name = "gameName" + index;
                gameName.Text = comment.Game_name;
                this.backPanel.Controls.Add(gameName);


                // 评论日期
                Label commentDate = new Label();
                commentDate.AutoSize = true;
                commentDate.Font = new Font("宋体", 12F);
                commentDate.ForeColor = Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
                commentDate.Location = new Point(655, 112 + 70*(index-1));
                commentDate.Margin = new Padding(3, 0, 3, 0);
                commentDate.Name = "commentDate" + index;
                commentDate.Text = comment.Comment_time.ToString("yyyy-MM-dd");
                this.backPanel.Controls.Add(commentDate);


                // 删除图标
                /* PictureBox deleteImg = new PictureBox();
                ((System.ComponentModel.ISupportInitialize)(deleteImg)).BeginInit();
                deleteImg.Image = global::GameForum.Properties.Resources.u225;
                deleteImg.Location = new Point(718, 82 + 70 * (index - 1));
                deleteImg.Margin = new Padding(3, 3, 3, 3);
                deleteImg.Name = "deleteImg" + comment.Comment_id;
                deleteImg.Size = new Size(20, 20);
                deleteImg.SizeMode = PictureBoxSizeMode.StretchImage;
                deleteImg.Click += new EventHandler(this.deleteImg_Click);
                this.backPanel.Controls.Add(deleteImg); */


                // 分割线
                Panel panel = new Panel();
                panel.BorderStyle = BorderStyle.FixedSingle;
                panel.Location = new Point(38, 142 + 70 * (index - 1));
                panel.Margin = new Padding(3, 3, 3, 3);
                panel.Name = "panel" + index;
                panel.Size = new Size(700, 1);
                this.backPanel.Controls.Add(panel);

            }
            // 评论数目
            this.commentNum.Text = index + "条评论";
            this.commentNum.Location = new Point(731 - commentNum.Width, 34);
            return index;
        }


        /// <summary>
        /// 我发布的评论填充数据
        /// </summary>
        /// <returns></returns>
        private int fillDataWithCommentFromMe()
        {
            List<MyComment> commentList = GetCommentToMe("GetCommentFromMe");
            if (commentList == null)
            {
                return 0;
            }
            int index = 0;
            foreach (MyComment comment in commentList)
            {
                index++;
                // 游戏标签
                Label gameLabel = new Label();
                gameLabel.AutoSize = true;
                gameLabel.BorderStyle = BorderStyle.FixedSingle;
                gameLabel.Font = new Font("宋体", 11F);
                gameLabel.ForeColor = Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
                gameLabel.Location = new Point(38, 80 + 70 * (index - 1));
                gameLabel.Margin = new Padding(3, 0, 3, 0);
                gameLabel.Name = "gameLabel" + index;
                gameLabel.Padding = new Padding(1, 4, 1, 4);
                gameLabel.Text = comment.Game_belong;
                this.backPanel.Controls.Add(gameLabel);


                // 旁白文本
                Label gameTxt = new Label();
                gameTxt.AutoSize = true;
                gameTxt.Font = new Font("宋体", 12F);
                gameTxt.Location = new Point(gameLabel.Location.X + gameLabel.Width + 10, 84 + 70 * (index - 1));
                gameTxt.Margin = new Padding(3, 0, 3, 0);
                gameTxt.Name = "gameTxt" + index;
                gameTxt.Text = "你回复了";
                this.backPanel.Controls.Add(gameTxt);



                // 用户名
                Label userName = new Label();
                userName.AutoSize = true;
                userName.Font = new Font("宋体", 12F);
                userName.ForeColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(155)))), ((int)(((byte)(213)))));
                userName.Location = new Point(gameTxt.Location.X + gameTxt.Width, 84 + 70 * (index - 1));
                userName.Margin = new Padding(3, 0, 3, 0);
                userName.Name = "userName" + index;
                userName.Text = comment.Other_name == null ? "游戏" : comment.Other_name;
                this.backPanel.Controls.Add(userName);


                // 游戏名
                Label gameName = new Label();
                gameName.AutoSize = true;
                gameName.Font = new Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                gameName.Location = new Point(38, 115 + 70 * (index - 1));
                gameName.Margin = new Padding(3, 0, 3, 0);
                gameName.Name = "gameName" + index;
                gameName.Text = comment.Game_name;
                this.backPanel.Controls.Add(gameName);


                // 评论日期
                Label commentDate = new Label();
                commentDate.AutoSize = true;
                commentDate.Font = new Font("宋体", 12F);
                commentDate.ForeColor = Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
                commentDate.Location = new Point(655, 112 + 70 * (index - 1));
                commentDate.Margin = new Padding(3, 0, 3, 0);
                commentDate.Name = "commentDate" + index;
                commentDate.Text = comment.Comment_time.ToString("yyyy-MM-dd");
                this.backPanel.Controls.Add(commentDate);


                // 删除图标
                PictureBox deleteImg = new PictureBox();
                ((System.ComponentModel.ISupportInitialize)(deleteImg)).BeginInit();
                deleteImg.Image = global::GameForum.Properties.Resources.u225;
                deleteImg.Location = new Point(718, 82 + 70 * (index - 1));
                deleteImg.Margin = new Padding(3, 3, 3, 3);
                deleteImg.Name = "deleteImg" + comment.Comment_id;
                deleteImg.Size = new Size(20, 20);
                deleteImg.SizeMode = PictureBoxSizeMode.StretchImage;
                deleteImg.Click += new EventHandler(this.deleteImg_Click);
                this.backPanel.Controls.Add(deleteImg);


                // 分割线
                Panel panel = new Panel();
                panel.BorderStyle = BorderStyle.FixedSingle;
                panel.Location = new Point(38, 142 + 70 * (index - 1));
                panel.Margin = new Padding(3, 3, 3, 3);
                panel.Name = "panel" + index;
                panel.Size = new Size(700, 1);
                this.backPanel.Controls.Add(panel);
            }
            // 清空
            Label clear = new Label();
            clear.AutoSize = true;
            clear.Font = new Font("宋体", 12F);
            clear.Location = new Point(691, 34);
            clear.Name = "clear";
            clear.Size = new Size(40, 16);
            clear.Text = "清空";
            clear.Click += new EventHandler(this.clear_Click);
            this.backPanel.Controls.Add(clear);

            // 其他分割线
            Panel otherPanel = new Panel();
            otherPanel.BorderStyle = BorderStyle.FixedSingle;
            otherPanel.Location = new Point(676, 34);
            otherPanel.Name = "otherPanel";
            otherPanel.Size = new Size(1, 18);
            this.backPanel.Controls.Add(otherPanel);

            // 评论数目
            commentNum.Text = index + "条评论";
            commentNum.Location = new Point(clear.Location.X - commentNum.Width - 30, 34);
            return index;
        }




        /// <summary>
        /// 转到发给的评论
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void title1_Click(object sender, EventArgs e)
        {
            if (LoginInfo.CurrentUser.UserId == "")
            {
                MessageBox.Show("对不起，您当前是游客身份，请登录后重试", "我的评论", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                return;
            }
            if (!commentToMe)
            {
                // backPanel 清空控件
                this.backPanel.Controls.Clear();

                // backPanel 重新添加顶部控件
                backPanelInit();

                // 填充数据
                commentCountToMe = fillDataWithCommentToMe();

                // 更改标志变量
                commentToMe = true;
            }
        }


        /// <summary>
        /// 转到我发布的评论
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void title2_Click(object sender, EventArgs e)
        {
            if (LoginInfo.CurrentUser.UserId == "")
            {
                MessageBox.Show("对不起，您当前是游客身份，请登录后重试", "我的评论", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                return;
            }
            if (commentToMe)
            {
                // backPanel 清空控件
                this.backPanel.Controls.Clear();

                // backPanel 重新添加顶部控件
                backPanelInit();

                // 填充数据
                commentCountFromMe = fillDataWithCommentFromMe();

                // 更改标志变量
                commentToMe = false;
            }
        }


        private void deleteImg_Click(object sender, EventArgs e)
        {
            string pictureBoxName = ((PictureBox)sender).Name;
            int commentId = int.Parse(pictureBoxName.Substring(9));

            // 发送post请求，删除评论
            string url = "http://localhost:8080/forum/DeleteComment";
            string postData = "commentId=" + commentId + "&userId=" + LoginInfo.CurrentUser.UserId;

            string value = HttpHelper.sendPostRequest(url, postData);
            JObject message = JObject.Parse(value);
            if (message["result"].ToString() == "success")
            {
                // 当前是 “我发布的评论”
                this.backPanel.Controls.Clear();
                backPanelInit();
                commentCountFromMe = fillDataWithCommentFromMe();
            }
            else
            {
                MessageBox.Show("删除评论失败: " + message["result"].ToString(), "删除评论", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            if (commentToMe)
            {
                MessageBox.Show("对不起，您不能清空回复给您的评论", "清空评论", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (!commentToMe && commentCountFromMe == 0)
            {
                MessageBox.Show("您当前没有发布评论", "清空评论", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            // 弹出对话框，是否确定清空
            if (MessageBox.Show("清空后不可找回，是否确定清空", "清空评论", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.Cancel)
            {
                return;
            }

            // 发送post请求，清空用户发布的评论
            string url = "http://localhost:8080/forum/ClearCommentByUser";
            string postData = "userId=" + LoginInfo.CurrentUser.UserId;
            string value = HttpHelper.sendPostRequest(url, postData);

            JObject message = JObject.Parse(value);
            string result = message["result"].ToString();
            if (result == "success")
            {
                // 清空评论成功，刷新数据
                this.backPanel.Controls.Clear();
                backPanelInit();
                commentCountFromMe = fillDataWithCommentFromMe();
            }
            else
            {
                MessageBox.Show("清空评论失败: " + result, "清空评论", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
