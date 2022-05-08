using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;

namespace GameForum
{
    public partial class SingleForm : Form
    {
        private int singleGameCount;        // 单机游戏数
        private int sortType = 1;           // 排序方式，1表示时间排序，2表示热度排序，3表示评分排序，默认1
        private bool desc = true;           // 排序顺序，true表示由高到低，false表示由低到高，默认true

        public SingleForm()
        {
            InitializeComponent();

            formInit();

            singleGameCount = fillData();

        }


        private void formInit()
        {
            this.avatar.Image = ImageHelper.SimpleCutEllipse(this.avatar.Image);
        }



        private void avatar_Click(object sender, EventArgs e)
        {
            PersonalCenterForm personalCenterForm = new PersonalCenterForm();
            this.Hide();
            personalCenterForm.Show();
        }

        private void publishBtn_Click(object sender, EventArgs e)
        {
            if(LoginInfo.CurrentUser.UserId == "")
            {
                MessageBox.Show("对不起，游客暂时无法发布游戏，请抓紧注册！", "游客提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                return;
            }
            GameManageForm gameManageForm = new GameManageForm();
            this.Hide();
            gameManageForm.Show();
        }


        /// <summary>
        /// 系统管理员入口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void systemManagerEnter_Click(object sender, EventArgs e)
        {
            if (LoginInfo.CurrentUser.UserId == "")
            {
                // 游客
                MessageBox.Show("您的身份是游客，权限不够！", "系统管理", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                // todo: 判断是否系统管理员

                // 注册用户
                SystemManagerForm systemManagerForm = new SystemManagerForm();
                this.Hide();
                systemManagerForm.Show();
            }
        }


        /// <summary>
        /// 获取所有的单机游戏
        /// </summary>
        /// <returns></returns>
        private List<SingleGame> getAllSingleGame()
        {
            // 发送get请求
            string url = "http://localhost:8080/forum/GetAllSingleGame?sortType=" + sortType + "&desc=" + desc.ToString();
            string value = HttpHelper.sendGetRequest(url);

            JObject message = JObject.Parse(value);
            if (message["result"].ToString() == "null")
            {
                return null;
            }
            else
            {
                // 如果游戏列表为空，则 result = []，不影响填充数据
                var arrData = JArray.Parse(message["result"].ToString());
                List<SingleGame> singleGameList = arrData.ToObject<List<SingleGame>>();
                return singleGameList;
            }
        }



        /// <summary>
        /// 填充数据
        /// </summary>
        private int fillData()
        {
            List<SingleGame> singleGameList = getAllSingleGame();
            if (singleGameList == null)
            {
                return 0;
            }
            int index = 0;
            foreach (SingleGame singleGame in singleGameList)
            {
                index++;
                // 每一项的panel
                Panel gameItemPanel = new Panel();
                gameItemPanel.SuspendLayout();
                gameItemPanel.BackColor = Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
                gameItemPanel.Location = new Point(5, 190*(index-1));
                gameItemPanel.Name = "gameItemPanel_" + singleGame.Game_id;
                gameItemPanel.Size = new Size(959, 160);
                gameItemPanel.ResumeLayout(false);
                gameItemPanel.PerformLayout();
                this.backPanel.Controls.Add(gameItemPanel);


                // 游戏图像
                PictureBox gameImg = new PictureBox();
                ((System.ComponentModel.ISupportInitialize)(gameImg)).BeginInit();
                gameImg.Load(singleGame.Game_img);
                gameImg.Location = new Point(20, 13);
                gameImg.Name = "gameImg" + index;
                gameImg.Size = new Size(110, 134);
                gameImg.SizeMode = PictureBoxSizeMode.StretchImage;
                gameItemPanel.Controls.Add(gameImg);

                // 游戏名
                Label gameName = new Label();
                gameName.AutoSize = true;
                gameName.Font = new Font("Arial", 14F, System.Drawing.FontStyle.Bold);
                gameName.ForeColor = Color.Red;
                gameName.Location = new Point(150, 13);
                gameName.Name = "gameName" + index;
                gameName.Text = singleGame.Game_name;
                gameItemPanel.Controls.Add(gameName);

                // 热度
                // todo1: 爬取热度
                Label gamePopularity = new Label();
                gamePopularity.AutoSize = true;
                gamePopularity.Font = new Font("Arial", 8F);
                gamePopularity.ForeColor = Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
                gamePopularity.Location = new Point(gameName.Location.X + gameName.Size.Width, 17);
                gamePopularity.Name = "gamePopularity" + index;
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
                gameWebsite.Name = "gameWebsite" + index;
                gameWebsite.Text = "官方网站：点击进入";
                gameItemPanel.Controls.Add(gameWebsite);


                // 类型
                Label gameType = new Label();
                gameType.AutoSize = true;
                gameType.Font = new Font("Arial", 9F);
                gameType.Location = new Point(150, 99);
                gameType.Name = "gameType" + index;
                gameType.Text = "类型：" + singleGame.Game_type;
                gameItemPanel.Controls.Add(gameType);


                // 标签
                Label gameLabel = new Label();
                gameLabel.AutoSize = true;
                gameLabel.Font = new Font("Arial", 9F);
                gameLabel.Location = new Point(150, 129);
                gameLabel.Name = "gameLabel" + index;
                gameLabel.Text = "标签：" + String.Join("  ", JsonHelper.jsonToArray(singleGame.Game_label));
                gameItemPanel.Controls.Add(gameLabel);



                // 整理时间
                Label gameArrangeDate = new Label();
                gameArrangeDate.AutoSize = true;
                gameArrangeDate.Font = new Font("Arial", 9F);
                gameArrangeDate.Location = new Point(365, 69);
                gameArrangeDate.Name = "gameArrangeDate" + index;
                gameArrangeDate.Text = "整理：" + singleGame.Game_arrange_date;
                gameItemPanel.Controls.Add(gameArrangeDate);


                // 平台
                Label gamePlatform = new Label();
                gamePlatform.AutoSize = true;
                gamePlatform.Font = new Font("Arial", 9F);
                gamePlatform.Location = new Point(365, 99);
                gamePlatform.Name = "gamePlatform" + index;
                gamePlatform.Text = "平台：" + singleGame.Game_platform;
                gameItemPanel.Controls.Add(gamePlatform);


                // 开发发行
                Label gameRelease = new Label();
                gameRelease.AutoSize = true;
                gameRelease.Font = new Font("Arial", 9F);
                gameRelease.Location = new Point(365, 129);
                gameRelease.Name = "gameRelease" + index;
                gameRelease.Text = "开发发行：" + singleGame.Game_release;
                gameItemPanel.Controls.Add(gameRelease);


                // 发售日期
                Label gameReleaseDate = new Label();
                gameReleaseDate.AutoSize = true;
                gameReleaseDate.Font = new Font("Arial", 9F);
                gameReleaseDate.Location = new Point(590, 69);
                gameReleaseDate.Name = "gameReleaseDate" + index;
                gameReleaseDate.Text = "发售：" + singleGame.Game_release_date;
                gameItemPanel.Controls.Add(gameReleaseDate);


                // 语言
                Label gameLanguage = new Label();
                gameLanguage.AutoSize = true;
                gameLanguage.Font = new Font("Arial", 9F);
                gameLanguage.Location = new Point(590, 99);
                gameLanguage.Name = "gameLanguage" + index;
                gameLanguage.Text = "语言：" + singleGame.Game_language;
                gameItemPanel.Controls.Add(gameLanguage);





                // 评分人数
                Label gameRaterNum = new Label();
                gameRaterNum.AutoSize = true;
                gameRaterNum.Font = new Font("微软雅黑", 10F);
                gameRaterNum.Location = new Point(849, 84);
                gameRaterNum.Name = "gameRaterNum" + index;
                gameRaterNum.Text = singleGame.Game_rater_num + "人评分";
                gameItemPanel.Controls.Add(gameRaterNum);


                // 游戏专题
                Button gameDetail = new Button();
                gameDetail.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(155)))), ((int)(((byte)(213)))));
                gameDetail.ForeColor = Color.White;
                gameDetail.Location = new Point(830, 110);
                gameDetail.Name = "gameDetail_" + singleGame.Game_id;
                gameDetail.Size = new Size(100, 30);
                gameDetail.Text = "游戏专题";
                gameDetail.UseVisualStyleBackColor = false;
                gameDetail.Click += new EventHandler(this.gameDetail_Click);
                gameItemPanel.Controls.Add(gameDetail);


