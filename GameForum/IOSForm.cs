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
    public partial class IOSForm : Form
    {
        private int iosGameCount;       // 苹果游戏数
        private int sortType = 1;           // 排序方式，1表示时间排序，2表示热度排序，3表示评分排序，默认1
        private bool desc = true;           // 排序顺序，true表示由高到低，false表示由低到高，默认true
        private string rootDir = "D:\\MySQL";

        public IOSForm()
        {
            InitializeComponent();

            iosGameCount = fillData();
        }

        /// <summary>
        /// 获取所有的苹果游戏
        /// </summary>
        /// <returns></returns>
        private List<IOSGame> getAllIOSGame()
        {
            // 发送get请求
            string url = "http://localhost:8080/gameforum/v1/game/getAllIOSGame?sortType=" + sortType + "&desc=" + desc.ToString();
            string value = HttpHelper.sendGetRequest(url);

            JObject message = JObject.Parse(value);
            string result = message["result"].ToString();
            if (message["result"].ToString() == "null")
            {
                return null;
            }
            else
            {
                var arrData = JArray.Parse(result);
                List<IOSGame> iosGameList = arrData.ToObject<List<IOSGame>>();
                return iosGameList;
            }
        }


        private int fillData()
        {
            List<IOSGame> iosGameList = getAllIOSGame();
            if (iosGameList == null)
            {
                return 0;
            }
            int index = 0;
            foreach(IOSGame iOSGame in iosGameList)
            {
                index++;
                // 每一项的panel
                Panel gameItemPanel = new Panel();
                gameItemPanel.SuspendLayout();
                gameItemPanel.BackColor = Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
                gameItemPanel.Location = new Point(5, 190 * (index - 1));
                gameItemPanel.Name = "gameItemPanel_" + iOSGame.Game_id;
                gameItemPanel.Size = new Size(959, 160);
                gameItemPanel.ResumeLayout(false);
                gameItemPanel.PerformLayout();
                this.backPanel.Controls.Add(gameItemPanel);

                // 游戏图像
                PictureBox gameImg = new PictureBox();
                ((System.ComponentModel.ISupportInitialize)(gameImg)).BeginInit();
                gameImg.Load(rootDir + iOSGame.Game_img);
                gameImg.Location = new Point(20, 25);
                gameImg.Name = "gameImg" + index;
                gameImg.Size = new Size(110, 110);
                gameImg.SizeMode = PictureBoxSizeMode.StretchImage;
                gameItemPanel.Controls.Add(gameImg);

                // 游戏名
                Label gameName = new Label();
                gameName.AutoSize = true;
                gameName.Font = new Font("Arial", 14F, System.Drawing.FontStyle.Bold);
                gameName.ForeColor = Color.Red;
                gameName.Location = new Point(150, 13);
                gameName.Name = "gameName" + index;
                gameName.Text = iOSGame.Game_name;
                gameItemPanel.Controls.Add(gameName);

                // 游戏口号
                Label gameSlogan = new Label();
                gameSlogan.AutoSize = true;
                gameSlogan.Font = new Font("Arial", 8F);
                gameSlogan.ForeColor = Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
                gameSlogan.Location = new Point(gameName.Location.X + gameName.Size.Width, 17);
                gameSlogan.Name = "gameSlogan" + index;
                gameSlogan.Text = iOSGame.Game_slogan;
                gameItemPanel.Controls.Add(gameSlogan);

                // 分割线
                Panel gamePanel = new Panel();
                gamePanel.BackColor = Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
                gamePanel.Location = new Point(150, 50);
                gamePanel.Size = new Size(674, 4);
                gameItemPanel.Controls.Add(gamePanel);

                // 厂商
                Label gameRelease = new Label();
                gameRelease.AutoSize = true;
                gameRelease.Font = new Font("Arial", 9F);
                gameRelease.Location = new Point(150, 69);
                gameRelease.Name = "gameRelease" + index;
                gameRelease.Text = "厂商：" + iOSGame.Game_release;
                gameItemPanel.Controls.Add(gameRelease);

                // 类型
                Label gameType = new Label();
                gameType.AutoSize = true;
                gameType.Font = new Font("Arial", 9F);
                gameType.Location = new Point(150, 99);
                gameType.Name = "gameType" + index;
                gameType.Text = "类型：" + iOSGame.Game_type;
                gameItemPanel.Controls.Add(gameType);

                // 大小
                // todo: 爬取游戏大小
                Label gameSize = new Label();
                gameSize.AutoSize = true;
                gameSize.Font = new Font("Arial", 9F);
                gameSize.Location = new Point(150, 129);
                gameSize.Name = "gameSize" + index;
                gameSize.Text = "大小：";
                gameItemPanel.Controls.Add(gameSize);

                // 版本
                Label gameVersion = new Label();
                gameVersion.AutoSize = true;
                gameVersion.Font = new Font("Arial", 9F);
                gameVersion.Location = new Point(365, 69);
                gameVersion.Name = "gameVersion" + index;
                gameVersion.Text = "版本：" + iOSGame.Game_version;
                gameItemPanel.Controls.Add(gameVersion);

                // 平台
                Label gamePlatform = new Label();
                gamePlatform.AutoSize = true;
                gamePlatform.Font = new Font("Arial", 9F);
                gamePlatform.Location = new Point(365, 99);
                gamePlatform.Name = "gamePlatform" + index;
                gamePlatform.Text = "平台：" + iOSGame.Game_platform;
                gameItemPanel.Controls.Add(gamePlatform);

                // 发布
                Label gameReleaseDate = new Label();
                gameReleaseDate.AutoSize = true;
                gameReleaseDate.Font = new Font("Arial", 9F);
                gameReleaseDate.Location = new Point(590, 69);
                gameReleaseDate.Name = "gameReleaseDate" + index;
                gameReleaseDate.Text = "发布：" + iOSGame.Game_release_date;
                gameItemPanel.Controls.Add(gameReleaseDate);

                // 语言
                Label gameLanguage = new Label();
                gameLanguage.AutoSize = true;
                gameLanguage.Font = new Font("Arial", 9F);
                gameLanguage.Location = new Point(590, 99);
                gameLanguage.Name = "gameLanguage" + index;
                gameLanguage.Text = "语言：" + iOSGame.Game_language;
                gameItemPanel.Controls.Add(gameLanguage);

                // 评分人数
                Label gameRaterNum = new Label();
                gameRaterNum.AutoSize = true;
                gameRaterNum.Font = new Font("微软雅黑", 10F);
                gameRaterNum.Location = new Point(849, 84);
                gameRaterNum.Name = "gameRaterNum" + index;
                gameRaterNum.Text = iOSGame.Game_rater_num + "人评分";
                gameItemPanel.Controls.Add(gameRaterNum);

                // 游戏专题
                Button gameDetail = new Button();
                gameDetail.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(155)))), ((int)(((byte)(213)))));
                gameDetail.ForeColor = Color.White;
                gameDetail.Location = new Point(830, 110);
                gameDetail.Name = "gameDetail_" + iOSGame.Game_id;
                gameDetail.Size = new Size(100, 30);
                gameDetail.Text = "游戏专题";
                gameDetail.UseVisualStyleBackColor = false;
                gameDetail.Click += new EventHandler(this.gameDetail_Click);
                gameItemPanel.Controls.Add(gameDetail);

                // 排名背景图像
                PictureBox sortedBack = new PictureBox();
                ((System.ComponentModel.ISupportInitialize)(sortedBack)).BeginInit();
                if (index == 1)
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
                gameScore.Text = String.Format("{0:F1}", iOSGame.Game_score);       // 固定一位小数
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

            IOSGameDetailForm iOSGameDetailForm = new IOSGameDetailForm(gameId);
            this.Close();
            iOSGameDetailForm.Show();
        }

        private void indexBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("功能开发中", "主页", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void singleBtn_Click(object sender, EventArgs e)
        {
            SingleForm singleForm = (SingleForm)MainWindow.MainForm;
            this.Close();
            singleForm.Show();
        }

        private void androidBtn_Click(object sender, EventArgs e)
        {
            AndroidForm androidForm = new AndroidForm();
            this.Close();
            androidForm.Show();
        }

        private void iosBtn_Click(object sender, EventArgs e)
        {
            iosGameCount = fillData();
        }

        private void onlineBtn_Click(object sender, EventArgs e)
        {
            OnlineForm onlineForm = new OnlineForm();
            this.Close();
            onlineForm.Show();
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
            iosGameCount = fillData();
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
            iosGameCount = fillData();
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
            iosGameCount = fillData();
        }

        private void reverseImg_Click(object sender, EventArgs e)
        {
            desc = desc ? false : true;
            this.backPanel.Controls.Clear();
            iosGameCount = fillData();
        }

        private void reverseSort_Click(object sender, EventArgs e)
        {
            this.reverseImg_Click(sender, e);
        }
    }
}
