using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameForum
{
    public class SingleGame
    {
        private string game_id;
        private string game_name;
        private string game_type;
        private string game_website;
        private string game_label;
        private float game_score;
        private int game_rater_num;
        private string game_img;
        private string game_platform;
        private string game_release_date;
        private string game_release;
        private string game_arrange_date;
        private string game_language;

        public SingleGame(string game_id, string game_name, string game_type, string game_website, string game_label, float game_score, int game_rater_num, string game_img, string game_platform, string game_release_date, string game_release, string game_arrange_date, string game_language)
        {
            this.game_id = game_id;
            this.game_name = game_name;
            this.game_type = game_type;
            this.game_website = game_website;
            this.game_label = game_label;
            this.game_score = game_score;
            this.game_rater_num = game_rater_num;
            this.game_img = game_img;
            this.game_platform = game_platform;
            this.game_release_date = game_release_date;
            this.game_release = game_release;
            this.game_arrange_date = game_arrange_date;
            this.game_language = game_language;
        }

        public string Game_id { get => game_id; set => game_id = value; }
        public string Game_name { get => game_name; set => game_name = value; }
        public string Game_type { get => game_type; set => game_type = value; }
        public string Game_website { get => game_website; set => game_website = value; }
        public string Game_label { get => game_label; set => game_label = value; }
        public float Game_score { get => game_score; set => game_score = value; }
        public int Game_rater_num { get => game_rater_num; set => game_rater_num = value; }
        public string Game_img { get => game_img; set => game_img = value; }
        public string Game_platform { get => game_platform; set => game_platform = value; }
        public string Game_release_date { get => game_release_date; set => game_release_date = value; }
        public string Game_release { get => game_release; set => game_release = value; }
        public string Game_arrange_date { get => game_arrange_date; set => game_arrange_date = value; }
        public string Game_language { get => game_language; set => game_language = value; }


        public override string ToString()
        {
            return "{game_id: " + Game_id + ", game_name: " + Game_name + ", game_type: " + Game_type + "}";
        }

    }
}
