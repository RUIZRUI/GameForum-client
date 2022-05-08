using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameForum
{
    public partial class AndroidIndexForm : Form
    {
        public AndroidIndexForm()
        {
            InitializeComponent();

            changeSortedNum();
        }


        /// <summary>
        /// 更改sortedNum标签的属性，使其透明显示
        /// </summary>
        private void changeSortedNum()
        {
            this.sortedNum1.Location = new System.Drawing.Point(0, 5);
            this.sortedNum1.Text = "  1";
            this.sortedNum1.Parent = this.sortedBack1;
            this.sortedNum1.Font = new System.Drawing.Font("Arial", 18);

            this.sortedNum2.Location = new System.Drawing.Point(0, 5);
            this.sortedNum2.Text = "  2";
            this.sortedNum2.Parent = this.sortedBack2;
            this.sortedNum2.Font = new System.Drawing.Font("Arial", 18);
        }
    }
}
