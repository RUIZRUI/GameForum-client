namespace GameForum
{
    partial class GameEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameEditForm));
            this.onlineBtn = new System.Windows.Forms.Button();
            this.backPanel = new System.Windows.Forms.Panel();
            this.developLabel = new System.Windows.Forms.Label();
            this.commentPic = new System.Windows.Forms.PictureBox();
            this.avatar = new System.Windows.Forms.PictureBox();
            this.collectionPic = new System.Windows.Forms.PictureBox();
            this.publishBtn = new System.Windows.Forms.Button();
            this.manageList = new System.Windows.Forms.ListBox();
            this.iosBtn = new System.Windows.Forms.Button();
            this.androidBtn = new System.Windows.Forms.Button();
            this.singleBtn = new System.Windows.Forms.Button();
            this.indexBtn = new System.Windows.Forms.Button();
            this.backPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.commentPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collectionPic)).BeginInit();
            this.SuspendLayout();
            // 
            // onlineBtn
            // 
            this.onlineBtn.BackColor = System.Drawing.Color.White;
            this.onlineBtn.Font = new System.Drawing.Font("宋体", 14F);
            this.onlineBtn.Location = new System.Drawing.Point(650, 50);
            this.onlineBtn.Name = "onlineBtn";
            this.onlineBtn.Size = new System.Drawing.Size(150, 40);
            this.onlineBtn.TabIndex = 31;
            this.onlineBtn.Text = "网页游戏";
            this.onlineBtn.UseVisualStyleBackColor = false;
            // 
            // backPanel
            // 
            this.backPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.backPanel.Controls.Add(this.developLabel);
            this.backPanel.Location = new System.Drawing.Point(170, 110);
            this.backPanel.Name = "backPanel";
            this.backPanel.Size = new System.Drawing.Size(853, 500);
            this.backPanel.TabIndex = 30;
            // 
            // developLabel
            // 
            this.developLabel.AutoSize = true;
            this.developLabel.Font = new System.Drawing.Font("宋体", 32F);
            this.developLabel.Location = new System.Drawing.Point(54, 73);
            this.developLabel.Name = "developLabel";
            this.developLabel.Size = new System.Drawing.Size(234, 43);
            this.developLabel.TabIndex = 1;
            this.developLabel.Text = "功能开发中";
            // 
            // commentPic
            // 
            this.commentPic.Image = global::GameForum.Properties.Resources.u252;
            this.commentPic.Location = new System.Drawing.Point(1079, 56);
            this.commentPic.Name = "commentPic";
            this.commentPic.Size = new System.Drawing.Size(30, 30);
            this.commentPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.commentPic.TabIndex = 29;
            this.commentPic.TabStop = false;
            // 
            // avatar
            // 
            this.avatar.Image = ((System.Drawing.Image)(resources.GetObject("avatar.Image")));
            this.avatar.Location = new System.Drawing.Point(1119, 56);
            this.avatar.Name = "avatar";
            this.avatar.Size = new System.Drawing.Size(30, 30);
            this.avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avatar.TabIndex = 28;
            this.avatar.TabStop = false;
            // 
            // collectionPic
            // 
            this.collectionPic.Image = global::GameForum.Properties.Resources.u251;
            this.collectionPic.Location = new System.Drawing.Point(1039, 56);
            this.collectionPic.Name = "collectionPic";
            this.collectionPic.Size = new System.Drawing.Size(30, 30);
            this.collectionPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.collectionPic.TabIndex = 27;
            this.collectionPic.TabStop = false;
            // 
            // publishBtn
            // 
            this.publishBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(155)))), ((int)(((byte)(213)))));
            this.publishBtn.Font = new System.Drawing.Font("宋体", 13F);
            this.publishBtn.ForeColor = System.Drawing.Color.White;
            this.publishBtn.Location = new System.Drawing.Point(883, 50);
            this.publishBtn.Name = "publishBtn";
            this.publishBtn.Size = new System.Drawing.Size(140, 40);
            this.publishBtn.TabIndex = 26;
            this.publishBtn.Text = "发布游戏";
            this.publishBtn.UseVisualStyleBackColor = false;
            // 
            // manageList
            // 
            this.manageList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.manageList.Font = new System.Drawing.Font("宋体", 11F);
            this.manageList.FormattingEnabled = true;
            this.manageList.ItemHeight = 40;
            this.manageList.Items.AddRange(new object[] {
            "发布游戏",
            "删除游戏",
            "编辑游戏"});
            this.manageList.Location = new System.Drawing.Point(50, 110);
            this.manageList.Name = "manageList";
            this.manageList.Size = new System.Drawing.Size(120, 124);
            this.manageList.TabIndex = 25;
            this.manageList.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.personalList_DrawItem);
            this.manageList.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.personalList_MeasureItem);
            this.manageList.SelectedIndexChanged += new System.EventHandler(this.manageList_SelectedIndexChanged);
            // 
            // iosBtn
            // 
            this.iosBtn.BackColor = System.Drawing.Color.White;
            this.iosBtn.Font = new System.Drawing.Font("宋体", 14F);
            this.iosBtn.Location = new System.Drawing.Point(500, 50);
            this.iosBtn.Name = "iosBtn";
            this.iosBtn.Size = new System.Drawing.Size(150, 40);
            this.iosBtn.TabIndex = 24;
            this.iosBtn.Text = "苹果游戏";
            this.iosBtn.UseVisualStyleBackColor = false;
            // 
            // androidBtn
            // 
            this.androidBtn.BackColor = System.Drawing.Color.White;
            this.androidBtn.Font = new System.Drawing.Font("宋体", 14F);
            this.androidBtn.Location = new System.Drawing.Point(350, 50);
            this.androidBtn.Name = "androidBtn";
            this.androidBtn.Size = new System.Drawing.Size(150, 40);
            this.androidBtn.TabIndex = 23;
            this.androidBtn.Text = "安卓游戏";
            this.androidBtn.UseVisualStyleBackColor = false;
            // 
            // singleBtn
            // 
            this.singleBtn.BackColor = System.Drawing.Color.White;
            this.singleBtn.Font = new System.Drawing.Font("宋体", 14F);
            this.singleBtn.Location = new System.Drawing.Point(200, 50);
            this.singleBtn.Name = "singleBtn";
            this.singleBtn.Size = new System.Drawing.Size(150, 40);
            this.singleBtn.TabIndex = 22;
            this.singleBtn.Text = "单机游戏";
            this.singleBtn.UseVisualStyleBackColor = false;
            // 
            // indexBtn
            // 
            this.indexBtn.BackColor = System.Drawing.Color.White;
            this.indexBtn.Font = new System.Drawing.Font("宋体", 14F);
            this.indexBtn.Location = new System.Drawing.Point(50, 50);
            this.indexBtn.Name = "indexBtn";
            this.indexBtn.Size = new System.Drawing.Size(150, 40);
            this.indexBtn.TabIndex = 21;
            this.indexBtn.Text = "首页";
            this.indexBtn.UseVisualStyleBackColor = false;
            // 
            // GameEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.onlineBtn);
            this.Controls.Add(this.backPanel);
            this.Controls.Add(this.commentPic);
            this.Controls.Add(this.avatar);
            this.Controls.Add(this.collectionPic);
            this.Controls.Add(this.publishBtn);
            this.Controls.Add(this.manageList);
            this.Controls.Add(this.iosBtn);
            this.Controls.Add(this.androidBtn);
            this.Controls.Add(this.singleBtn);
            this.Controls.Add(this.indexBtn);
            this.Name = "GameEditForm";
            this.Text = "编辑游戏 - 游戏管理";
            this.backPanel.ResumeLayout(false);
            this.backPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.commentPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collectionPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button onlineBtn;
        private System.Windows.Forms.Panel backPanel;
        private System.Windows.Forms.PictureBox commentPic;
        private System.Windows.Forms.PictureBox avatar;
        private System.Windows.Forms.PictureBox collectionPic;
        private System.Windows.Forms.Button publishBtn;
        private System.Windows.Forms.ListBox manageList;
        private System.Windows.Forms.Button iosBtn;
        private System.Windows.Forms.Button androidBtn;
        private System.Windows.Forms.Button singleBtn;
        private System.Windows.Forms.Button indexBtn;
        private System.Windows.Forms.Label developLabel;
    }
}