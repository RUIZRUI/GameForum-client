using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.IO.Compression;
using System.Collections;
using System.Reflection.Emit;
using System.Security.Cryptography;

namespace GameForum
{
    /// <summary>
    /// 网络请求工具类
    /// </summary>
    public class HttpHelper
    {

        /// <summary>
        /// 将Http响应转为字符串
        /// </summary>
        /// <param name="response"></param>
        /// <returns></returns>
        public static string getResponseBody(HttpWebResponse response)
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


        /// <summary>
        /// 发送post请求
        /// </summary>
        /// <param name="url">url地址</param>
        /// <param name="postData">post提交数据</param>
        /// <returns>响应字符串</returns>
        public static string sendPostRequest(string url, string postData)
        {
            byte[] byteArray = Encoding.UTF8.GetBytes(postData);
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(new Uri(url));
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = byteArray.Length;
            Stream stream = request.GetRequestStream();
            stream.Write(byteArray, 0, byteArray.Length);
            stream.Close();

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            return getResponseBody(response);
        }


        /// <summary>
        /// 发送get请求
        /// </summary>
        /// <param name="url">url地址</param>
        /// <returns></returns>
        public static string sendGetRequest(string url)
        {
            // 创建http请求
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

            // 获取http响应
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            return getResponseBody(response);
        }



        /// <summary>
        /// 使用WebClient上传文件和表单元素
        /// </summary>
        /// <param name="url">后台接口</param>
        /// <param name="method">Http method</param>
        /// <param name="fieldName">文件域表单名
        /// <param name="filePath">本地文件地址</param>
        /// <param name="forms">表单元素组成字典</param>
        /// <param name="response">输出响应字符串</param>
        /// <returns></returns>
        public static bool uploadFileWithForm(string url, string method, string fieldName, string filePath, Dictionary<string, string> forms, out string response)
        {
            // 边界字符串
            // 前面的横线个数很关键，不然解析不到
            string Boundary = "--------------------------" + DateTime.Now.Ticks.ToString("x");

            // 生成上传的二进制数组
            ArrayList bytesList = new ArrayList();
            // 普通表单元素
            foreach (KeyValuePair<string, string> item in forms)
            {
                bytesList.Add(getFormData(item.Key, item.Value, "--" + Boundary));      // 前面的横线个数很关键，不然解析不到
            }
            // 文件
            bytesList.Add(getFileData(fieldName, filePath, "--" + Boundary));           // 前面的横线个数很关键，不然解析不到

            // 合成所有元素，生成二进制数组
            byte[] bytes = joinBytes(bytesList, "--" + Boundary);                       // 前面的横线个数很关键，不然解析不到

            // 上传到服务器
            WebClient webClient = new WebClient();
            webClient.Headers.Add("Content-Type", "multipart/form-data; boundary=" + Boundary);

            try
            {
                byte[] responseBytes = webClient.UploadData(url, method, bytes);
                response = Encoding.UTF8.GetString(responseBytes);
                return true;
            }
            catch (WebException wex)
            {
                response = wex.Message;
            }
            return false;
        }

        /// <summary>
        /// 拼接二进制数组
        /// </summary>
        /// <param name="byteArrays"></param>
        /// <param name="Boundary">时间戳生成的边界字符串</param>
        /// <returns>返回二进制数组</returns>
        /// <remarks>添加结束边界</remarks>
        private static byte[] joinBytes(ArrayList byteArrays, string Boundary)
        {
            int length = 0;
            int readLength = 0;

            // 添加结束边界
            string endBoundary = Boundary + "--\r\n";
            byte[] endBoundaryBytes = Encoding.UTF8.GetBytes(endBoundary);
            byteArrays.Add(endBoundaryBytes);

            foreach(byte[] b in byteArrays)
            {
                length += b.Length;
            }

            byte[] bytes = new byte[length];

            // 遍历复制
            foreach (byte[] b in byteArrays)
            {
                b.CopyTo(bytes, readLength);
                readLength += b.Length;
            }

            return bytes;
        }

        /// <summary>
        /// 获取表单元素二进制数组
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <param name="Boundary">时间戳组成的结束字符串</param>
        /// <returns></returns>
        /// <remarks> -----------------------------7d52ee27210a3c\r\nContent-Disposition: form-data; name=\"表单名\"\r\n\r\n表单值\r\n</remarks>
        private static byte[] getFormData(string name, string value, string Boundary)
        {
            string textTemplate = Boundary + "\r\nContent-Disposition: form-data; name=\"{0}\"\r\n\r\n{1}\r\n";
            string text = String.Format(textTemplate, name, value);
            byte[] bytes = Encoding.UTF8.GetBytes(text);
            return bytes;
        }

        /// <summary>
        /// 获取文件二进制数组
        /// </summary>
        /// <param name="name">表单名</param>
        /// <param name="filePath">文件地址</param>
        /// <param name="Boundary">时间戳生成的字符串</param>
        /// <returns></returns>
        /// <remarks>-----------------------------7d429871607fe
        ///         Content-Disposition: form-data; name="file1"; filename="G:\homepage.txt"
        ///         Content-Type: text/plain
        ///         宝玉：http://www.webuc.net
        /// </remarks>
        private static byte[] getFileData(string name, string filePath, string Boundary)
        {
            string contentType = "application/octet-stream";

            string endData = "\r\n";
            string textTemplate = Boundary + "\r\nContent-Disposition: form-data; name=\"{0}\"; filename=\"{1}\"\r\nContent-Type: {2}\r\n\r\n";

            // 头数据
            string headData = String.Format(textTemplate, name, filePath, contentType);
            byte[] headBytes = Encoding.UTF8.GetBytes(headData);

            // 文件二进制数据
            // 读文件流
            FileStream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read);
            byte[] fileBytes = new byte[stream.Length];
            stream.Read(fileBytes, 0, Convert.ToInt32(stream.Length));

            // 尾数据
            byte[] endBytes = Encoding.UTF8.GetBytes(endData);

            // 合成数据
            byte[] bytes = new byte[headBytes.Length + fileBytes.Length + endBytes.Length];
            headBytes.CopyTo(bytes, 0);     // 头数据
            fileBytes.CopyTo(bytes, headBytes.Length);  // 文件二进制数据
            endBytes.CopyTo(bytes, headBytes.Length + fileBytes.Length);    // 尾数据

            return bytes;
        }


        /// <summary>
        /// C# 实现 URLEncod
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string URLEncode(string str)
        {
            StringBuilder stringBuilder = new StringBuilder();
            byte[] strBytes = Encoding.UTF8.GetBytes(str);
            for (int i=0; i<strBytes.Length; i++)
            {
                stringBuilder.Append(@"%" + Convert.ToString(strBytes[i], 16));
            }
            return stringBuilder.ToString();
        }







    }
}
