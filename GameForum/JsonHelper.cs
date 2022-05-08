using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameForum
{
    /// <summary>
    /// json 读写工具类
    /// </summary>
    public class JsonHelper
    {

        /// <summary>
        /// 读取Json文件
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public static JObject readJson(string filePath)
        {
            try
            {
                StreamReader file = File.OpenText(filePath);
                JsonTextReader reader = new JsonTextReader(file);
                JObject message = (JObject)JToken.ReadFrom(reader);
                file.Close();
                return message;
            }
            catch
            {
                MessageBox.Show("读取json文件失败");
                return null;
            }
        }


        public static void writeJson(string filePath, string value)
        {
            try
            {
                dynamic jsonObj = JsonConvert.DeserializeObject(value);
                string output = JsonConvert.SerializeObject(jsonObj, Formatting.Indented);
                File.WriteAllText(filePath, output);
            }
            catch
            {
                MessageBox.Show("写json文件失败");
            }
        }


        /// <summary>
        /// json数组字符串，解析为字符串数组
        /// </summary>
        /// <param name="jsonStr"></param>
        /// <returns></returns>
        public static string[] jsonToArray(string jsonStr)
        {
            var arrData = JArray.Parse(jsonStr);
            string[] result = new string[arrData.Count];
            int index = 0;
            foreach (var value in arrData)
            {
                result[index++] = value.ToString();
            }
            return result;
        }
    }
}
