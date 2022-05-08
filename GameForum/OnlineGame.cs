using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameForum
{
    public class OnlineGame
    {
        private string game_id = "";
        private string game_name = "";
        private string game_type = "";
        private string game_website = "";
        private string game_label = "";
        private float game_score = 0;
        private int game_rater_num = 0;
        private string game_img = "";
        private int game_hope_num = 0;
        private string game_frame = "";
        private string game_develop = "";
        private string game_operator = "";
        private string game_status = "";

        public OnlineGame(string game_id, string game_name, string game_type, string game_website, string game_label, float game_score, int game_rater_num, string game_img, int game_hope_num, string game_frame, string game_develop, string game_operator, string game_status)
        {
            this.game_id = game_id;
            this.game_name = game_name;
            this.game_type = game_type;
            this.game_website = game_website;
            this.game_label = game_label;
            this.game_score = game_score;
            this.game_rater_num = game_rater_num;
            this.game_img = game_img;
            this.game_hope_num = game_hope_num;
            this.game_frame = game_frame;
            this.game_develop = game_develop;
            this.game_operator = game_operator;
            this.game_status = game_status;
        }

        public string Game_id { get => game_id; set => game_id = value; }
        public string Game_name { get => game_name; set => game_name = value; }
        public string Game_type { get => game_type; set => game_type = value; }
        public string Game_website { get => game_website; set => game_website = value; }
        public string Game_label { get => game_label; set => game_label = value; }
        public float Game_score { get => game_score; set => game_score = value; }
        public int Game_rater_num { get => game_rater_num; set => game_rater_num = value; }
        public string Game_img { get => game_img; set => game_img = value; }
        public int Game_hope_num { get => game_hope_num; set => game_hope_num = value; }
        public string Game_frame { get => game_frame; set => game_frame = value; }
        public string Game_develop { get => game_develop; set => game_develop = value; }
        public string Game_operator { get => game_operator; set => game_operator = value; }
        public string Game_status { get => game_status; set => game_status = value; }


        public override string ToString()
        {
            return "{game_id: " + Game_id + ", game_name: " + Game_name + ", game_type: " + Game_type + ", game_website: " + Game_website + 
                ", game_label: " + Game_label + ", game_score: " + Game_score + ", game_rater_num: " + Game_rater_num + ", game_img: " + Game_img + 
                ", game_hope_num: " + Game_hope_num + ", game_frame: " + Game_frame + ", game_develop: " + Game_develop + ", game_operator: " + Game_operator + 
                ", game_status: " + Game_status + "}";
        }
    }
}
