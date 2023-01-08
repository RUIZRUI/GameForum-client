namespace GameForum
{
    partial class GameManageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameManageForm));
            this.indexBtn = new System.Windows.Forms.Button();
            this.singleBtn = new System.Windows.Forms.Button();
            this.androidBtn = new System.Windows.Forms.Button();
            this.iosBtn = new System.Windows.Forms.Button();
            this.manageList = new System.Windows.Forms.ListBox();
            this.publishBtn = new System.Windows.Forms.Button();
            this.backPanel = new System.Windows.Forms.Panel();
            this.gameScore = new System.Windows.Forms.TextBox();
            this.gameImg = new System.Windows.Forms.TextBox();
            this.gameRaterNum = new System.Windows.Forms.TextBox();
            this.publish = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.gameImgLabel = new System.Windows.Forms.Label();
            this.gameRaterNumLabel = new System.Windows.Forms.Label();
            this.gameScoreLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gameReleaseDate = new System.Windows.Forms.TextBox();
            this.gameCleanDate = new System.Windows.Forms.TextBox();
            this.gamePlatform = new System.Windows.Forms.TextBox();
            this.gameWebsite = new System.Windows.Forms.TextBox();
            this.gameLabel = new System.Windows.Forms.TextBox();
            this.gameLanguage = new System.Windows.Forms.TextBox();
            this.gameRelease = new System.Windows.Forms.TextBox();
            this.gameReleaseLabel = new System.Windows.Forms.Label();
            this.gameClearnDateLabel = new System.Windows.Forms.Label();
            this.gamePlatformLabel = new System.Windows.Forms.Label();
            this.gameWebsiteLabel = new System.Windows.Forms.Label();
            this.gameLabelLabel = new System.Windows.Forms.Label();
            this.gameLanguageLabel = new System.Windows.Forms.Label();
            this.gameReleaseDateLabel = new System.Windows.Forms.Label();
            this.onlineRadioButton = new System.Windows.Forms.RadioButton();
            this.androidRadioButton = new System.Windows.Forms.RadioButton();
            this.iosRadioButton = new System.Windows.Forms.RadioButton();
            this.singleRadioButton = new System.Windows.Forms.RadioButton();
            this.gameType = new System.Windows.Forms.TextBox();
            this.gameTypeLabel = new System.Windows.Forms.Label();
            this.gameCollectionLabel = new System.Windows.Forms.Label();
            this.gameName = new System.Windows.Forms.TextBox();
            this.gameNameLabel = new System.Windows.Forms.Label();
            this.commentPic = new System.Windows.Forms.PictureBox();
            this.avatar = new System.Windows.Forms.PictureBox();
            this.collectionPic = new System.Windows.Forms.PictureBox();
            this.onlineBtn = new System.Windows.Forms.Button();
            this.backPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.commentPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collectionPic)).BeginInit();
            this.SuspendLayout();
            // 
            // indexBtn
            // 
            this.indexBtn.BackColor = System.Drawing.Color.White;
            this.indexBtn.Font = new System.Drawing.Font("宋体", 14F);
            this.indexBtn.Location = new System.Drawing.Point(67, 62);
            this.indexBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.indexBtn.Name = "indexBtn";
            this.indexBtn.Size = new System.Drawing.Size(200, 50);
            this.indexBtn.TabIndex = 0;
            this.indexBtn.Text = "首页";
            this.indexBtn.UseVisualStyleBackColor = false;
            this.indexBtn.Click += new System.EventHandler(this.indexBtn_Click);
            // 
            // singleBtn
            // 
            this.singleBtn.BackColor = System.Drawing.Color.White;
            this.singleBtn.Font = new System.Drawing.Font("宋体", 14F);
            this.singleBtn.Location = new System.Drawing.Point(267, 62);
            this.singleBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.singleBtn.Name = "singleBtn";
            this.singleBtn.Size = new System.Drawing.Size(200, 50);
            this.singleBtn.TabIndex = 1;
            this.singleBtn.Text = "单机游戏";
            this.singleBtn.UseVisualStyleBackColor = false;
            this.singleBtn.Click += new System.EventHandler(this.singleBtn_Click);
            // 
            // androidBtn
            // 
            this.androidBtn.BackColor = System.Drawing.Color.White;
            this.androidBtn.Font = new System.Drawing.Font("宋体", 14F);
            this.androidBtn.Location = new System.Drawing.Point(467, 62);
            this.androidBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.androidBtn.Name = "androidBtn";
            this.androidBtn.Size = new System.Drawing.Size(200, 50);
            this.androidBtn.TabIndex = 2;
            this.androidBtn.Text = "安卓游戏";
            this.androidBtn.UseVisualStyleBackColor = false;
            this.androidBtn.Click += new System.EventHandler(this.androidBtn_Click);
            // 
            // iosBtn
            // 
            this.iosBtn.BackColor = System.Drawing.Color.White;
            this.iosBtn.Font = new System.Drawing.Font("宋体", 14F);
            this.iosBtn.Location = new System.Drawing.Point(667, 62);
            this.iosBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.iosBtn.Name = "iosBtn";
            this.iosBtn.Size = new System.Drawing.Size(200, 50);
            this.iosBtn.TabIndex = 3;
            this.iosBtn.Text = "苹果游戏";
            this.iosBtn.UseVisualStyleBackColor = false;
            this.iosBtn.Click += new System.EventHandler(this.iosBtn_Click);
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
            this.manageList.Location = new System.Drawing.Point(67, 138);
            this.manageList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.manageList.Name = "manageList";
            this.manageList.Size = new System.Drawing.Size(159, 154);
            this.manageList.TabIndex = 4;
            this.manageList.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.personalList_DrawItem);
            this.manageList.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.personalList_MeasureItem);
            this.manageList.SelectedIndexChanged += new System.EventHandler(this.manageList_SelectedIndexChanged);
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
            this.publishBtn.TabIndex = 5;
            this.publishBtn.Text = "发布游戏";
            this.publishBtn.UseVisualStyleBackColor = false;
            this.publishBtn.Click += new System.EventHandler(this.publishBtn_Click);
            // 
            // backPanel
            // 
            this.backPanel.AutoScroll = true;
            this.backPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.backPanel.Controls.Add(this.gameScore);
            this.backPanel.Controls.Add(this.gameImg);
            this.backPanel.Controls.Add(this.gameRaterNum);
            this.backPanel.Controls.Add(this.publish);
            this.backPanel.Controls.Add(this.reset);
            this.backPanel.Controls.Add(this.gameImgLabel);
            this.backPanel.Controls.Add(this.gameRaterNumLabel);
            this.backPanel.Controls.Add(this.gameScoreLabel);
            this.backPanel.Controls.Add(this.panel1);
            this.backPanel.Controls.Add(this.onlineRadioButton);
            this.backPanel.Controls.Add(this.androidRadioButton);
            this.backPanel.Controls.Add(this.iosRadioButton);
            this.backPanel.Controls.Add(this.singleRadioButton);
            this.backPanel.Controls.Add(this.gameType);
            this.backPanel.Controls.Add(this.gameTypeLabel);
            this.backPanel.Controls.Add(this.gameCollectionLabel);
            this.backPanel.Controls.Add(this.gameName);
            this.backPanel.Controls.Add(this.gameNameLabel);
            this.backPanel.Location = new System.Drawing.Point(227, 138);
            this.backPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.backPanel.Name = "backPanel";
            this.backPanel.Size = new System.Drawing.Size(1137, 624);
            this.backPanel.TabIndex = 9;
            // 
            // gameScore
            // 
            this.gameScore.Font = new System.Drawing.Font("宋体", 18F);
            this.gameScore.Location = new System.Drawing.Point(273, 890);
            this.gameScore.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gameScore.Name = "gameScore";
            this.gameScore.Size = new System.Drawing.Size(399, 42);
            this.gameScore.TabIndex = 0;
            // 
            // gameImg
            // 
            this.gameImg.Font = new System.Drawing.Font("宋体", 18F);
            this.gameImg.Location = new System.Drawing.Point(273, 1060);
            this.gameImg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gameImg.Name = "gameImg";
            this.gameImg.Size = new System.Drawing.Size(399, 42);
            this.gameImg.TabIndex = 15;
            // 
            // gameRaterNum
            // 
            this.gameRaterNum.Font = new System.Drawing.Font("宋体", 18F);
            this.gameRaterNum.Location = new System.Drawing.Point(273, 975);
            this.gameRaterNum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gameRaterNum.Name = "gameRaterNum";
            this.gameRaterNum.Size = new System.Drawing.Size(399, 42);
            this.gameRaterNum.TabIndex = 14;
            // 
            // publish
            // 
            this.publish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(155)))), ((int)(((byte)(213)))));
            this.publish.Font = new System.Drawing.Font("宋体", 12F);
            this.publish.ForeColor = System.Drawing.Color.White;
            this.publish.Location = new System.Drawing.Point(517, 1145);
            this.publish.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.publish.Name = "publish";
            this.publish.Size = new System.Drawing.Size(133, 50);
            this.publish.TabIndex = 13;
            this.publish.Text = "发布";
            this.publish.UseVisualStyleBackColor = false;
            this.publish.Click += new System.EventHandler(this.publish_Click);
            // 
            // reset
            // 
            this.reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(155)))), ((int)(((byte)(213)))));
            this.reset.Font = new System.Drawing.Font("宋体", 12F);
            this.reset.ForeColor = System.Drawing.Color.White;
            this.reset.Location = new System.Drawing.Point(273, 1145);
            this.reset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(133, 50);
            this.reset.TabIndex = 12;
            this.reset.Text = "重置";
            this.reset.UseVisualStyleBackColor = false;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // gameImgLabel
            // 
            this.gameImgLabel.AutoSize = true;
            this.gameImgLabel.Font = new System.Drawing.Font("宋体", 12F);
            this.gameImgLabel.Location = new System.Drawing.Point(107, 1070);
            this.gameImgLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gameImgLabel.Name = "gameImgLabel";
            this.gameImgLabel.Size = new System.Drawing.Size(109, 20);
            this.gameImgLabel.TabIndex = 11;
            this.gameImgLabel.Text = "游戏图像：";
            // 
            // gameRaterNumLabel
            // 
            this.gameRaterNumLabel.AutoSize = true;
            this.gameRaterNumLabel.Font = new System.Drawing.Font("宋体", 12F);
            this.gameRaterNumLabel.Location = new System.Drawing.Point(107, 985);
            this.gameRaterNumLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gameRaterNumLabel.Name = "gameRaterNumLabel";
            this.gameRaterNumLabel.Size = new System.Drawing.Size(139, 20);
            this.gameRaterNumLabel.TabIndex = 10;
            this.gameRaterNumLabel.Text = "游戏评分人数:";
            // 
            // gameScoreLabel
            // 
            this.gameScoreLabel.AutoSize = true;
            this.gameScoreLabel.Font = new System.Drawing.Font("宋体", 12F);
            this.gameScoreLabel.Location = new System.Drawing.Point(107, 900);
            this.gameScoreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gameScoreLabel.Name = "gameScoreLabel";
            this.gameScoreLabel.Size = new System.Drawing.Size(109, 20);
            this.gameScoreLabel.TabIndex = 9;
            this.gameScoreLabel.Text = "游戏评分：";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gameReleaseDate);
            this.panel1.Controls.Add(this.gameCleanDate);
            this.panel1.Controls.Add(this.gamePlatform);
            this.panel1.Controls.Add(this.gameWebsite);
            this.panel1.Controls.Add(this.gameLabel);
            this.panel1.Controls.Add(this.gameLanguage);
            this.panel1.Controls.Add(this.gameRelease);
            this.panel1.Controls.Add(this.gameReleaseLabel);
            this.panel1.Controls.Add(this.gameClearnDateLabel);
            this.panel1.Controls.Add(this.gamePlatformLabel);
            this.panel1.Controls.Add(this.gameWebsiteLabel);
            this.panel1.Controls.Add(this.gameLabelLabel);
            this.panel1.Controls.Add(this.gameLanguageLabel);
            this.panel1.Controls.Add(this.gameReleaseDateLabel);
            this.panel1.Location = new System.Drawing.Point(107, 295);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(567, 554);
            this.panel1.TabIndex = 8;
            // 
            // gameReleaseDate
            // 
            this.gameReleaseDate.Font = new System.Drawing.Font("宋体", 18F);
            this.gameReleaseDate.Location = new System.Drawing.Point(167, 85);
            this.gameReleaseDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gameReleaseDate.Name = "gameReleaseDate";
            this.gameReleaseDate.Size = new System.Drawing.Size(399, 42);
            this.gameReleaseDate.TabIndex = 13;
            // 
            // gameCleanDate
            // 
            this.gameCleanDate.Font = new System.Drawing.Font("宋体", 18F);
            this.gameCleanDate.Location = new System.Drawing.Point(167, 170);
            this.gameCleanDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gameCleanDate.Name = "gameCleanDate";
            this.gameCleanDate.Size = new System.Drawing.Size(399, 42);
            this.gameCleanDate.TabIndex = 12;
            // 
            // gamePlatform
            // 
            this.gamePlatform.Font = new System.Drawing.Font("宋体", 18F);
            this.gamePlatform.Location = new System.Drawing.Point(167, 255);
            this.gamePlatform.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gamePlatform.Name = "gamePlatform";
            this.gamePlatform.Size = new System.Drawing.Size(399, 42);
            this.gamePlatform.TabIndex = 11;
            // 
            // gameWebsite
            // 
            this.gameWebsite.Font = new System.Drawing.Font("宋体", 18F);
            this.gameWebsite.Location = new System.Drawing.Point(167, 340);
            this.gameWebsite.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gameWebsite.Name = "gameWebsite";
            this.gameWebsite.Size = new System.Drawing.Size(399, 42);
            this.gameWebsite.TabIndex = 10;
            // 
            // gameLabel
            // 
            this.gameLabel.Font = new System.Drawing.Font("宋体", 18F);
            this.gameLabel.Location = new System.Drawing.Point(167, 425);
            this.gameLabel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gameLabel.Name = "gameLabel";
            this.gameLabel.Size = new System.Drawing.Size(399, 42);
            this.gameLabel.TabIndex = 9;
            // 
            // gameLanguage
            // 
            this.gameLanguage.Font = new System.Drawing.Font("宋体", 18F);
            this.gameLanguage.Location = new System.Drawing.Point(167, 511);
            this.gameLanguage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gameLanguage.Name = "gameLanguage";
            this.gameLanguage.Size = new System.Drawing.Size(399, 42);
            this.gameLanguage.TabIndex = 8;
            // 
            // gameRelease
            // 
            this.gameRelease.Font = new System.Drawing.Font("宋体", 18F);
            this.gameRelease.Location = new System.Drawing.Point(167, 0);
            this.gameRelease.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gameRelease.Name = "gameRelease";
            this.gameRelease.Size = new System.Drawing.Size(399, 42);
            this.gameRelease.TabIndex = 7;
            // 
            // gameReleaseLabel
            // 
            this.gameReleaseLabel.AutoSize = true;
            this.gameReleaseLabel.Font = new System.Drawing.Font("宋体", 12F);
            this.gameReleaseLabel.Location = new System.Drawing.Point(0, 10);
            this.gameReleaseLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gameReleaseLabel.Name = "gameReleaseLabel";
            this.gameReleaseLabel.Size = new System.Drawing.Size(149, 20);
            this.gameReleaseLabel.TabIndex = 6;
            this.gameReleaseLabel.Text = "游戏开发发行：";
            // 
            // gameClearnDateLabel
            // 
            this.gameClearnDateLabel.AutoSize = true;
            this.gameClearnDateLabel.Font = new System.Drawing.Font("宋体", 12F);
            this.gameClearnDateLabel.Location = new System.Drawing.Point(0, 180);
            this.gameClearnDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gameClearnDateLabel.Name = "gameClearnDateLabel";
            this.gameClearnDateLabel.Size = new System.Drawing.Size(149, 20);
            this.gameClearnDateLabel.TabIndex = 5;
            this.gameClearnDateLabel.Text = "游戏整理日期：";
            // 
            // gamePlatformLabel
            // 
            this.gamePlatformLabel.AutoSize = true;
            this.gamePlatformLabel.Font = new System.Drawing.Font("宋体", 12F);
            this.gamePlatformLabel.Location = new System.Drawing.Point(0, 265);
            this.gamePlatformLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gamePlatformLabel.Name = "gamePlatformLabel";
            this.gamePlatformLabel.Size = new System.Drawing.Size(109, 20);
            this.gamePlatformLabel.TabIndex = 4;
            this.gamePlatformLabel.Text = "游戏平台：";
            // 
            // gameWebsiteLabel
            // 
            this.gameWebsiteLabel.AutoSize = true;
            this.gameWebsiteLabel.Font = new System.Drawing.Font("宋体", 12F);
            this.gameWebsiteLabel.Location = new System.Drawing.Point(0, 350);
            this.gameWebsiteLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gameWebsiteLabel.Name = "gameWebsiteLabel";
            this.gameWebsiteLabel.Size = new System.Drawing.Size(109, 20);
            this.gameWebsiteLabel.TabIndex = 3;
            this.gameWebsiteLabel.Text = "游戏官网：";
            // 
            // gameLabelLabel
            // 
            this.gameLabelLabel.AutoSize = true;
            this.gameLabelLabel.Font = new System.Drawing.Font("宋体", 12F);
            this.gameLabelLabel.Location = new System.Drawing.Point(0, 435);
            this.gameLabelLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gameLabelLabel.Name = "gameLabelLabel";
            this.gameLabelLabel.Size = new System.Drawing.Size(109, 20);
            this.gameLabelLabel.TabIndex = 2;
            this.gameLabelLabel.Text = "游戏标签：";
            // 
            // gameLanguageLabel
            // 
            this.gameLanguageLabel.AutoSize = true;
            this.gameLanguageLabel.Font = new System.Drawing.Font("宋体", 12F);
            this.gameLanguageLabel.Location = new System.Drawing.Point(0, 520);
            this.gameLanguageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gameLanguageLabel.Name = "gameLanguageLabel";
            this.gameLanguageLabel.Size = new System.Drawing.Size(109, 20);
            this.gameLanguageLabel.TabIndex = 1;
            this.gameLanguageLabel.Text = "游戏语言：";
            // 
            // gameReleaseDateLabel
            // 
            this.gameReleaseDateLabel.AutoSize = true;
            this.gameReleaseDateLabel.Font = new System.Drawing.Font("宋体", 12F);
            this.gameReleaseDateLabel.Location = new System.Drawing.Point(0, 95);
            this.gameReleaseDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gameReleaseDateLabel.Name = "gameReleaseDateLabel";
            this.gameReleaseDateLabel.Size = new System.Drawing.Size(149, 20);
            this.gameReleaseDateLabel.TabIndex = 0;
            this.gameReleaseDateLabel.Text = "游戏发售日期：";
            // 
            // onlineRadioButton
            // 
            this.onlineRadioButton.AutoSize = true;
            this.onlineRadioButton.Font = new System.Drawing.Font("宋体", 11F);
            this.onlineRadioButton.Location = new System.Drawing.Point(794, 136);
            this.onlineRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.onlineRadioButton.Name = "onlineRadioButton";
            this.onlineRadioButton.Size = new System.Drawing.Size(123, 26);
            this.onlineRadioButton.TabIndex = 8;
            this.onlineRadioButton.TabStop = true;
            this.onlineRadioButton.Text = "网页游戏";
            this.onlineRadioButton.UseVisualStyleBackColor = true;
            // 
            // androidRadioButton
            // 
            this.androidRadioButton.AutoSize = true;
            this.androidRadioButton.Font = new System.Drawing.Font("宋体", 11F);
            this.androidRadioButton.Location = new System.Drawing.Point(470, 136);
            this.androidRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.androidRadioButton.Name = "androidRadioButton";
            this.androidRadioButton.Size = new System.Drawing.Size(123, 26);
            this.androidRadioButton.TabIndex = 6;
            this.androidRadioButton.TabStop = true;
            this.androidRadioButton.Text = "安卓游戏";
            this.androidRadioButton.UseVisualStyleBackColor = true;
            //
            // iosRadioButton
            //
            this.iosRadioButton.AutoSize = true;
            this.iosRadioButton.Font = new System.Drawing.Font("宋体", 11F);
            this.iosRadioButton.Location = new System.Drawing.Point(632, 136);
            this.iosRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.iosRadioButton.Name = "iosRadioButton";
            this.iosRadioButton.Size = new System.Drawing.Size(123, 26);
            this.iosRadioButton.TabIndex = 7;
            this.iosRadioButton.TabStop = true;
            this.iosRadioButton.Text = "苹果游戏";
            this.iosRadioButton.UseVisualStyleBackColor = true;
            // 
            // singleRadioButton
            // 
            this.singleRadioButton.AutoSize = true;
            this.singleRadioButton.Font = new System.Drawing.Font("宋体", 11F);
            this.singleRadioButton.Location = new System.Drawing.Point(308, 136);
            this.singleRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.singleRadioButton.Name = "singleRadioButton";
            this.singleRadioButton.Size = new System.Drawing.Size(123, 26);
            this.singleRadioButton.TabIndex = 5;
            this.singleRadioButton.TabStop = true;
            this.singleRadioButton.Text = "单机游戏";
            this.singleRadioButton.UseVisualStyleBackColor = true;
            // 
            // gameType
            // 
            this.gameType.Font = new System.Drawing.Font("宋体", 18F);
            this.gameType.Location = new System.Drawing.Point(273, 210);
            this.gameType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gameType.Name = "gameType";
            this.gameType.Size = new System.Drawing.Size(399, 42);
            this.gameType.TabIndex = 4;
            // 
            // gameTypeLabel
            // 
            this.gameTypeLabel.AutoSize = true;
            this.gameTypeLabel.Font = new System.Drawing.Font("宋体", 12F);
            this.gameTypeLabel.Location = new System.Drawing.Point(107, 220);
            this.gameTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gameTypeLabel.Name = "gameTypeLabel";
            this.gameTypeLabel.Size = new System.Drawing.Size(109, 20);
            this.gameTypeLabel.TabIndex = 3;
            this.gameTypeLabel.Text = "游戏类型：";
            // 
            // gameCollectionLabel
            // 
            this.gameCollectionLabel.AutoSize = true;
            this.gameCollectionLabel.Font = new System.Drawing.Font("宋体", 12F);
            this.gameCollectionLabel.Location = new System.Drawing.Point(107, 135);
            this.gameCollectionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gameCollectionLabel.Name = "gameCollectionLabel";
            this.gameCollectionLabel.Size = new System.Drawing.Size(149, 20);
            this.gameCollectionLabel.TabIndex = 2;
            this.gameCollectionLabel.Text = "游戏所属集合：";
            // 
            // gameName
            // 
            this.gameName.Font = new System.Drawing.Font("宋体", 18F);
            this.gameName.Location = new System.Drawing.Point(273, 38);
            this.gameName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gameName.Name = "gameName";
            this.gameName.Size = new System.Drawing.Size(399, 42);
            this.gameName.TabIndex = 1;
            // 
            // gameNameLabel
            // 
            this.gameNameLabel.AutoSize = true;
            this.gameNameLabel.Font = new System.Drawing.Font("宋体", 12F);
            this.gameNameLabel.Location = new System.Drawing.Point(107, 50);
            this.gameNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gameNameLabel.Name = "gameNameLabel";
            this.gameNameLabel.Size = new System.Drawing.Size(89, 20);
            this.gameNameLabel.TabIndex = 0;
            this.gameNameLabel.Text = "游戏名：";
            // 
            // commentPic
            // 
            this.commentPic.Image = global::GameForum.Properties.Resources.u252;
            this.commentPic.Location = new System.Drawing.Point(1439, 70);
            this.commentPic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.commentPic.Name = "commentPic";
            this.commentPic.Size = new System.Drawing.Size(40, 38);
            this.commentPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.commentPic.TabIndex = 8;
            this.commentPic.TabStop = false;
            this.commentPic.Click += new System.EventHandler(this.commentPic_Click);
            // 
            // avatar
            // 
            this.avatar.Image = ((System.Drawing.Image)(resources.GetObject("avatar.Image")));
            this.avatar.Location = new System.Drawing.Point(1492, 70);
            this.avatar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.avatar.Name = "avatar";
            this.avatar.Size = new System.Drawing.Size(40, 38);
            this.avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avatar.TabIndex = 7;
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
            this.collectionPic.TabIndex = 6;
            this.collectionPic.TabStop = false;
            this.collectionPic.Click += new System.EventHandler(this.collectionPic_Click);
            // 
            // onlineBtn
            // 
            this.onlineBtn.BackColor = System.Drawing.Color.White;
            this.onlineBtn.Font = new System.Drawing.Font("宋体", 14F);
            this.onlineBtn.Location = new System.Drawing.Point(867, 62);
            this.onlineBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.onlineBtn.Name = "onlineBtn";
            this.onlineBtn.Size = new System.Drawing.Size(200, 50);
            this.onlineBtn.TabIndex = 10;
            this.onlineBtn.Text = "网页游戏";
            this.onlineBtn.UseVisualStyleBackColor = false;
            this.onlineBtn.Click += new System.EventHandler(this.onlineBtn_Click);
            // 
            // GameManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1579, 826);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GameManageForm";
            this.Text = "发布游戏 - 游戏管理";
            this.backPanel.ResumeLayout(false);
            this.backPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.commentPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collectionPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button indexBtn;
        private System.Windows.Forms.Button singleBtn;
        private System.Windows.Forms.Button androidBtn;
        private System.Windows.Forms.Button iosBtn;
        private System.Windows.Forms.ListBox manageList;
        private System.Windows.Forms.Button publishBtn;
        private System.Windows.Forms.PictureBox collectionPic;
        private System.Windows.Forms.PictureBox avatar;
        private System.Windows.Forms.PictureBox commentPic;
        private System.Windows.Forms.Panel backPanel;
        private System.Windows.Forms.Button onlineBtn;
        private System.Windows.Forms.RadioButton onlineRadioButton;
        private System.Windows.Forms.RadioButton androidRadioButton;
        private System.Windows.Forms.RadioButton iosRadioButton;
        private System.Windows.Forms.RadioButton singleRadioButton;
        private System.Windows.Forms.TextBox gameType;
        private System.Windows.Forms.Label gameTypeLabel;
        private System.Windows.Forms.Label gameCollectionLabel;
        private System.Windows.Forms.TextBox gameName;
        private System.Windows.Forms.Label gameNameLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox gameScore;
        private System.Windows.Forms.TextBox gameImg;
        private System.Windows.Forms.TextBox gameRaterNum;
        private System.Windows.Forms.Button publish;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Label gameImgLabel;
        private System.Windows.Forms.Label gameRaterNumLabel;
        private System.Windows.Forms.Label gameScoreLabel;
        private System.Windows.Forms.Label gameReleaseLabel;
        private System.Windows.Forms.Label gameClearnDateLabel;
        private System.Windows.Forms.Label gamePlatformLabel;
        private System.Windows.Forms.Label gameWebsiteLabel;
        private System.Windows.Forms.Label gameLabelLabel;
        private System.Windows.Forms.Label gameLanguageLabel;
        private System.Windows.Forms.Label gameReleaseDateLabel;
        private System.Windows.Forms.TextBox gameReleaseDate;
        private System.Windows.Forms.TextBox gameCleanDate;
        private System.Windows.Forms.TextBox gamePlatform;
        private System.Windows.Forms.TextBox gameWebsite;
        private System.Windows.Forms.TextBox gameLabel;
        private System.Windows.Forms.TextBox gameLanguage;
        private System.Windows.Forms.TextBox gameRelease;
    }
}