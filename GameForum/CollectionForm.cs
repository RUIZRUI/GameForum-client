using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameForum
{
    public partial class CollectionForm : Form
    {
        private int collectionCount;    // 收藏数     

        public CollectionForm()
        {
            InitializeComponent();

            if(LoginInfo.CurrentUser.UserId != "")
            {
                // 注册用户
                collectionCount = fillData();
            }
        }

        // 初始化 backPanel
        private void initBackPanel()
        {
            // title
            this.backPanel.Controls.Add(this.title);

            // otherPanel1
            this.backPanel.Controls.Add(this.otherPanel1);

            // collectionDesc
            this.backPanel.Controls.Add(this.collectionDesc);

            // collectionNum
            this.backPanel.Controls.Add(this.collectionNum);

            // otherPanel2
            this.backPanel.Controls.Add(this.otherPanel2);

            // clear
            this.backPanel.Controls.Add(this.clear);

            // otherPanel3
            this.backPanel.Controls.Add(this.otherPanel3);
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
                // nothing
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
                CommentForm commentForm = new CommentForm();
                this.Close();
                commentForm.Show();
            }
        }


        /// <summary>
        /// 获取收藏集合
        /// </summary>
        private List<GameCollection> getCollection()
        {
            // 发送get请求
            string url = "http://localhost:8080/forum/GetCollection?userId=" + LoginInfo.CurrentUser.UserId;
            string value = HttpHelper.sendGetRequest(url);

            JObject message = JObject.Parse(value);
            if(message["result"].ToString() == "null")
            {
                // 后台产生异常
                return null;
            }
            else
            {
                // 空表也是解析为数组: resulot = []
                var arrData = JArray.Parse(message["result"].ToString());
                List<GameCollection> collectionList = arrData.ToObject<List<GameCollection>>();
                return collectionList;
            }
        }


        /// <summary>
        /// 填充数据
        /// </summary>
        private int fillData()
        {
            List<GameCollection> collectionList = getCollection();
            if (collectionList == null)
            {
                // 服务器产生异常
                this.collectionDesc.Text = "收藏夹描述：" + LoginInfo.CurrentUser.UserName + " 的收藏夹";
                DialogResult result = MessageBox.Show("服务器产生异常，请报告给管理员！", "我的收藏", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                if (result == DialogResult.OK)
                {
                    // todo: 插入错误日志
                }
                return 0;
            }
            int index = 0;
            foreach(GameCollection collection in collectionList)
            {
                index++;
                // collectionPic    游戏图像
                PictureBox collectionPic = new PictureBox();
                ((System.ComponentModel.ISupportInitialize)(collectionPic)).BeginInit();
                collectionPic.Load(collection.Game_img);        // 加载图像
                collectionPic.Name = "collectionPic" + index;
                collectionPic.SizeMode = PictureBoxSizeMode.StretchImage;
                if(collection.Game_belong != "单机游戏")
                {
                    if(collection.Game_belong == "网页游戏")
                    {
                        collectionPic.Location = new Point(38, 33 + 163 + 142 * (index - 1));
                        collectionPic.Size = new Size(100, 56);
                    }
                    else
                    {
                        collectionPic.Location = new Point(38, 11 + 163 + 142 * (index - 1));
                        collectionPic.Size = new Size(100, 100);
                    }
                }
                else
                {
                    collectionPic.Location = new Point(38, 163 + 142 * (index - 1));
                    collectionPic.Size = new Size(100, 122);
                }
                this.backPanel.Controls.Add(collectionPic);

                // panel 游戏分割线
                Panel panel = new Panel();
                panel.BorderStyle = BorderStyle.FixedSingle;
                panel.Location = new Point(38, 142*index + 153);
                panel.Margin = new Padding(3, 3, 3, 3);
                panel.Name = "panel" + index;
                panel.Size = new Size(700, 1);
                this.backPanel.Controls.Add(panel);

                // gameName 游戏名
                Label gameName = new Label();
                gameName.AutoSize = true;
                gameName.Font = new Font("宋体", 12F, FontStyle.Bold);
                gameName.Location = new Point(169, 176 + 142*(index-1));
                gameName.Name = "gameName" + index;
                gameName.Text = collection.Game_name;
                this.backPanel.Controls.Add(gameName);

                // 游戏集合
                Label gameCollection = new Label();
                gameCollection.AutoSize = true;
                gameCollection.Font = new Font("字体", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)134));
                gameCollection.Location = new Point(169, 205 + 142 * (index - 1));
                gameCollection.Name = "gameCollection" + index;
                gameCollection.Text = "游戏集合：" + collection.Game_belong;
                this.backPanel.Controls.Add(gameCollection);


                // 游戏类型
                Label gameType = new Label();
                gameType.AutoSize = true;
                gameType.Font = new Font("字体", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)134));
                gameType.Location = new Point(169, 233 + 142 * (index - 1));
                gameType.Name = "gameType" + index;
                gameType.Text = "游戏类型：" + collection.Game_type;
                this.backPanel.Controls.Add(gameType);

                // 游戏平台
                Label gamePlatform = new Label();
                gamePlatform.AutoSize = true;
                gamePlatform.Font = new Font("字体", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)134));
                gamePlatform.Location = new Point(169, 261 + 142 * (index - 1));
                gamePlatform.Name = "gamePlatform" + index;
                gamePlatform.Text = "游戏平台：" + collection.Game_platform;
                this.backPanel.Controls.Add(gamePlatform);


                // 取消收藏
                Label cancelCollection = new Label();
                cancelCollection.AutoSize = true;
                cancelCollection.Font = new Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                cancelCollection.Location = new Point(666, 176 + 142 * (index - 1));
                cancelCollection.Name = "cancelCollection_" + collection.Game_id;
                cancelCollection.Text = "取消收藏";
                cancelCollection.Click += new System.EventHandler(this.cancel_Click);
                this.backPanel.Controls.Add(cancelCollection);

            }
            this.collectionNum.Text = index + "条内容";
            this.collectionDesc.Text = "收藏夹描述：" + LoginInfo.CurrentUser.UserName + " 的收藏夹";
            return index;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            if(LoginInfo.CurrentUser.UserId == "")
            {
                DialogResult result =  MessageBox.Show("对不起，您当前是游客登录，请注册后使用", "清空收藏", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                if (result == DialogResult.OK)
                {
                    // todo: 转到登录页面
                }
            }
            else if(collectionCount == 0)
            {
                MessageBox.Show("对不起，您当前暂无收藏！", "清空收藏", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // 发送post请求，清空收藏夹
                string url = "http://localhost:8080/forum/ClearCollection";
                string postData = "userId=" + LoginInfo.CurrentUser.UserId;

                string value = HttpHelper.sendPostRequest(url, postData);
                JObject message = JObject.Parse(value);
                if(message["result"].ToString() == "success")
                {
                    // 成功后刷新
                    this.backPanel.Controls.Clear();
                    initBackPanel();
                    collectionCount = fillData();
                }
                else
                {
                    MessageBox.Show("清空收藏失败: " + message["result"].ToString(), "清空收藏", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void cancel_Click(Object sender, EventArgs e)
        {
            string labelName = ((Label)sender).Name;
            string gameId = labelName.Substring(17);

            // 发送post请求，取消收藏
            string url = "http://localhost:8080/forum/CancelCollection";
            string postData = "userId=" + LoginInfo.CurrentUser.UserId + "&gameId=" + gameId;

            string value = HttpHelper.sendPostRequest(url, postData);
            JObject message = JObject.Parse(value);
            string result = message["result"].ToString();
            if (result == "success")
            {
                // 取消收藏成功，刷新数据
                this.backPanel.Controls.Clear();
                initBackPanel();        // 重新添加顶部控件
                collectionCount = fillData();
            }
            else
            {
                MessageBox.Show("取消收藏失败: " + result, "取消收藏", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            /* string labelName = ((Label)sender).Name;
            string gameLabelName = labelName.Replace("cancelCollection", "gameName");

            // 通过字符串，查找控件
            Control control = this.backPanel.Controls.Find(gameLabelName, true)[0];
            if(control != null)
            {
                // 转换为 Label类对象
                Label gameNameLabel = control as Label;
                string gameName = gameNameLabel.Text
            }
            */
        }
    }
}
