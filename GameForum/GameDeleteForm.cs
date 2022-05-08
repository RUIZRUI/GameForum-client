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
    public partial class GameDeleteForm : Form
    {
        public GameDeleteForm()
        {
            InitializeComponent();

            // 头像由方框改为圆形
            this.avatar.Image = ImageHelper.CutEllipse(this.avatar.Image, new Rectangle(0, 0, this.avatar.Image.Width, this.avatar.Image.Height), new Size(this.avatar.Image.Width, this.avatar.Image.Height));
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
            if (index == 0)
            {
                GameManageForm gameManageForm = new GameManageForm();
                this.Close();
                gameManageForm.Show();
            }
            else if (index == 1)
            {
                // nothing
            }
            else if (index == 2)
            {
                GameEditForm gameEditForm = new GameEditForm();
                this.Close();
                gameEditForm.Show();
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            this.gameName.Text = "";
            this.singleRadioButton.Checked = false;
            this.phoneRadioButton.Checked = false;
            this.onlineRadioButton.Checked = false;
        }


        /// <summary>
        /// 游戏删除
        /// </summary>

        private void delete_Click(object sender, EventArgs e)
        {
            // check
            if (!checkGameInfo())
            {
                MessageBox.Show("输入信息有误，检查后请重新提交！", "删除游戏提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }

            // 发送post请求，删除游戏
            string url = "http://localhost:8080/forum/GameDelete";
            string postData = "userId=" + LoginInfo.CurrentUser.UserId + "&userName=" + LoginInfo.CurrentUser.UserName;
            postData += "&gameName=" + this.gameName.Text;
            if (singleRadioButton.Checked)
            {
                postData += "gameBelong=单机游戏";
            }
            else if (phoneRadioButton.Checked)
            {
                postData += "gameBelong=移动手游";
            }
            else if (onlineRadioButton.Checked)
            {
                postData += "gameBelong=网页游戏";
            }

            string value = HttpHelper.sendPostRequest(url, postData);
            JObject message = JObject.Parse(value);
            if (message["result"].ToString() == "success")
            {
                // 发布成功
                MessageBox.Show("游戏删除成功，感谢您为平台维护做出的贡献！", "删除游戏信息", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                // 调用reset点击事件
                this.reset_Click(null, null);
            }
            else
            {
                MessageBox.Show("error, " + message["result"].ToString(), "删除游戏错误", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }





        }


        /// <summary>
        /// 检查游戏格式
        /// </summary>
        private bool checkGameInfo()
        {
            return true;
        }
    }
}
