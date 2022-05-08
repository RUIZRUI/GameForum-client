using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameForum
{
    public class AndroidGame
    {
        private string game_id = "";
        private string game_name = "";
        private string game_slogan = "";
        private string game_version = "";
        private string game_platform = "";
        private string game_type = "";
        private string game_release_date = "";
        private string game_release = "";
        private string game_language = "";
        private float game_score = 0;
        private int game_rater_num = 0;
        private string game_img = "";

        public string Game_id { get => game_id; set => game_id = value; }
        public string Game_name { get => game_name; set => game_name = value; }
        public string Game_slogan { get => game_slogan; set => game_slogan = value; }
        public string Game_version { get => game_version; set => game_version = value; }
        public string Game_platform { get => game_platform; set => game_platform = value; }
        public string Game_type { get => game_type; set => game_type = value; }
        public string Game_release_date { get => game_release_date; set => game_release_date = value; }
        public string Game_release { get => game_release; set => game_release = value; }
        public string Game_language { get => game_language; set => game_language = value; }
        public float Game_score { get => game_score; set => game_score = value; }
        public int Game_rater_num { get => game_rater_num; set => game_rater_num = value; }
        public string Game_img { get => game_img; set => game_img = value; }

        public AndroidGame(string game_id, string game_name, string game_slogan, string game_version, string game_platform, string game_type, string game_release_date, string game_release, string game_language, float game_score, int game_rater_num, string game_img)
        {
            Game_id = game_id;
            Game_name = game_name;
            Game_slogan = game_slogan;
            Game_version = game_version;
            Game_platform = game_platform;
            Game_type = game_type;
            Game_release_date = game_release_date;
            Game_release = game_release;
            Game_language = game_language;
            Game_score = game_score;
            Game_rater_num = game_rater_num;
            Game_img = game_img;
        }


        public override string ToString()
        {
            return "{game_id: " + Game_id + ", game_name: " + Game_name + ", game_slogan: " + Game_slogan + ", game_version: " + Game_version + 
                ", game_platform: " + Game_platform + ", game_type: " + Game_type + ", game_release_date: " + Game_release_date + ", game_release: " + 
                Game_release + ", game_language: " + Game_language + ", game_score: " + Game_score + ", game_rater_num: " + Game_rater_num + ", game_img: " + 
                Game_img + "}";
        }
    }
}
