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
    public partial class OnlineForm : Form
    {
        private int onlineGameCount;       // 网页游戏数
        private int sortType = 1;           // 排序方式，1表示期望值排序，2表示热度排序，3表示评分排序，默认1
        private bool desc = true;           // 排序顺序，true表示由高到低，false表示由低到高，默认true

        public OnlineForm()
        {
            InitializeComponent();

            onlineGameCount = fillData();
        }


        /// <summary>
        /// 获取所有的网页游戏
        /// </summary>
        /// <returns></returns>
        private List<OnlineGame> getAllOnlineGame()
        {
            // 发送get请求
            string url = "http://localhost:8080/forum/GetAllOnlineGame?sortType=" + sortType + "&desc=" + desc.ToString();
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
                List<OnlineGame> onlineGameList = arrData.ToObject<List<OnlineGame>>();
                return onlineGameList;
            }
        }


        /// <summary>
        /// 填充数据
        /// </summary>
        /// <returns></returns>
        private int fillData()
        {
            List<OnlineGame> onlineGameList = getAllOnlineGame();
            if (onlineGameList == null)
            {
                return 0;
            }
            int index = 0;
            foreach(OnlineGame onlineGame in onlineGameList)
            {
                index++;
                // 每一项的panel
                Panel gameItemPanel = new Panel();
                gameItemPanel.SuspendLayout();
                gameItemPanel.BackColor = Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
                gameItemPanel.Location = new Point(5, 190 * (index - 1));
                gameItemPanel.Name = "gameItemPanel_" + onlineGame.Game_id;
                gameItemPanel.Size = new Size(959, 160);
                gameItemPanel.ResumeLayout(false);
                gameItemPanel.PerformLayout();
                this.backPanel.Controls.Add(gameItemPanel);

                // 游戏图像
                PictureBox gameImg = new PictureBox();
                ((System.ComponentModel.ISupportInitialize)(gameImg)).BeginInit();
                gameImg.Load(onlineGame.Game_img);
                gameImg.Location = new Point(20, 35);
                gameImg.Name = "gameImg" + index;
                gameImg.Size = new Size(150, 90);
                gameImg.SizeMode = PictureBoxSizeMode.StretchImage;
                gameItemPanel.Controls.Add(gameImg);

                // 游戏名
                Label gameName = new Label();
                gameName.AutoSize = true;
                gameName.Font = new Font("Arial", 14F, System.Drawing.FontStyle.Bold);
                gameName.ForeColor = Color.Red;
                gameName.Location = new Point(190, 13);
                gameName.Name = "gameName" + index;
                gameName.Text = onlineGame.Game_name;
                gameItemPanel.Controls.Add(gameName);

                // 分割线
                Panel gamePanel = new Panel();
                gamePanel.BackColor = Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
                gamePanel.Location = new Point(190, 50);
                gamePanel.Size = new Size(634, 4);
                gameItemPanel.Controls.Add(gamePanel);

                // 开发商
                Label gameDevelop = new Label();
                gameDevelop.AutoSize = true;
                gameDevelop.Font = new Font("Arial", 9F);
                gameDevelop.Location = new Point(190, 69);
                gameDevelop.Name = "gameDevelop" + index;
                gameDevelop.Text = "开发商：" + onlineGame.Game_develop;
                gameItemPanel.Controls.Add(gameDevelop);

                // 运营商
                Label gameOperator = new Label();
                gameOperator.AutoSize = true;
                gameOperator.Font = new Font("Arial", 9F);
                gameOperator.Location = new Point(190, 99);
                gameOperator.Name = "gameOperator" + index;
                gameOperator.Text = "运营商：" + onlineGame.Game_operator;
                gameItemPanel.Controls.Add(gameOperator);

                // 标签
                Label gameLabel = new Label();
                gameLabel.AutoSize = true;
                gameLabel.Font = new Font("Arial", 9F);
                gameLabel.Location = new Point(190, 129);
                gameLabel.Name = "gameLabel" + index;
                gameLabel.Text = "标签：" + String.Join("  ", JsonHelper.jsonToArray(onlineGame.Game_label));
                gameItemPanel.Controls.Add(gameLabel);

                // 类型
                Label gameType = new Label();
                gameType.AutoSize = true;
                gameType.Font = new Font("Arial", 9F);
                gameType.Location = new Point(400, 69);
                gameType.Name = "gameType" + index;
                gameType.Text = "类型：" + onlineGame.Game_type;
                gameItemPanel.Controls.Add(gameType);

                // 状态
                Label gameStatus = new Label();
                gameStatus.AutoSize = true;
                gameStatus.Font = new Font("Arial", 9F);
                gameStatus.Location = new Point(400, 99);
                gameStatus.Name = "gameStatus" + index;
                gameStatus.Text = "状态：" + onlineGame.Game_status;
                gameItemPanel.Controls.Add(gameStatus);

                // 画面
                Label gameFrame = new Label();
                gameFrame.AutoSize = true;
                gameFrame.Font = new Font("Arial", 9F);
                gameFrame.Location = new Point(400, 129);
                gameFrame.Name = "gameFrame" + index;
                gameFrame.Text = "画面：" + onlineGame.Game_frame;
                gameItemPanel.Controls.Add(gameFrame);

                // 人气
                Label gameHopeNum = new Label();
                gameHopeNum.AutoSize = true;
                gameHopeNum.Font = new Font("Arial", 9F);
                gameHopeNum.Location = new Point(590, 69);
                gameHopeNum.Name = "gameHopeNum" + index;
                gameHopeNum.Text = "人气：" + onlineGame.Game_hope_num;
                gameItemPanel.Controls.Add(gameHopeNum);

                // 公测时间
                // todo: 爬取公测时间
                Label gameTestTime = new Label();
                gameTestTime.AutoSize = true;
                gameTestTime.Font = new Font("Arial", 9F);
                gameTestTime.Location = new Point(590, 99);
                gameTestTime.Name = "gameTestTime" + index;
                gameTestTime.Text = "公测时间：";
                gameItemPanel.Controls.Add(gameTestTime);

                // 官网
                // todo: 点击跳转到官网页面
                Label gameWebsite = new Label();
                gameWebsite.AutoSize = true;
                gameWebsite.Font = new Font("Arial", 9F);
                gameWebsite.Location = new Point(590, 129);
                gameWebsite.Name = "gameWebsite" + index;
                gameWebsite.Text = "官网：点击查看";
                gameItemPanel.Controls.Add(gameWebsite);

                // 评分人数
                Label gameRaterNum = new Label();
                gameRaterNum.AutoSize = true;
                gameRaterNum.Font = new Font("微软雅黑", 10F);
                gameRaterNum.Location = new Point(849, 84);
                gameRaterNum.Name = "gameRaterNum" + index;
                gameRaterNum.Text = onlineGame.Game_rater_num + "人评分";
                gameItemPanel.Controls.Add(gameRaterNum);

                // 游戏专题
                Button gameDetail = new Button();
                gameDetail.BackColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(155)))), ((int)(((byte)(213)))));
                gameDetail.ForeColor = Color.White;
                gameDetail.Location = new Point(830, 110);
                gameDetail.Name = "gameDetail_" + onlineGame.Game_id;
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
                // todo: 将评分固定为一位小数
                Label gameScore = new Label();
                gameScore.AutoSize = true;
                gameScore.Font = new Font("微软雅黑", 40F);
                gameScore.Location = new Point(835, 15);
                gameScore.Name = "gameScore" + index;
                gameScore.Text = String.Format("{0:F1}", onlineGame.Game_score);       // 固定一位小数
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

            OnlineGameDetailForm onlineGameDetailForm = new OnlineGameDetailForm(gameId);
            this.Close();
            onlineGameDetailForm.Show();
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
            IOSForm iOSForm = new IOSForm();
            this.Close();
            iOSForm.Show();
        }

        private void onlineBtn_Click(object sender, EventArgs e)
        {
            onlineGameCount = fillData();
        }

        private void hopeNumSort_Click(object sender, EventArgs e)
        {
            if (this.sortType == 1)
            {
                return;
            }
            this.sortType = 1;
            this.desc = true;
            this.backPanel.Controls.Clear();
            onlineGameCount = fillData();
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
            onlineGameCount = fillData();
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
            onlineGameCount = fillData();
        }

        private void reverseImg_Click(object sender, EventArgs e)
        {
            desc = desc ? false : true;
            this.backPanel.Controls.Clear();
            onlineGameCount = fillData();
        }

        private void reverseSort_Click(object sender, EventArgs e)
        {
            this.reverseImg_Click(sender, e);
        }
    }
}
