using Newtonsoft.Json;
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
    public partial class SingleGameDetailForm : Form
    {
        private string gameId;
        private int commentCount;
        private string rootDir = "D:\\MySQL";

        public SingleGameDetailForm()
        {
            InitializeComponent();
        }

        
        public SingleGameDetailForm(string gameId)
        {
            InitializeComponent();


            this.gameId = gameId;
            initHide();
            fillDataWithGame();             // 游戏信息
            fillDataWithIntroduction();     // 游戏简介
            commentCount = fillDataWithComment();   // 游戏评论
        }


        private void initHide()
        {
            this.commentPanel2.Visible = false;
            this.commentPanel1.Visible = false;
        }



        private SingleGame getSingleGame()
        {
            string url = "http://localhost:8080/gameforum/v1/game/getSingleGame?gameId=" + gameId;
            string value = HttpHelper.sendGetRequest(url);

            JObject message = JObject.Parse(value);

            string result = message["result"].ToString();
            if(result == "success")
            {
                // var arrData = JArray.Parse(message["singleGame"].ToString());
                // SingleGame singleGame = arrData.ToObject<List<SingleGame>>().First();

                // JSON反序列化
                SingleGame singleGame = JsonConvert.DeserializeObject<SingleGame>(message["singleGame"].ToString());
                return singleGame;
            }
            else
            {
                MessageBox.Show("访问后台错误", "获取游戏信息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }


        private void fillDataWithGame()
        {
            SingleGame singleGame = getSingleGame();
            if (singleGame == null)
            {
                return;
            }
            
            // 游戏panel
            Panel gameItemPanel = new Panel();
            gameItemPanel.SuspendLayout();
            gameItemPanel.BackColor = Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            gameItemPanel.Location = new Point(190, 110);
            gameItemPanel.Name = "gameItemPanel_" + singleGame.Game_id;
            gameItemPanel.Size = new Size(959, 160);
            gameItemPanel.ResumeLayout(false);
            gameItemPanel.PerformLayout();
            this.Controls.Add(gameItemPanel);


            // 游戏图像
            PictureBox gameImg = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)(gameImg)).BeginInit();
            gameImg.Load(rootDir + singleGame.Game_img);
            gameImg.Location = new Point(20, 13);
            gameImg.Name = "gameImg";
            gameImg.Size = new Size(110, 134);
            gameImg.SizeMode = PictureBoxSizeMode.StretchImage;
            gameItemPanel.Controls.Add(gameImg);

            // 游戏名
            Label gameName = new Label();
            gameName.AutoSize = true;
            gameName.Font = new Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            gameName.ForeColor = Color.Red;
            gameName.Location = new Point(150, 13);
            gameName.Name = "gameName";
            gameName.Text = singleGame.Game_name;
            gameItemPanel.Controls.Add(gameName);

            // 热度
            // todo1: 爬取热度
            Label gamePopularity = new Label();
            gamePopularity.AutoSize = true;
            gamePopularity.Font = new Font("Arial", 8F);
            gamePopularity.ForeColor = Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            gamePopularity.Location = new Point(gameName.Location.X + gameName.Size.Width, 17);
            gamePopularity.Name = "gamePopularity";
            gamePopularity.Text = "热度：1";
            gameItemPanel.Controls.Add(gamePopularity);


            // 分割线
            Panel gamePanel = new Panel();
            gamePanel.BackColor = Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            gamePanel.Location = new Point(150, 50);
            gamePanel.Size = new Size(674, 4);
            gameItemPanel.Controls.Add(gamePanel);


            // 官方网站
            // todo2: 网站地址放哪
            Label gameWebsite = new Label();
            gameWebsite.AutoSize = true;
            gameWebsite.Font = new Font("Arial", 9F);
            gameWebsite.Location = new Point(150, 69);
            gameWebsite.Name = "gameWebsite";
            gameWebsite.Text = "官方网站：点击进入";
            gameItemPanel.Controls.Add(gameWebsite);


            // 类型
            Label gameType = new Label();
            gameType.AutoSize = true;
            gameType.Font = new Font("Arial", 9F);
            gameType.Location = new Point(150, 99);
            gameType.Name = "gameType";
            gameType.Text = "类型：" + singleGame.Game_type;
            gameItemPanel.Controls.Add(gameType);


            // 标签
            Label gameLabel = new Label();
            gameLabel.AutoSize = true;
            gameLabel.Font = new Font("Arial", 9F);
            gameLabel.Location = new Point(150, 129);
            gameLabel.Name = "gameLabel";
            gameLabel.Text = "标签：" + String.Join("  ", JsonHelper.jsonToArray(singleGame.Game_label));
            gameItemPanel.Controls.Add(gameLabel);



            // 整理时间
            Label gameArrangeDate = new Label();
            gameArrangeDate.AutoSize = true;
            gameArrangeDate.Font = new Font("Arial", 9F);
            gameArrangeDate.Location = new Point(365, 69);
            gameArrangeDate.Name = "gameArrangeDate";
            gameArrangeDate.Text = "整理：" + singleGame.Game_arrange_date;
            gameItemPanel.Controls.Add(gameArrangeDate);


            // 平台
            Label gamePlatform = new Label();
            gamePlatform.AutoSize = true;
            gamePlatform.Font = new Font("Arial", 9F);
            gamePlatform.Location = new Point(365, 99);
            gamePlatform.Name = "gamePlatform";
            gamePlatform.Text = "平台：" + singleGame.Game_platform;
            gameItemPanel.Controls.Add(gamePlatform);


            // 开发发行
            Label gameRelease = new Label();
            gameRelease.AutoSize = true;
            gameRelease.Font = new Font("Arial", 9F);
            gameRelease.Location = new Point(365, 129);
            gameRelease.Name = "gameRelease";
            gameRelease.Text = "开发发行：" + singleGame.Game_release;
            gameItemPanel.Controls.Add(gameRelease);


            // 发售日期
            Label gameReleaseDate = new Label();
            gameReleaseDate.AutoSize = true;
            gameReleaseDate.Font = new Font("Arial", 9F);
            gameReleaseDate.Location = new Point(590, 69);
            gameReleaseDate.Name = "gameReleaseDate";
            gameReleaseDate.Text = "发售：" + singleGame.Game_release_date;
            gameItemPanel.Controls.Add(gameReleaseDate);


            // 语言
            Label gameLanguage = new Label();
            gameLanguage.AutoSize = true;
            gameLanguage.Font = new Font("Arial", 9F);
            gameLanguage.Location = new Point(590, 99);
            gameLanguage.Name = "gameLanguage";
            gameLanguage.Text = "语言：" + singleGame.Game_language;
            gameItemPanel.Controls.Add(gameLanguage);





            // 评分人数
            Label gameRaterNum = new Label();
            gameRaterNum.AutoSize = true;
            gameRaterNum.Font = new Font("微软雅黑", 10F);
            gameRaterNum.Location = new Point(849, 84);
            gameRaterNum.Name = "gameRaterNum";
            gameRaterNum.Text = singleGame.Game_rater_num + "人评分";
            gameItemPanel.Controls.Add(gameRaterNum);


            // 游戏收藏
            Button gameCollect = new Button();
            gameCollect.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(155)))), ((int)(((byte)(213)))));
            gameCollect.ForeColor = Color.White;
            gameCollect.Location = new Point(830, 110);
            gameCollect.Name = "gameCollect_" + singleGame.Game_id;
            gameCollect.Size = new Size(100, 30);
            gameCollect.Text = "收藏";
            gameCollect.UseVisualStyleBackColor = false;
            gameCollect.Click += new EventHandler(this.gameCollect_Click);
            gameItemPanel.Controls.Add(gameCollect);



            // 评分
            Label gameScore = new Label();
            gameScore.AutoSize = true;
            gameScore.Font = new Font("微软雅黑", 40F);
            gameScore.Location = new Point(835, 15);
            gameScore.Name = "gameScore";
            gameScore.Text = String.Format("{0:F1}", singleGame.Game_score);       // 固定一位小数
            gameItemPanel.Controls.Add(gameScore);

            ((System.ComponentModel.ISupportInitialize)(gameImg)).EndInit();

        }



        private void gameCollect_Click(object sender, EventArgs e)
        {
            if (LoginInfo.CurrentUser.UserId == "")
            {
                // 游客
                DialogResult result = MessageBox.Show("您当前以游客身份浏览，请登录后收藏", "游戏收藏", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                if (result == DialogResult.OK)
                {
                    // 确定，转到登录页面
                    // LoginForm loginForm = new LoginForm();
                    // this.Close();
                    // loginForm.Show();
                }
            }
            else
            {
                // 注册用户
                string btnName = ((Button)sender).Name;
                string gameId = btnName.Substring(12);

                // 发送post请求，添加收藏
                string url = "http://localhost:8080/gameforum/v1/collection/addCollection";
                string postData = "userId=" + LoginInfo.CurrentUser.UserId + "&gameId=" + gameId;

                string value = HttpHelper.sendPostRequest(url, postData);
                JObject message = JObject.Parse(value);
                string result = message["result"].ToString();
                if (result == "success")
                {
                    MessageBox.Show("收藏成功", "游戏收藏", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("收藏失败: " + result, "游戏收藏", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
        }




        private List<Comment> getCommentList()
        {
            // 发送get请求
            string url = "http://localhost:8080/gameforum/v1/comment/getCommentByGame?gameId=" + this.gameId;
            string value = HttpHelper.sendGetRequest(url);

            JObject message = JObject.Parse(value);
            if(message["result"].ToString() == "success")
            {
                var arrData = JArray.Parse(message["commentList"].ToString());
                List<Comment> commentList = arrData.ToObject<List<Comment>>();
                return commentList;
            }
            else
            {
                MessageBox.Show("获取评论列表失败: " + message["result"].ToString(), "获取评论提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }



        /// <summary>
        /// 填充评论
        /// </summary>
        private int fillDataWithComment()
        {
            List<Comment> commentList = getCommentList();
            if (commentList == null)
            {
                return 0;
            }
            int index = 0;
            foreach(Comment comment in commentList)
            {
                index++;
                // 评论背景
                Panel commentPanel = new Panel();
                commentPanel.SuspendLayout();
                commentPanel.BorderStyle = BorderStyle.FixedSingle;
                commentPanel.Location = new Point(190, 860 + 175*(index-1));
                commentPanel.Name = "commentPanel" + index;
                commentPanel.Size = new Size(824, 175);
                this.Controls.Add(commentPanel);
                commentPanel.ResumeLayout(false);
                commentPanel.PerformLayout();

                // 用户头像
                PictureBox avatar = new PictureBox();
                ((System.ComponentModel.ISupportInitialize)(avatar)).BeginInit();
                avatar.Image = global::GameForum.Properties.Resources.u657;
                avatar.Location = new Point(20, 18);
                avatar.Size = new Size(60, 60);
                avatar.SizeMode = PictureBoxSizeMode.StretchImage;
                commentPanel.Controls.Add(avatar);
                ((System.ComponentModel.ISupportInitialize)(avatar)).EndInit();

                // 楼层
                // todo: 倒序
                Label floorNum = new Label();
                floorNum.AutoSize = true;
                floorNum.Font = new Font("宋体", 12F);
                floorNum.Location = new Point(31, 94);
                floorNum.Name = "floorNum" + index;
                floorNum.Text = "第" + index + "楼";
                commentPanel.Controls.Add(floorNum);


                // 关注
                Button followBtn = new Button();
                followBtn.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(155)))), ((int)(((byte)(213)))));
                followBtn.Font = new Font("宋体", 11F);
                followBtn.ForeColor = Color.White;
                followBtn.Location = new Point(20, 122);
                followBtn.Name = "followBtn_" + comment.User_id_from;
                followBtn.Size = new Size(60, 30);
                followBtn.Text = "关注";
                followBtn.UseVisualStyleBackColor = false;
                followBtn.Click += new EventHandler(this.followBtn_Click);
                commentPanel.Controls.Add(followBtn);

                // 用户名
                Label userName = new Label();
                userName.AutoSize = true;
                userName.Font = new Font("宋体", 12F);
                userName.ForeColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(155)))), ((int)(((byte)(213)))));
                userName.Location = new Point(108, 30);
                userName.Name = "userName" + index;
                userName.Text = comment.User_name;
                commentPanel.Controls.Add(userName);


                // 用户标签
                // todo: 榜主和注册用户区分
                Label userLabel = new Label();
                userLabel.AutoSize = true;
                userLabel.BackColor = Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
                userLabel.Font = new Font("宋体", 11F);
                userLabel.ForeColor = Color.White;
                userLabel.Location = new Point(164, 30);
                userLabel.Name = "userLabel" + index;
                userLabel.Text = comment.Priority;
                commentPanel.Controls.Add(userLabel);

                // 评论内容
                Label userComment = new Label();
                userComment.AutoSize = true;
                userComment.Font = new Font("宋体", 12F);
                userComment.Location = new Point(108, 85);
                userComment.Name = "userComment" + index;
                userComment.Text = comment.Content;
                commentPanel.Controls.Add(userComment);


                // 评论时间
                Label commentTime = new Label();
                commentTime.AutoSize = true;
                commentTime.Font = new Font("宋体", 11F);
                commentTime.ForeColor = Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(172)))), ((int)(((byte)(172)))));
                commentTime.Location = new Point(686, 32);
                commentTime.Name = "commentTime" + index;
                commentTime.Text = TimeHelper.GetTime(comment.Comment_time, true).ToString("yyyy-MM-dd HH:mm");
                commentPanel.Controls.Add(commentTime);


                // 回复评论
                Button replyBtn = new Button();
                replyBtn.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(155)))), ((int)(((byte)(213)))));
                replyBtn.Font = new Font("宋体", 11F);
                replyBtn.ForeColor = Color.White;
                replyBtn.Location = new Point(746, 122);
                replyBtn.Name = "replyBtn_" + comment.Comment_id;
                replyBtn.Size = new Size(78, 30);
                replyBtn.Text = "回复";
                replyBtn.UseVisualStyleBackColor = false;
                replyBtn.Click += new EventHandler(this.replyBtn_Click);
                commentPanel.Controls.Add(replyBtn);
            }


            return index;
        }

        private void evaluationPublish_Click(object sender, EventArgs e)
        {
            if(LoginInfo.CurrentUser.UserId == "")
            {
                // 游客
                MessageBox.Show("游客不能评论，请登录后重试！", "评论提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                // 注册用户
                string content = this.evaluationContent.Text.Trim();
                if (content != "")
                {
                    // 发送post请求，提交评论
                    string url = "http://localhost:8080/gameforum/v1/comment/publishComment";
                    string postData = "userIdFrom=" + LoginInfo.CurrentUser.UserId + "&gameId=" + this.gameId + "&content=" + content;

                    string value = HttpHelper.sendPostRequest(url, postData);
                    JObject message = JObject.Parse(value);
                    string result = message["result"].ToString();
                    if (result == "success")
                    {
                        // 评论成功，刷新评论列表
                        MessageBox.Show("评论成功");
                        this.evaluationContent.Clear();
                    }
                    else
                    {
                        MessageBox.Show("评论失败：" + result, "评论提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("评论内容不能为空", "评论提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        /// <summary>
        /// 回复按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void replyBtn_Click(object sender, EventArgs e)
        {
            if(LoginInfo.CurrentUser.UserId == "")
            {
                // 游客
                MessageBox.Show("游客不能评论，请登录后重试！", "评论提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                // 注册用户
                string btnName = ((Button)sender).Name;
                int parentId = int.Parse(btnName.Substring(9));
                MessageBox.Show("功能开发中 - " + parentId, "评论提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void returnImg_Click(object sender, EventArgs e)
        {
            // [done] todo: 返回主窗口
            SingleForm singleForm = (SingleForm)MainWindow.MainForm;
            this.Close();
            singleForm.Show();
        }

        /// <summary>
        /// 关注按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void followBtn_Click(object sender, EventArgs e)
        {
            if(LoginInfo.CurrentUser.UserId == "")
            {
                // 游客
                MessageBox.Show("游客不能关注，请登录后重试！", "关注提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                // 注册用户
                string btnName = ((Button)sender).Name;
                int userId = int.Parse(btnName.Substring(10));


                if (Convert.ToInt32(LoginInfo.CurrentUser.UserId) == userId)
                {
                    MessageBox.Show("您不能关注自己", "关注提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                // 发送post请求
                string url = "http://localhost:8080/forum/FollowUser";
                string postData = "idolUserId=" + userId + "&fanUserId=" + LoginInfo.CurrentUser.UserId;

                string value = HttpHelper.sendPostRequest(url, postData);
                JObject message = JObject.Parse(value);
                string result = message["result"].ToString();
                if (result == "success")
                {
                    MessageBox.Show("关注成功", "关注用户", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoginInfo.CurrentUser.FollowNum = LoginInfo.CurrentUser.FollowNum + 1;
                }
                else
                {
                    MessageBox.Show("关注失败: " + result, "关注用户", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        /// <summary>
        /// 获取游戏简介
        /// </summary>
        /// <returns>有简介返回简介，没有或出错返回Null</returns>
        private string getGameIntroduction()
        {
            // 发送get请求
            string url = "http://localhost:8080/gameforum/v1/game/getGameIntroduction?gameId=" + this.gameId;
            string value = HttpHelper.sendGetRequest(url);

            JObject message = JObject.Parse(value);
            string result = message["result"].ToString();
            if (result == "success")
            {
                if (message["gameIntroduction"] == null)
                {
                    return null;
                }
                return message["gameIntroduction"].ToString();      // 有可能是null
            }
            else
            {
                MessageBox.Show("获取游戏简介出错：" + result, "获取游戏简介", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        /// <summary>
        /// 填充游戏简介
        /// </summary>
        private void fillDataWithIntroduction()
        {
            string gameIntroduction = getGameIntroduction();
            if (gameIntroduction == null)
            {
                gameIntroduction = "该游戏暂无游戏简介";
            }
            this.introductionLabel.Text = gameIntroduction;
        }

        private void evaluationContent_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A && e.Control)
            {
                this.evaluationContent.SelectAll();
            } else if (e.KeyCode == Keys.Back && e.Control)
            {
                this.evaluationContent.Clear();
            }
        }
    }
}
