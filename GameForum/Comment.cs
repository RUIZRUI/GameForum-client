using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameForum
{
    public class Comment
    {
        private int comment_id;
        private int user_id_from;
        private int? parent_id;      // 空值判断
        private string content;
        private long comment_time;      // 13位时间戳
        private string img;
        private string user_name;
        private string priority;
        private List<Comment> child;

        public Comment()
        {
             
        }

        public Comment(int comment_id, int user_id_from, string content, long comment_time, string img, string user_name, string priority, List<Comment> child)
        {
            this.Comment_id = comment_id;
            this.User_id_from = user_id_from;
            this.Content = content;
            this.Comment_time = comment_time;
            this.Img = img;
            this.User_name = user_name;
            this.Priority = priority;
            this.Child = child;
        }

        public Comment(int comment_id, int user_id_from, int parent_id, string content, long comment_time, string img, string user_name, string priority, List<Comment> child)
        {
            this.Comment_id = comment_id;
            this.User_id_from = user_id_from;
            this.Parent_id = parent_id;
            this.Content = content;
            this.Comment_time = comment_time;
            this.Img = img;
            this.User_name = user_name;
            this.Priority = priority;
            this.Child = child;
        }



        public int Comment_id { get => comment_id; set => comment_id = value; }
        public int User_id_from { get => user_id_from; set => user_id_from = value; }
        public int? Parent_id { get => parent_id; set => parent_id = value; }
        public string Content { get => content; set => content = value; }
        public long Comment_time { get => comment_time; set => comment_time = value; }
        public string Img { get => img; set => img = value; }
        public string User_name { get => user_name; set => user_name = value; }
        public string Priority { get => priority; set => priority = value; }
        public List<Comment> Child { get => child; set => child = value; }

        public override string ToString()
        {
            return "{comment_id: " + Comment_id + ", user_id_from: " + User_id_from + ", parent_id: " + (Parent_id == null ? "null" : Parent_id + "") + ", content: " +
                content + ", comment_time: " + TimeHelper.GetTime(Comment_time, true).ToString("yyyy-MM-dd HH:mm") + ", img: " + Img + ", user_name: " + User_name +
                ", priority: " + Priority + ", child: " + (Child == null ? "null" : Child.ToString()) + "}";
        }

    }
}
