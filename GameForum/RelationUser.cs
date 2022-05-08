using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameForum
{
    public class RelationUser
    {
        private int user_id;
        private String user_name;
        private String user_avatar;

        public int User_Id { get => user_id; set => user_id = value; }
        public string User_name { get => user_name; set => user_name = value; }
        public string User_avatar { get => user_avatar; set => user_avatar = value; }

        public RelationUser(int user_id, string user_name, string user_avatar)
        {
            User_Id = user_id;
            User_name = user_name;
            User_avatar = user_avatar;
        }


        public override string ToString()
        {
            return "{user_id: " + User_Id +  ", user_name: " + User_name + ", user_avatar: " + User_avatar + "}";
        }
    }
}
