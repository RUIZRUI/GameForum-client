namespace GameForum
{
    partial class SystemManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SystemManagerForm));
            this.onlineBtn = new System.Windows.Forms.Button();
            this.publishBtn = new System.Windows.Forms.Button();
            this.manageList = new System.Windows.Forms.ListBox();
            this.iosBtn = new System.Windows.Forms.Button();
            this.androidBtn = new System.Windows.Forms.Button();
            this.singleBtn = new System.Windows.Forms.Button();
            this.indexBtn = new System.Windows.Forms.Button();
            this.backPanel = new System.Windows.Forms.Panel();
            this.dailyActNum = new System.Windows.Forms.Label();
            this.dailyVisitNum = new System.Windows.Forms.Label();
            this.gameNum = new System.Windows.Forms.Label();
            this.singleGameNum = new System.Windows.Forms.Label();
            this.androidGameNum = new System.Windows.Forms.Label();
            this.iosGameNum = new System.Windows.Forms.Label();
            this.onlineGameNum = new System.Windows.Forms.Label();
            this.registerNum = new System.Windows.Forms.Label();
            this.commentPic = new System.Windows.Forms.PictureBox();
            this.avatar = new System.Windows.Forms.PictureBox();
            this.collectionPic = new System.Windows.Forms.PictureBox();
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
            this.onlineBtn.Location = new System.Drawing.Point(867, 62);
            this.onlineBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.onlineBtn.Name = "onlineBtn";
            this.onlineBtn.Size = new System.Drawing.Size(200, 50);
            this.onlineBtn.TabIndex = 41;
            this.onlineBtn.Text = "网页游戏";
            this.onlineBtn.UseVisualStyleBackColor = false;
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
            this.publishBtn.TabIndex = 37;
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
            this.manageList.TabIndex = 36;
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
            this.iosBtn.TabIndex = 35;
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
            this.androidBtn.TabIndex = 34;
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
            this.singleBtn.TabIndex = 33;
            this.singleBtn.Text = "单机游戏";
            this.singleBtn.UseVisualStyleBackColor = false;
            this.singleBtn.Click += new System.EventHandler(this.singleBtn_Click);
            // 
            // indexBtn
            // 
            this.indexBtn.BackColor = System.Drawing.Color.White;
            this.indexBtn.Font = new System.Drawing.Font("宋体", 14F);
            this.indexBtn.Location = new System.Drawing.Point(67, 62);
            this.indexBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.indexBtn.Name = "indexBtn";
            this.indexBtn.Size = new System.Drawing.Size(200, 50);
            this.indexBtn.TabIndex = 32;
            this.indexBtn.Text = "首页";
            this.indexBtn.UseVisualStyleBackColor = false;
            // 
            // backPanel
            // 
            this.backPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.backPanel.Controls.Add(this.dailyActNum);
            this.backPanel.Controls.Add(this.dailyVisitNum);
            this.backPanel.Controls.Add(this.gameNum);
            this.backPanel.Controls.Add(this.singleGameNum);
            this.backPanel.Controls.Add(this.androidGameNum);
            this.backPanel.Controls.Add(this.iosGameNum);
            this.backPanel.Controls.Add(this.onlineGameNum);
            this.backPanel.Controls.Add(this.registerNum);
            this.backPanel.Location = new System.Drawing.Point(227, 138);
            this.backPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.backPanel.Name = "backPanel";
            this.backPanel.Size = new System.Drawing.Size(1137, 624);
            this.backPanel.TabIndex = 42;
            // 
            // dailyActNum
            // 
            this.dailyActNum.AutoSize = true;
            this.dailyActNum.Font = new System.Drawing.Font("宋体", 12F);
            this.dailyActNum.Location = new System.Drawing.Point(107, 122);
            this.dailyActNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dailyActNum.Name = "dailyActNum";
            this.dailyActNum.Size = new System.Drawing.Size(89, 20);
            this.dailyActNum.TabIndex = 7;
            this.dailyActNum.Text = "日活量：";
            // 
            // dailyVisitNum
            // 
            this.dailyVisitNum.AutoSize = true;
            this.dailyVisitNum.Font = new System.Drawing.Font("宋体", 12F);
            this.dailyVisitNum.Location = new System.Drawing.Point(107, 182);
            this.dailyVisitNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dailyVisitNum.Name = "dailyVisitNum";
            this.dailyVisitNum.Size = new System.Drawing.Size(109, 20);
            this.dailyVisitNum.TabIndex = 6;
            this.dailyVisitNum.Text = "日访问量：";
            // 
            // gameNum
            // 
            this.gameNum.AutoSize = true;
            this.gameNum.Font = new System.Drawing.Font("宋体", 12F);
            this.gameNum.Location = new System.Drawing.Point(107, 242);
            this.gameNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gameNum.Name = "gameNum";
            this.gameNum.Size = new System.Drawing.Size(109, 20);
            this.gameNum.TabIndex = 5;
            this.gameNum.Text = "游戏总数：";
            // 
            // singleGameNum
            // 
            this.singleGameNum.AutoSize = true;
            this.singleGameNum.Font = new System.Drawing.Font("宋体", 12F);
            this.singleGameNum.Location = new System.Drawing.Point(107, 302);
            this.singleGameNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.singleGameNum.Name = "singleGameNum";
            this.singleGameNum.Size = new System.Drawing.Size(129, 20);
            this.singleGameNum.TabIndex = 4;
            this.singleGameNum.Text = "单机游戏数：";
            // 
            // androidGameNum
            // 
            this.androidGameNum.AutoSize = true;
            this.androidGameNum.Font = new System.Drawing.Font("宋体", 12F);
            this.androidGameNum.Location = new System.Drawing.Point(107, 362);
            this.androidGameNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.androidGameNum.Name = "androidGameNum";
            this.androidGameNum.Size = new System.Drawing.Size(129, 20);
            this.androidGameNum.TabIndex = 3;
            this.androidGameNum.Text = "安卓游戏数：";
            // 
            // iosGameNum
            // 
            this.iosGameNum.AutoSize = true;
            this.iosGameNum.Font = new System.Drawing.Font("宋体", 12F);
            this.iosGameNum.Location = new System.Drawing.Point(107, 422);
            this.iosGameNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.iosGameNum.Name = "iosGameNum";
            this.iosGameNum.Size = new System.Drawing.Size(129, 20);
            this.iosGameNum.TabIndex = 2;
            this.iosGameNum.Text = "苹果游戏数：";
            // 
            // onlineGameNum
            // 
            this.onlineGameNum.AutoSize = true;
            this.onlineGameNum.Font = new System.Drawing.Font("宋体", 12F);
            this.onlineGameNum.Location = new System.Drawing.Point(107, 482);
            this.onlineGameNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.onlineGameNum.Name = "onlineGameNum";
            this.onlineGameNum.Size = new System.Drawing.Size(129, 20);
            this.onlineGameNum.TabIndex = 1;
            this.onlineGameNum.Text = "网页游戏数：";
            // 
            // registerNum
            // 
            this.registerNum.AutoSize = true;
            this.registerNum.Font = new System.Drawing.Font("宋体", 12F);
            this.registerNum.Location = new System.Drawing.Point(107, 62);
            this.registerNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.registerNum.Name = "registerNum";
            this.registerNum.Size = new System.Drawing.Size(109, 20);
            this.registerNum.TabIndex = 0;
            this.registerNum.Text = "注册人数：";
            // 
            // commentPic
            // 
            this.commentPic.Image = global::GameForum.Properties.Resources.u252;
            this.commentPic.Location = new System.Drawing.Point(1439, 70);
            this.commentPic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.commentPic.Name = "commentPic";
            this.commentPic.Size = new System.Drawing.Size(40, 38);
            this.commentPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.commentPic.TabIndex = 40;
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
            this.avatar.TabIndex = 39;
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
            this.collectionPic.TabIndex = 38;
            this.collectionPic.TabStop = false;
            // 
            // SystemManagerForm
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
            this.Name = "SystemManagerForm";
            this.Text = "系统管理员";
            this.backPanel.ResumeLayout(false);
            this.backPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.commentPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collectionPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

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
        private System.Windows.Forms.Panel backPanel;
        private System.Windows.Forms.Label dailyActNum;
        private System.Windows.Forms.Label dailyVisitNum;
        private System.Windows.Forms.Label gameNum;
        private System.Windows.Forms.Label singleGameNum;
        private System.Windows.Forms.Label androidGameNum;
        private System.Windows.Forms.Label iosGameNum;
        private System.Windows.Forms.Label onlineGameNum;
        private System.Windows.Forms.Label registerNum;
    }
}