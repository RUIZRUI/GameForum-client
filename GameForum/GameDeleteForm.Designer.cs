namespace GameForum
{
    partial class GameDeleteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameDeleteForm));
            this.backPanel = new System.Windows.Forms.Panel();
            this.delete = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.onlineRadioButton = new System.Windows.Forms.RadioButton();
            this.androidRadioButton = new System.Windows.Forms.RadioButton();
            this.iosRadioButton = new System.Windows.Forms.RadioButton();
            this.singleRadioButton = new System.Windows.Forms.RadioButton();
            this.gameCollectionLabel = new System.Windows.Forms.Label();
            this.gameName = new System.Windows.Forms.TextBox();
            this.gameNameLabel = new System.Windows.Forms.Label();
            this.publishBtn = new System.Windows.Forms.Button();
            this.manageList = new System.Windows.Forms.ListBox();
            this.iosBtn = new System.Windows.Forms.Button();
            this.androidBtn = new System.Windows.Forms.Button();
            this.singleBtn = new System.Windows.Forms.Button();
            this.indexBtn = new System.Windows.Forms.Button();
            this.commentPic = new System.Windows.Forms.PictureBox();
            this.avatar = new System.Windows.Forms.PictureBox();
            this.collectionPic = new System.Windows.Forms.PictureBox();
            this.onlineBtn = new System.Windows.Forms.Button();
            this.backPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.commentPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collectionPic)).BeginInit();
            this.SuspendLayout();
            // 
            // backPanel
            // 
            this.backPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.backPanel.Controls.Add(this.delete);
            this.backPanel.Controls.Add(this.reset);
            this.backPanel.Controls.Add(this.onlineRadioButton);
            this.backPanel.Controls.Add(this.androidRadioButton);
            this.backPanel.Controls.Add(this.iosRadioButton);
            this.backPanel.Controls.Add(this.singleRadioButton);
            this.backPanel.Controls.Add(this.gameCollectionLabel);
            this.backPanel.Controls.Add(this.gameName);
            this.backPanel.Controls.Add(this.gameNameLabel);
            this.backPanel.Location = new System.Drawing.Point(255, 165);
            this.backPanel.Margin = new System.Windows.Forms.Padding(4);
            this.backPanel.Name = "backPanel";
            this.backPanel.Size = new System.Drawing.Size(1278, 749);
            this.backPanel.TabIndex = 20;
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(155)))), ((int)(((byte)(213)))));
            this.delete.Font = new System.Drawing.Font("宋体", 12F);
            this.delete.ForeColor = System.Drawing.Color.White;
            this.delete.Location = new System.Drawing.Point(582, 267);
            this.delete.Margin = new System.Windows.Forms.Padding(4);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(150, 60);
            this.delete.TabIndex = 16;
            this.delete.Text = "删除";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // reset
            // 
            this.reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(155)))), ((int)(((byte)(213)))));
            this.reset.Font = new System.Drawing.Font("宋体", 12F);
            this.reset.ForeColor = System.Drawing.Color.White;
            this.reset.Location = new System.Drawing.Point(308, 267);
            this.reset.Margin = new System.Windows.Forms.Padding(4);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(150, 60);
            this.reset.TabIndex = 15;
            this.reset.Text = "重置";
            this.reset.UseVisualStyleBackColor = false;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // onlineRadioButton
            // 
            this.onlineRadioButton.AutoSize = true;
            this.onlineRadioButton.Font = new System.Drawing.Font("宋体", 11F);
            this.onlineRadioButton.Location = new System.Drawing.Point(794, 164);
            this.onlineRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.onlineRadioButton.Name = "onlineRadioButton";
            this.onlineRadioButton.Size = new System.Drawing.Size(123, 26);
            this.onlineRadioButton.TabIndex = 14;
            this.onlineRadioButton.TabStop = true;
            this.onlineRadioButton.Text = "网页游戏";
            this.onlineRadioButton.UseVisualStyleBackColor = true;
            // 
            // androidRadioButton
            // 
            this.androidRadioButton.AutoSize = true;
            this.androidRadioButton.Font = new System.Drawing.Font("宋体", 11F);
            this.androidRadioButton.Location = new System.Drawing.Point(470, 164);
            this.androidRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.androidRadioButton.Name = "androidRadioButton";
            this.androidRadioButton.Size = new System.Drawing.Size(123, 26);
            this.androidRadioButton.TabIndex = 12;
            this.androidRadioButton.TabStop = true;
            this.androidRadioButton.Text = "安卓游戏";
            this.androidRadioButton.UseVisualStyleBackColor = true;
            // 
            // iosRadioButton
            // 
            this.iosRadioButton.AutoSize = true;
            this.iosRadioButton.Font = new System.Drawing.Font("宋体", 11F);
            this.iosRadioButton.Location = new System.Drawing.Point(632, 164);
            this.iosRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.iosRadioButton.Name = "iosRadioButton";
            this.iosRadioButton.Size = new System.Drawing.Size(123, 26);
            this.iosRadioButton.TabIndex = 13;
            this.iosRadioButton.TabStop = true;
            this.iosRadioButton.Text = "苹果游戏";
            this.iosRadioButton.UseVisualStyleBackColor = true;
            // 
            // singleRadioButton
            // 
            this.singleRadioButton.AutoSize = true;
            this.singleRadioButton.Font = new System.Drawing.Font("宋体", 11F);
            this.singleRadioButton.Location = new System.Drawing.Point(308, 164);
            this.singleRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.singleRadioButton.Name = "singleRadioButton";
            this.singleRadioButton.Size = new System.Drawing.Size(123, 26);
            this.singleRadioButton.TabIndex = 11;
            this.singleRadioButton.TabStop = true;
            this.singleRadioButton.Text = "单机游戏";
            this.singleRadioButton.UseVisualStyleBackColor = true;
            // 
            // gameCollectionLabel
            // 
            this.gameCollectionLabel.AutoSize = true;
            this.gameCollectionLabel.Font = new System.Drawing.Font("宋体", 12F);
            this.gameCollectionLabel.Location = new System.Drawing.Point(120, 162);
            this.gameCollectionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gameCollectionLabel.Name = "gameCollectionLabel";
            this.gameCollectionLabel.Size = new System.Drawing.Size(178, 24);
            this.gameCollectionLabel.TabIndex = 10;
            this.gameCollectionLabel.Text = "游戏所属集合：";
            // 
            // gameName
            // 
            this.gameName.Font = new System.Drawing.Font("宋体", 18F);
            this.gameName.Location = new System.Drawing.Point(308, 45);
            this.gameName.Margin = new System.Windows.Forms.Padding(4);
            this.gameName.Name = "gameName";
            this.gameName.Size = new System.Drawing.Size(448, 49);
            this.gameName.TabIndex = 9;
            // 
            // gameNameLabel
            // 
            this.gameNameLabel.AutoSize = true;
            this.gameNameLabel.Font = new System.Drawing.Font("宋体", 12F);
            this.gameNameLabel.Location = new System.Drawing.Point(120, 60);
            this.gameNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gameNameLabel.Name = "gameNameLabel";
            this.gameNameLabel.Size = new System.Drawing.Size(106, 24);
            this.gameNameLabel.TabIndex = 8;
            this.gameNameLabel.Text = "游戏名：";
            // 
            // publishBtn
            // 
            this.publishBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(155)))), ((int)(((byte)(213)))));
            this.publishBtn.Font = new System.Drawing.Font("宋体", 13F);
            this.publishBtn.ForeColor = System.Drawing.Color.White;
            this.publishBtn.Location = new System.Drawing.Point(1324, 75);
            this.publishBtn.Margin = new System.Windows.Forms.Padding(4);
            this.publishBtn.Name = "publishBtn";
            this.publishBtn.Size = new System.Drawing.Size(210, 60);
            this.publishBtn.TabIndex = 15;
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
            this.manageList.Location = new System.Drawing.Point(75, 165);
            this.manageList.Margin = new System.Windows.Forms.Padding(4);
            this.manageList.Name = "manageList";
            this.manageList.Size = new System.Drawing.Size(178, 184);
            this.manageList.TabIndex = 14;
            this.manageList.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.personalList_DrawItem);
            this.manageList.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.personalList_MeasureItem);
            this.manageList.SelectedIndexChanged += new System.EventHandler(this.manageList_SelectedIndexChanged);
            // 
            // iosBtn
            // 
            this.iosBtn.BackColor = System.Drawing.Color.White;
            this.iosBtn.Font = new System.Drawing.Font("宋体", 14F);
            this.iosBtn.Location = new System.Drawing.Point(750, 75);
            this.iosBtn.Margin = new System.Windows.Forms.Padding(4);
            this.iosBtn.Name = "iosBtn";
            this.iosBtn.Size = new System.Drawing.Size(225, 60);
            this.iosBtn.TabIndex = 13;
            this.iosBtn.Text = "苹果游戏";
            this.iosBtn.UseVisualStyleBackColor = false;
            // 
            // androidBtn
            // 
            this.androidBtn.BackColor = System.Drawing.Color.White;
            this.androidBtn.Font = new System.Drawing.Font("宋体", 14F);
            this.androidBtn.Location = new System.Drawing.Point(525, 75);
            this.androidBtn.Margin = new System.Windows.Forms.Padding(4);
            this.androidBtn.Name = "androidBtn";
            this.androidBtn.Size = new System.Drawing.Size(225, 60);
            this.androidBtn.TabIndex = 12;
            this.androidBtn.Text = "安卓游戏";
            this.androidBtn.UseVisualStyleBackColor = false;
            // 
            // singleBtn
            // 
            this.singleBtn.BackColor = System.Drawing.Color.White;
            this.singleBtn.Font = new System.Drawing.Font("宋体", 14F);
            this.singleBtn.Location = new System.Drawing.Point(300, 75);
            this.singleBtn.Margin = new System.Windows.Forms.Padding(4);
            this.singleBtn.Name = "singleBtn";
            this.singleBtn.Size = new System.Drawing.Size(225, 60);
            this.singleBtn.TabIndex = 11;
            this.singleBtn.Text = "单机游戏";
            this.singleBtn.UseVisualStyleBackColor = false;
            // 
            // indexBtn
            // 
            this.indexBtn.BackColor = System.Drawing.Color.White;
            this.indexBtn.Font = new System.Drawing.Font("宋体", 14F);
            this.indexBtn.Location = new System.Drawing.Point(75, 75);
            this.indexBtn.Margin = new System.Windows.Forms.Padding(4);
            this.indexBtn.Name = "indexBtn";
            this.indexBtn.Size = new System.Drawing.Size(225, 60);
            this.indexBtn.TabIndex = 10;
            this.indexBtn.Text = "首页";
            this.indexBtn.UseVisualStyleBackColor = false;
            // 
            // commentPic
            // 
            this.commentPic.Image = global::GameForum.Properties.Resources.u252;
            this.commentPic.Location = new System.Drawing.Point(1618, 84);
            this.commentPic.Margin = new System.Windows.Forms.Padding(4);
            this.commentPic.Name = "commentPic";
            this.commentPic.Size = new System.Drawing.Size(45, 45);
            this.commentPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.commentPic.TabIndex = 18;
            this.commentPic.TabStop = false;
            // 
            // avatar
            // 
            this.avatar.Image = ((System.Drawing.Image)(resources.GetObject("avatar.Image")));
            this.avatar.Location = new System.Drawing.Point(1678, 84);
            this.avatar.Margin = new System.Windows.Forms.Padding(4);
            this.avatar.Name = "avatar";
            this.avatar.Size = new System.Drawing.Size(45, 45);
            this.avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avatar.TabIndex = 17;
            this.avatar.TabStop = false;
            // 
            // collectionPic
            // 
            this.collectionPic.Image = global::GameForum.Properties.Resources.u251;
            this.collectionPic.Location = new System.Drawing.Point(1558, 84);
            this.collectionPic.Margin = new System.Windows.Forms.Padding(4);
            this.collectionPic.Name = "collectionPic";
            this.collectionPic.Size = new System.Drawing.Size(45, 45);
            this.collectionPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.collectionPic.TabIndex = 16;
            this.collectionPic.TabStop = false;
            // 
            // onlineBtn
            // 
            this.onlineBtn.BackColor = System.Drawing.Color.White;
            this.onlineBtn.Font = new System.Drawing.Font("宋体", 14F);
            this.onlineBtn.Location = new System.Drawing.Point(975, 75);
            this.onlineBtn.Margin = new System.Windows.Forms.Padding(4);
            this.onlineBtn.Name = "onlineBtn";
            this.onlineBtn.Size = new System.Drawing.Size(225, 60);
            this.onlineBtn.TabIndex = 20;
            this.onlineBtn.Text = "网页游戏";
            this.onlineBtn.UseVisualStyleBackColor = false;
            // 
            // GameDeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1776, 992);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GameDeleteForm";
            this.Text = "删除游戏 - 游戏管理";
            this.backPanel.ResumeLayout(false);
            this.backPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.commentPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collectionPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

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
        private System.Windows.Forms.Button onlineBtn;
        private System.Windows.Forms.RadioButton onlineRadioButton;
        private System.Windows.Forms.RadioButton androidRadioButton;
        private System.Windows.Forms.RadioButton iosRadioButton;
        private System.Windows.Forms.RadioButton singleRadioButton;
        private System.Windows.Forms.Label gameCollectionLabel;
        private System.Windows.Forms.TextBox gameName;
        private System.Windows.Forms.Label gameNameLabel;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button reset;
    }
}