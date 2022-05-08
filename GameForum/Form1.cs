using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace GameForum
{
    public partial class IndexForm : Form
    {
        public IndexForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();

            // 隐藏主页
            this.Hide();

            // 注册窗口位置与主页一致
            // registerForm.Left = this.Left;
            // registerForm.Top = this.Top;

            // 显示注册窗口
            registerForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();

            this.Hide();

            loginForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PersonalCenterForm personalCenterForm = new PersonalCenterForm();

            this.Hide();
            personalCenterForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CollectionForm collectionForm = new CollectionForm();
            this.Hide();
            collectionForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FollowsForm followsForm = new FollowsForm();
            this.Hide();
            followsForm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FansForm fansForm = new FansForm();
            this.Hide();
            fansForm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            CommentForm commentForm = new CommentForm();
            this.Hide();
            commentForm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            GameManageForm gameManageForm = new GameManageForm();
            this.Hide();
            gameManageForm.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            GameDeleteForm gameDeleteForm = new GameDeleteForm();
            this.Hide();
            gameDeleteForm.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            GameEditForm gameEditForm = new GameEditForm();
            this.Hide();
            gameEditForm.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            SystemManagerForm systemManagerForm = new SystemManagerForm();
            this.Hide();
            systemManagerForm.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            UserManageForm userManageForm = new UserManageForm();
            this.Hide();
            userManageForm.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            AccountSetForm accountSetForm = new AccountSetForm();
            this.Hide();
            accountSetForm.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            SingleIndexForm singleIndexForm = new SingleIndexForm();
            this.Hide();
            singleIndexForm.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            AndroidIndexForm androidIndexForm = new AndroidIndexForm();
            this.Hide();
            androidIndexForm.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            IOSIndexForm iOSIndexForm = new IOSIndexForm();
            this.Hide();
            iOSIndexForm.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            OnlineIndexForm onlineIndexForm = new OnlineIndexForm();
            this.Hide();
            onlineIndexForm.Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            SingleForm singleForm = new SingleForm();
            this.Hide();
            singleForm.Show();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            AndroidForm androidForm = new AndroidForm();
            this.Hide();
            androidForm.Show();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            IOSForm iOSForm = new IOSForm();
            this.Hide();
            iOSForm.Show();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            OnlineForm onlineForm = new OnlineForm();
            this.Hide();
            onlineForm.Show();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            SingleGameDetailForm singleGameDetailForm = new SingleGameDetailForm();
            this.Hide();
            singleGameDetailForm.Show();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            AndroidGameDetailForm androidGameDetailForm = new AndroidGameDetailForm();
            this.Hide();
            androidGameDetailForm.Show();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            IOSGameDetailForm iOSGameDetailForm = new IOSGameDetailForm();
            this.Hide();
            iOSGameDetailForm.Show();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            OnlineGameDetailForm onlineGameDetailForm = new OnlineGameDetailForm();
            this.Hide();
            onlineGameDetailForm.Show();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            string url = "http://localhost:8080/forum/TestServlet?";
            url += "userName=qixqi";
            url += "&userPass=1214";

            // System.IO.Stream stream = response.GetResponseStream();
            // XmlTextReader reader = new XmlTextReader(stream);
            // reader.MoveToContent();
            // string value = reader.ReadInnerXml();
            // value = value.Replace("&lt;", "<");
            // value = value.Replace("&gt;", ">");
            string value = HttpHelper.sendGetRequest(url);

            // 解析简单json字符串
            JObject json = JObject.Parse(value);
            string userName = json["userName"].ToString();
            string userPass = json["userPass"].ToString();


            MessageBox.Show("读取到json串: userName = " + userName + "; userPass = " + userPass);
            // reader.Close();  
        }


        /// <summary>
        /// 获取http响应内容
        /// </summary>
        /// <param name="response"></param>
        /// <returns></returns>
        private string getResponseBody(HttpWebResponse response)
        {
            Encoding defaultEncoding = Encoding.UTF8;
            string contentType = response.ContentType;
            if (contentType != null)
            {
                if (contentType.ToLower().Contains("gb2312"))
                {
                    defaultEncoding = Encoding.GetEncoding("gb2312");
                }
                else if (contentType.ToLower().Contains("gbk"))
                {
                    defaultEncoding = Encoding.GetEncoding("gbk");
                }
                else if (contentType.ToLower().Contains("zh-cn"))
                {
                    defaultEncoding = Encoding.GetEncoding("zh-cn");
                }
            }

            string responseBody = string.Empty;
            if (response.ContentEncoding.ToLower().Contains("gzip"))
            {
                using (GZipStream stream = new GZipStream(response.GetResponseStream(), CompressionMode.Decompress))
                {
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        responseBody = reader.ReadToEnd();
                    }
                }
            }
            else if (response.ContentEncoding.ToLower().Contains("deflate"))
            {
                using (DeflateStream stream = new DeflateStream(response.GetResponseStream(), CompressionMode.Decompress))
                {
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        responseBody = reader.ReadToEnd();
                    }
                }
            }
            else
            {
                using (Stream stream = response.GetResponseStream())
                {
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        responseBody = reader.ReadToEnd();
                    }
                }
            }
            return responseBody;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            string url = "http://localhost:8080/forum/TestServlet";
            string postData = "userName=" + "qixqi" + "&userPass=" + "1214";
            string value = HttpHelper.sendPostRequest(url, postData);

            // 解析简单json字符串
            JObject json = JObject.Parse(value);
            string userName = json["userName"].ToString();
            string userPass = json["userPass"].ToString();


            MessageBox.Show("读取到json串: userName = " + userName + "; userPass = " + userPass);

        }
    }
}