                // 排名背景图像
                PictureBox sortedBack = new PictureBox();
                ((System.ComponentModel.ISupportInitialize)(sortedBack)).BeginInit();
                if(index == 1)
                {
                    sortedBack.Image = global::GameForum.Properties.Resources.u287;
                }
                else if (index == 2)
                {
                    sortedBack.Image = global::GameForum.Properties.Resources.u354;
                }
                else if (index == 3)
                {
                    sortedBack.Image = global::GameForum.Properties.Resources.u352;
                }
                else
                {
                    sortedBack.Image = global::GameForum.Properties.Resources.u385;
                }
                sortedBack.Location = new Point(921, 0);
                sortedBack.Name = "sortedBack" + index;
                sortedBack.Size = new Size(38, 38);
                sortedBack.SizeMode = PictureBoxSizeMode.StretchImage;
                gameItemPanel.Controls.Add(sortedBack);


                // 排名
                /// 更改sortedNum标签的属性，使其透明显示
                Label sortedNum = new Label();
                gameItemPanel.Controls.Add(sortedNum);
                sortedNum.AutoSize = true;
                sortedNum.BackColor = Color.Transparent;
                sortedNum.ForeColor = Color.White;
                sortedNum.Name = "sortedNum" + index;
                sortedNum.Size = new Size(39, 27);
                sortedNum.Text = "  " + index;
                sortedNum.Parent = sortedBack;
                sortedNum.Location = new Point(0, 5);
                sortedNum.Font = new Font("Arial", 18F);

