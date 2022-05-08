using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameForum
{
    /// <summary>
    /// 精简评论类，是评论类、用户类、游戏类三者的交互，用于“我的评论”页面
    /// </summary>
    class MyComment
    {
        private int comment_id;
        private String other_name;
        private String game_name;
        private String game_belong;
        private DateTime comment_time;

        public MyComment(int comment_id, string other_name, string game_name, string game_belong, DateTime comment_time)
        {
            this.Comment_id = comment_id;
            this.Other_name = other_name;
            this.Game_name = game_name;
            this.Game_belong = game_belong;
            this.Comment_time = comment_time;
        }

        public int Comment_id { get => comment_id; set => comment_id = value; }
        public string Other_name { get => other_name; set => other_name = value; }
        public string Game_name { get => game_name; set => game_name = value; }
        public string Game_belong { get => game_belong; set => game_belong = value; }
        public DateTime Comment_time { get => comment_time; set => comment_time = value; }
    }
}
