namespace GameForum
{
    partial class FansForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.backPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.personalList = new System.Windows.Forms.ListBox();
            this.fanNum = new System.Windows.Forms.Label();
            this.backPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // backPanel
            // 
            this.backPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.backPanel.Controls.Add(this.fanNum);
            this.backPanel.Controls.Add(this.panel1);
            this.backPanel.Controls.Add(this.title);
            this.backPanel.Location = new System.Drawing.Point(282, 80);
            this.backPanel.Name = "backPanel";
            this.backPanel.Size = new System.Drawing.Size(770, 500);
            this.backPanel.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(38, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 1);
            this.panel1.TabIndex = 2;
            // 
            // title
            // 
            this.title.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.title.Location = new System.Drawing.Point(38, 27);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(115, 24);
            this.title.TabIndex = 1;
            this.title.Text = "关注我的人";
            // 
            // personalList
            // 
            this.personalList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.personalList.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.personalList.FormattingEnabled = true;
            this.personalList.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.personalList.IntegralHeight = false;
            this.personalList.ItemHeight = 40;
            this.personalList.Items.AddRange(new object[] {
            "个人资料",
            "我的收藏",
            "我的关注",
            "我的粉丝",
            "我的评论"});
            this.personalList.Location = new System.Drawing.Point(132, 80);
            this.personalList.Name = "personalList";
            this.personalList.Size = new System.Drawing.Size(150, 205);
            this.personalList.TabIndex = 3;
            this.personalList.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.personalList_DrawItem);
            this.personalList.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.personalList_MeasureItem);
            this.personalList.SelectedIndexChanged += new System.EventHandler(this.personalList_SelectedIndexChanged);
            // 
            // fanNum
            // 
            this.fanNum.AutoSize = true;
            this.fanNum.Font = new System.Drawing.Font("宋体", 11F);
            this.fanNum.Location = new System.Drawing.Point(641, 36);
            this.fanNum.Name = "fanNum";
            this.fanNum.Size = new System.Drawing.Size(97, 15);
            this.fanNum.TabIndex = 13;
            this.fanNum.Text = "当前游客登录";
            // 
            // FansForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 661);
            this.Controls.Add(this.backPanel);
            this.Controls.Add(this.personalList);
            this.Name = "FansForm";
            this.Text = "我的粉丝 - 个人中心";
            this.backPanel.ResumeLayout(false);
            this.backPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel backPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.ListBox personalList;
        private System.Windows.Forms.Label fanNum;
    }
}