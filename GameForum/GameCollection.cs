using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameForum
{
    public class GameCollection
    {
        private string game_id = "";
        private string game_name = "";
        private string game_type = "";
        private string game_img = "";
        private string game_platform = "";
        private string game_belong = "";

        public GameCollection(string game_id, string game_name, string game_type, string game_img, string game_platform, string game_belong)
        {
            Game_id = game_id;
            Game_name = game_name;
            Game_type = game_type;
            Game_img = game_img;
            Game_platform = game_platform;
            Game_belong = game_belong;
        }

        public string Game_id { get => game_id; set => game_id = value; }
        public string Game_name { get => game_name; set => game_name = value; }
        public string Game_type { get => game_type; set => game_type = value; }
        public string Game_img { get => game_img; set => game_img = value; }
        public string Game_platform { get => game_platform; set => game_platform = value; }
        public string Game_belong { get => game_belong; set => game_belong = value; }



        // 重载 ToString()
        public override string ToString()
        {
            return "{game_id: " + Game_id + ", game_name: " + Game_name + ", game_type: " + Game_type + ", game_img: "  + Game_type + ", game_platform: " + Game_platform + ", game_belong: " + Game_belong + "}";
        }
    }
}
