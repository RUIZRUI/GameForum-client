namespace GameForum
{
    partial class UserManageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserManageForm));
            this.backPanel = new System.Windows.Forms.Panel();
            this.userNum = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.onlineBtn = new System.Windows.Forms.Button();
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
            // backPanel
            // 
            this.backPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.backPanel.Controls.Add(this.userNum);
            this.backPanel.Controls.Add(this.panel3);
            this.backPanel.Controls.Add(this.title);
            this.backPanel.Location = new System.Drawing.Point(227, 138);
            this.backPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.backPanel.Name = "backPanel";
            this.backPanel.Size = new System.Drawing.Size(1137, 624);
            this.backPanel.TabIndex = 53;
            // 
            // userNum
            // 
            this.userNum.AutoSize = true;
            this.userNum.Font = new System.Drawing.Font("宋体", 12F);
            this.userNum.Location = new System.Drawing.Point(1031, 39);
            this.userNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userNum.Name = "userNum";
            this.userNum.Size = new System.Drawing.Size(49, 20);
            this.userNum.TabIndex = 6;
            this.userNum.Text = "游客";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(51, 90);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1043, 1);
            this.panel3.TabIndex = 5;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Bold);
            this.title.Location = new System.Drawing.Point(51, 34);
            this.title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(68, 27);
            this.title.TabIndex = 0;
            this.title.Text = "用户";
            // 
            // onlineBtn
            // 
            this.onlineBtn.BackColor = System.Drawing.Color.White;
            this.onlineBtn.Font = new System.Drawing.Font("宋体", 14F);
            this.onlineBtn.Location = new System.Drawing.Point(867, 62);
            this.onlineBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.onlineBtn.Name = "onlineBtn";
            this.onlineBtn.Size = new System.Drawing.Size(200, 50);
            this.onlineBtn.TabIndex = 52;
            this.onlineBtn.Text = "网页游戏";
            this.onlineBtn.UseVisualStyleBackColor = false;
            // 
            // commentPic
            // 
            this.commentPic.Image = global::GameForum.Properties.Resources.u252;
            this.commentPic.Location = new System.Drawing.Point(1439, 70);
            this.commentPic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.commentPic.Name = "commentPic";
            this.commentPic.Size = new System.Drawing.Size(40, 38);
            this.commentPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.commentPic.TabIndex = 51;
            this.commentPic.TabStop = false;
            // 
            // avatar
            // 
            this.avatar.Image = ((System.Drawing.Image)(resources.GetObject("avatar.Image")));
            this.avatar.Location = new System.Drawing.Point(1492, 70);
            this.avatar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.avatar.Name = "avatar";
            this.avatar.Size = new System.Drawing.Size(40, 38);
            this.avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avatar.TabIndex = 50;
            this.avatar.TabStop = false;
            // 
            // collectionPic
            // 
            this.collectionPic.Image = global::GameForum.Properties.Resources.u251;
            this.collectionPic.Location = new System.Drawing.Point(1385, 70);
            this.collectionPic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.collectionPic.Name = "collectionPic";
            this.collectionPic.Size = new System.Drawing.Size(40, 38);
            this.collectionPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.collectionPic.TabIndex = 49;
            this.collectionPic.TabStop = false;
            // 
            // publishBtn
            // 
            this.publishBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(155)))), ((int)(((byte)(213)))));
            this.publishBtn.Font = new System.Drawing.Font("宋体", 13F);
            this.publishBtn.ForeColor = System.Drawing.Color.White;
            this.publishBtn.Location = new System.Drawing.Point(1177, 62);
            this.publishBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.publishBtn.Name = "publishBtn";
            this.publishBtn.Size = new System.Drawing.Size(187, 50);
            this.publishBtn.TabIndex = 48;
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
            "数据统计",
            "用户管理"});
            this.manageList.Location = new System.Drawing.Point(67, 138);
            this.manageList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.manageList.Name = "manageList";
            this.manageList.Size = new System.Drawing.Size(159, 104);
            this.manageList.TabIndex = 47;
            this.manageList.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.personalList_DrawItem);
            this.manageList.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.personalList_MeasureItem);
            this.manageList.SelectedIndexChanged += new System.EventHandler(this.manageList_SelectedIndexChanged);
            // 
            // iosBtn
            // 
            this.iosBtn.BackColor = System.Drawing.Color.White;
            this.iosBtn.Font = new System.Drawing.Font("宋体", 14F);
            this.iosBtn.Location = new System.Drawing.Point(667, 62);
            this.iosBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.iosBtn.Name = "iosBtn";
            this.iosBtn.Size = new System.Drawing.Size(200, 50);
            this.iosBtn.TabIndex = 46;
            this.iosBtn.Text = "苹果游戏";
            this.iosBtn.UseVisualStyleBackColor = false;
            // 
            // androidBtn
            // 
            this.androidBtn.BackColor = System.Drawing.Color.White;
            this.androidBtn.Font = new System.Drawing.Font("宋体", 14F);
            this.androidBtn.Location = new System.Drawing.Point(467, 62);
            this.androidBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.androidBtn.Name = "androidBtn";
            this.androidBtn.Size = new System.Drawing.Size(200, 50);
            this.androidBtn.TabIndex = 45;
            this.androidBtn.Text = "安卓游戏";
            this.androidBtn.UseVisualStyleBackColor = false;
            // 
            // singleBtn
            // 
            this.singleBtn.BackColor = System.Drawing.Color.White;
            this.singleBtn.Font = new System.Drawing.Font("宋体", 14F);
            this.singleBtn.Location = new System.Drawing.Point(267, 62);
            this.singleBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.singleBtn.Name = "singleBtn";
            this.singleBtn.Size = new System.Drawing.Size(200, 50);
            this.singleBtn.TabIndex = 44;
            this.singleBtn.Text = "单机游戏";
            this.singleBtn.UseVisualStyleBackColor = false;
            // 
            // indexBtn
            // 
            this.indexBtn.BackColor = System.Drawing.Color.White;
            this.indexBtn.Font = new System.Drawing.Font("宋体", 14F);
            this.indexBtn.Location = new System.Drawing.Point(67, 62);
            this.indexBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.indexBtn.Name = "indexBtn";
            this.indexBtn.Size = new System.Drawing.Size(200, 50);
            this.indexBtn.TabIndex = 43;
            this.indexBtn.Text = "首页";
            this.indexBtn.UseVisualStyleBackColor = false;
            // 
            // UserManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1579, 826);
            this.Controls.Add(this.backPanel);
            this.Controls.Add(this.onlineBtn);
            this.Controls.Add(this.commentPic);
            this.Controls.Add(this.avatar);
            this.Controls.Add(this.collectionPic);
            this.Controls.Add(this.publishBtn);
            this.Controls.Add(this.manageList);
            this.Controls.Add(this.iosBtn);
            this.Controls.Add(this.androidBtn);
            this.Controls.Add(this.singleBtn);
            this.Controls.Add(this.indexBtn);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UserManageForm";
            this.Text = "用户管理 - 系统管理员";
            this.backPanel.ResumeLayout(false);
            this.backPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.commentPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collectionPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel backPanel;
        private System.Windows.Forms.Button onlineBtn;
        private System.Windows.Forms.PictureBox commentPic;
        private System.Windows.Forms.PictureBox avatar;
        private System.Windows.Forms.PictureBox collectionPic;
        private System.Windows.Forms.Button publishBtn;
        private System.Windows.Forms.ListBox manageList;
        private System.Windows.Forms.Button iosBtn;
        private System.Windows.Forms.Button androidBtn;
        private System.Windows.Forms.Button singleBtn;
        private System.Windows.Forms.Button indexBtn;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label userNum;
    }
}