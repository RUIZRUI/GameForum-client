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
    public partial class SystemManagerForm : Form
    {
        public SystemManagerForm()
        {
            InitializeComponent();

            if(LoginInfo.CurrentUser.UserId == "")
            {
                MessageBox.Show("对不起，您不是系统管理员", "系统管理", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
            else
            {
                getSystemInfo();
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
                // nothing
            }
            else if(index == 1)
            {
                UserManageForm userManageForm = new UserManageForm();
                this.Close();
                userManageForm.Show();
            }
        }



        /// <summary>
        /// 系统管理员获取系统信息
        /// </summary>
        private void getSystemInfo()
        {
            // 发送get请求
            string url = "http://localhost:8080/forum/GetSystemInfo?userId=" + LoginInfo.CurrentUser.UserId + "&userName=" + LoginInfo.CurrentUser.UserName;
            string value = HttpHelper.sendGetRequest(url);

            JObject message = JObject.Parse(value);

            if(message["result"].ToString() == "error")
            {
                MessageBox.Show("error, " + message["result"].ToString(), "系统管理", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
            if(message["result"].ToString() == "insufficientPermission")
            {
                MessageBox.Show("对不齐，您的权限不够", "系统管理", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                return;
            }

            // 控件填充数据
            this.registerNum.Text = "注册人数：" + message["registerNum"].ToString();
            this.dailyActNum.Text = "日活量：" + message["dailyActNum"].ToString();
            this.dailyVisitNum.Text = "日访问量：" + message["dailyVisitNum"].ToString();
            this.gameNum.Text = "游戏总数：" + message["gameNum"].ToString();
            this.singleGameNum.Text = "单机游戏数：" + message["singleGameNum"].ToString();
            this.androidGameNum.Text = "安卓游戏数：" + message["androidGameNum"].ToString();
            this.iosGameNum.Text = "苹果游戏数：" + message["iosGameNum"].ToString();
            this.onlineGameNum.Text = "网页游戏数：" + message["onlineGameNum"].ToString();
        }

        private void singleBtn_Click(object sender, EventArgs e)
        {
            SingleForm singleForm = (SingleForm)MainWindow.MainForm;
            this.Close();
            singleForm.Show();
        }
    }
}
