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
    public partial class GameManageForm : Form
    {
        public GameManageForm()
        {
            InitializeComponent();

            formInit();
        }

        private void formInit()
        {
            // 头像由方框改为圆形
            this.avatar.Image = ImageHelper.SimpleCutEllipse(this.avatar.Image);
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


        // 重置
        private void reset_Click(object sender, EventArgs e)
        {
            this.gameName.Text = "";
            this.singleRadioButton.Checked = false;
            this.phoneRadioButton.Checked = false;
            this.onlineRadioButton.Checked = false;
            this.gameType.Text = "";
            this.gameRelease.Text = "";
            this.gameReleaseDate.Text = "";
            this.gameCleanDate.Text = "";
            this.gamePlatform.Text = "";
            this.gameWebsite.Text = "";
            this.gameLabel.Text = "";
            this.gameLanguage.Text = "";
            this.gameScore.Text = "";
            this.gameRaterNum.Text = "";
            this.gameImg.Text = "";
        }

        private void publish_Click(object sender, EventArgs e)
        {
            // check
            if (!checkGameInfo())
            {
                MessageBox.Show("输入不合法，检查后请重新发布！", "发布游戏提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                return;
            }

            // 发送Post请求，发布游戏
            string url = "http://localhost:8080/forum/GamePublish";
            string postData = "userId=" + LoginInfo.CurrentUser.UserId + "&userName=" + LoginInfo.CurrentUser.UserName;
            postData += "&gameName=" + this.gameName.Text;
            if (singleRadioButton.Checked)
            {
                postData += "&gameBelong=单机游戏";
            }
            else if (phoneRadioButton.Checked)
            {
                postData += "&gameBelong=移动手游";
            }
            else if (onlineRadioButton.Checked)
            {
                postData += "&gameBelong=网页游戏";
            }
            postData += "&gameType=" + this.gameType.Text;
            postData += "&gameRelease=" + this.gameRelease.Text;
            postData += "&gameReleaseDate=" + this.gameReleaseDate.Text;
            postData += "&gameArrangeTime=" + this.gameCleanDate.Text;
            postData += "&gamePlatform=" + this.gamePlatform.Text;
            postData += "&gameWebsite=" + this.gameWebsite.Text;
            postData += "&gameLabel=" + this.gameLabel.Text;
            postData += "&gameLanguage=" + this.gameLanguage.Text;
            postData += "&gameScore=" + this.gameScore.Text;
            postData += "&gameRaterNum=" + this.gameRaterNum.Text;
            postData += "&gameImg=" + this.gameImg.Text;

            string value = HttpHelper.sendPostRequest(url, postData);
            JObject message = JObject.Parse(value);
            if(message["result"].ToString() == "success")
            {
                // 发布成功
                MessageBox.Show("游戏发布成功，感谢您为平台做出的贡献！", "发布游戏信息", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                // 调用reset点击事件
                this.reset_Click(null, null);
            }
            else
            {
                MessageBox.Show("error, " + message["result"].ToString(), "发布游戏错误", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private bool checkGameInfo()
        {
            // todo: 检车输入是否合法
            return true;
        }

        private void manageList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = this.manageList.SelectedIndex;
            if(index == 0)
            {
                // nothing
            }
            else if(index == 1)
            {
                GameDeleteForm gameDeleteForm = new GameDeleteForm();
                this.Close();
                gameDeleteForm.Show();
            }
            else if(index == 2)
            {
                GameEditForm gameEditForm = new GameEditForm();
                this.Close();
                gameEditForm.Show();
            }
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
            OnlineForm onlineForm = new OnlineForm();
            this.Close();
            onlineForm.Show();
        }

        private void publishBtn_Click(object sender, EventArgs e)
        {
            // nothing
        }

        private void collectionPic_Click(object sender, EventArgs e)
        {
            // 收藏夹
            MessageBox.Show("功能扩展中", "收藏", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void commentPic_Click(object sender, EventArgs e)
        {
            // 消息
            MessageBox.Show("功能扩展中", "消息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