                // 评分
                Label gameScore = new Label();
                gameScore.AutoSize = true;
                gameScore.Font = new Font("微软雅黑", 40F);
                gameScore.Location = new Point(835, 15);
                gameScore.Name = "gameScore" + index;
                gameScore.Text = String.Format("{0:F1}", singleGame.Game_score);       // 固定一位小数
                gameItemPanel.Controls.Add(gameScore);

                ((System.ComponentModel.ISupportInitialize)(sortedBack)).EndInit();
                ((System.ComponentModel.ISupportInitialize)(gameImg)).EndInit();
            }
            this.totalNum.Text = "" + index;
            return index;
        }



        /// <summary>
        /// 进入游戏专题
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gameDetail_Click(object sender, EventArgs e)
        {
            string btnName = ((Button)sender).Name;
            string gameId = btnName.Substring(11);

            SingleGameDetailForm singleGameDetailForm = new SingleGameDetailForm(gameId);
            this.Hide();
            singleGameDetailForm.Show();
        }

        private void singleBtn_Click(object sender, EventArgs e)
        {
            // todo: 刷新数据
            this.backPanel.Controls.Clear();
            singleGameCount = fillData();
        }

        private void indexBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("功能开发中", "主页", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void androidBtn_Click(object sender, EventArgs e)
        {
            AndroidForm androidForm = new AndroidForm();
            this.Hide();
            androidForm.Show();
        }

        private void iosBtn_Click(object sender, EventArgs e)
        {
            IOSForm iOSForm = new IOSForm();
            this.Hide();
            iOSForm.Show();
        }

        private void onlineBtn_Click(object sender, EventArgs e)
        {
            OnlineForm onlineForm = new OnlineForm();
            this.Hide();
            onlineForm.Show();
        }

        private void reverseImg_Click(object sender, EventArgs e)
        {
            desc = desc ? false : true;
            this.backPanel.Controls.Clear();
            singleGameCount = fillData();
        }

        private void reverseSort_Click(object sender, EventArgs e)
        {
            this.reverseImg_Click(sender, e);
        }

        private void timeSort_Click(object sender, EventArgs e)
        {
            if (this.sortType == 1)
            {
                return;
            }
            this.sortType = 1;
            this.desc = true;
            this.backPanel.Controls.Clear();
            singleGameCount = fillData();
        }

        private void popularitySort_Click(object sender, EventArgs e)
        {
            if (this.sortType == 2)
            {
                return;
            }
            this.sortType = 2;
            this.desc = true;
            this.backPanel.Controls.Clear();
            singleGameCount = fillData();
        }

        private void rateSort_Click(object sender, EventArgs e)
        {
            if (this.sortType == 3)
            {
                return;
            }
            this.sortType = 3;
            this.desc = true;
            this.backPanel.Controls.Clear();
            singleGameCount = fillData();
        }
    }
}
