namespace GameForum
{
    partial class CollectionForm
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
            this.personalList = new System.Windows.Forms.ListBox();
            this.title = new System.Windows.Forms.Label();
            this.otherPanel1 = new System.Windows.Forms.Panel();
            this.collectionDesc = new System.Windows.Forms.Label();
            this.collectionNum = new System.Windows.Forms.Label();
            this.otherPanel2 = new System.Windows.Forms.Panel();
            this.clear = new System.Windows.Forms.Label();
            this.otherPanel3 = new System.Windows.Forms.Panel();
            this.backPanel = new System.Windows.Forms.Panel();
            this.backPanel.SuspendLayout();
            this.SuspendLayout();
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
            this.personalList.Location = new System.Drawing.Point(100, 50);
            this.personalList.Name = "personalList";
            this.personalList.Size = new System.Drawing.Size(150, 205);
            this.personalList.TabIndex = 1;
            this.personalList.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.personalList_DrawItem);
            this.personalList.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.personalList_MeasureItem);
            this.personalList.SelectedIndexChanged += new System.EventHandler(this.personalList_SelectedIndexChanged);
            // 
            // title
            // 
            this.title.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.title.Location = new System.Drawing.Point(38, 27);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(109, 24);
            this.title.TabIndex = 1;
            this.title.Text = "我的收藏夹";
            // 
            // otherPanel1
            // 
            this.otherPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.otherPanel1.Location = new System.Drawing.Point(38, 72);
            this.otherPanel1.Name = "otherPanel1";
            this.otherPanel1.Size = new System.Drawing.Size(700, 1);
            this.otherPanel1.TabIndex = 2;
            // 
            // collectionDesc
            // 
            this.collectionDesc.AutoSize = true;
            this.collectionDesc.Font = new System.Drawing.Font("宋体", 12F);
            this.collectionDesc.Location = new System.Drawing.Point(38, 91);
            this.collectionDesc.Name = "collectionDesc";
            this.collectionDesc.Size = new System.Drawing.Size(232, 16);
            this.collectionDesc.TabIndex = 3;
            this.collectionDesc.Text = "收藏夹描述：请注册后添加收藏";
            // 
            // collectionNum
            // 
            this.collectionNum.AutoSize = true;
            this.collectionNum.Font = new System.Drawing.Font("宋体", 12F);
            this.collectionNum.Location = new System.Drawing.Point(38, 125);
            this.collectionNum.Name = "collectionNum";
            this.collectionNum.Size = new System.Drawing.Size(64, 16);
            this.collectionNum.TabIndex = 4;
            this.collectionNum.Text = "0条内容";
            // 
            // otherPanel2
            // 
            this.otherPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.otherPanel2.Location = new System.Drawing.Point(110, 125);
            this.otherPanel2.Name = "otherPanel2";
            this.otherPanel2.Size = new System.Drawing.Size(1, 18);
            this.otherPanel2.TabIndex = 5;
            // 
            // clear
            // 
            this.clear.AutoSize = true;
            this.clear.Font = new System.Drawing.Font("宋体", 12F);
            this.clear.Location = new System.Drawing.Point(125, 125);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(40, 16);
            this.clear.TabIndex = 6;
            this.clear.Text = "清空";
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // otherPanel3
            // 
            this.otherPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.otherPanel3.Location = new System.Drawing.Point(38, 153);
            this.otherPanel3.Name = "otherPanel3";
            this.otherPanel3.Size = new System.Drawing.Size(700, 1);
            this.otherPanel3.TabIndex = 3;
            // 
            // backPanel
            // 
            this.backPanel.AutoScroll = true;
            this.backPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.backPanel.Controls.Add(this.otherPanel3);
            this.backPanel.Controls.Add(this.clear);
            this.backPanel.Controls.Add(this.otherPanel2);
            this.backPanel.Controls.Add(this.collectionNum);
            this.backPanel.Controls.Add(this.collectionDesc);
            this.backPanel.Controls.Add(this.otherPanel1);
            this.backPanel.Controls.Add(this.title);
            this.backPanel.Location = new System.Drawing.Point(250, 50);
            this.backPanel.Name = "backPanel";
            this.backPanel.Size = new System.Drawing.Size(770, 500);
            this.backPanel.TabIndex = 2;
            // 
            // CollectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 661);
            this.Controls.Add(this.backPanel);
            this.Controls.Add(this.personalList);
            this.Name = "CollectionForm";
            this.Text = "我的收藏 - 个人中心";
            this.backPanel.ResumeLayout(false);
            this.backPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox personalList;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel otherPanel1;
        private System.Windows.Forms.Label collectionDesc;
        private System.Windows.Forms.Label collectionNum;
        private System.Windows.Forms.Panel otherPanel2;
        private System.Windows.Forms.Label clear;
        private System.Windows.Forms.Panel otherPanel3;
        private System.Windows.Forms.Panel backPanel;
    }
}