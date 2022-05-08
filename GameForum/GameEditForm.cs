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
    public partial class GameEditForm : Form
    {
        public GameEditForm()
        {
            InitializeComponent();

            // 头像由方框改为圆形
            this.avatar.Image = ImageHelper.CutEllipse(this.avatar.Image, new Rectangle(0, 0, this.avatar.Image.Width, this.avatar.Image.Height), new Size(this.avatar.Image.Width, this.avatar.Image.Height));
        }

        // 自绘Item
        private void personalList_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(e.BackColor), e.Bounds);
            if (e.Index >= 0)
            {
                StringFormat stringFormat = new StringFormat();
                stringFormat.LineAlignment = StringAlignment.Center;
                e.Graphics.DrawString(((ListBox)sender).Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds, stringFormat);
            }
            e.DrawFocusRectangle();
        }

        private void personalList_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = 40;
        }

        private void manageList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = this.manageList.SelectedIndex;
            if (index == 0)
            {
                GameManageForm gameManageForm = new GameManageForm();
                this.Close();
                gameManageForm.Show();
            }
            else if (index == 1)
            {
                GameDeleteForm gameDeleteForm = new GameDeleteForm();
                this.Close();
                gameDeleteForm.Show();
            }
            else if (index == 2)
            {
                // nothing
            }
        }
    }
}
