using System.Drawing;
using System.Windows.Forms;

namespace GameForum
{
    partial class PersonalCenterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonalCenterForm));
            this.personalList = new System.Windows.Forms.ListBox();
            this.backPanel = new System.Windows.Forms.Panel();
            this.editInformation = new System.Windows.Forms.Label();
            this.userJoinTime = new System.Windows.Forms.Label();
            this.userBirthday = new System.Windows.Forms.Label();
            this.userSex = new System.Windows.Forms.Label();
            this.userPhone = new System.Windows.Forms.Label();
            this.userEmail = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.changeAvatar = new System.Windows.Forms.Label();
            this.fansNum = new System.Windows.Forms.Label();
            this.focusNum = new System.Windows.Forms.Label();
            this.userId = new System.Windows.Forms.Label();
            this.avatar = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.returnImg = new System.Windows.Forms.PictureBox();
            this.backPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnImg)).BeginInit();
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
            this.personalList.Location = new System.Drawing.Point(133, 62);
            this.personalList.Margin = new System.Windows.Forms.Padding(4);
            this.personalList.Name = "personalList";
            this.personalList.Size = new System.Drawing.Size(199, 255);
            this.personalList.TabIndex = 0;
            this.personalList.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.personalList_DrawItem);
            this.personalList.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.personalList_MeasureItem);
            this.personalList.SelectedIndexChanged += new System.EventHandler(this.personalList_SelectedIndexChanged);
            // 
            // backPanel
            // 
            this.backPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.backPanel.Controls.Add(this.editInformation);
            this.backPanel.Controls.Add(this.userJoinTime);
            this.backPanel.Controls.Add(this.userBirthday);
            this.backPanel.Controls.Add(this.userSex);
            this.backPanel.Controls.Add(this.userPhone);
            this.backPanel.Controls.Add(this.userEmail);
            this.backPanel.Controls.Add(this.userName);
            this.backPanel.Controls.Add(this.panel2);
            this.backPanel.Controls.Add(this.changeAvatar);
            this.backPanel.Controls.Add(this.fansNum);
            this.backPanel.Controls.Add(this.focusNum);
            this.backPanel.Controls.Add(this.userId);
            this.backPanel.Controls.Add(this.avatar);
            this.backPanel.Controls.Add(this.panel1);
            this.backPanel.Controls.Add(this.title);
            this.backPanel.Location = new System.Drawing.Point(333, 62);
            this.backPanel.Margin = new System.Windows.Forms.Padding(4);
            this.backPanel.Name = "backPanel";
            this.backPanel.Size = new System.Drawing.Size(1026, 624);
            this.backPanel.TabIndex = 1;
            // 
            // editInformation
            // 
            this.editInformation.AutoSize = true;
            this.editInformation.Font = new System.Drawing.Font("宋体", 12F);
            this.editInformation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(234)))));
            this.editInformation.Location = new System.Drawing.Point(888, 285);
            this.editInformation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.editInformation.Name = "editInformation";
            this.editInformation.Size = new System.Drawing.Size(89, 20);
            this.editInformation.TabIndex = 14;
            this.editInformation.Text = "修改资料";
            this.editInformation.Click += new System.EventHandler(this.editInformation_Click);
            // 
            // userJoinTime
            // 
            this.userJoinTime.AutoSize = true;
            this.userJoinTime.Font = new System.Drawing.Font("宋体", 12F);
            this.userJoinTime.Location = new System.Drawing.Point(207, 560);
            this.userJoinTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userJoinTime.Name = "userJoinTime";
            this.userJoinTime.Size = new System.Drawing.Size(299, 20);
            this.userJoinTime.TabIndex = 13;
            this.userJoinTime.Text = "入坑时间：2020-06-06 00:25:34";
            // 
            // userBirthday
            // 
            this.userBirthday.AutoSize = true;
            this.userBirthday.Font = new System.Drawing.Font("宋体", 12F);
            this.userBirthday.Location = new System.Drawing.Point(207, 505);
            this.userBirthday.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userBirthday.Name = "userBirthday";
            this.userBirthday.Size = new System.Drawing.Size(169, 20);
            this.userBirthday.TabIndex = 12;
            this.userBirthday.Text = "生日：1999-04-22";
            // 
            // userSex
            // 
            this.userSex.AutoSize = true;
            this.userSex.Font = new System.Drawing.Font("宋体", 12F);
            this.userSex.Location = new System.Drawing.Point(207, 450);
            this.userSex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userSex.Name = "userSex";
            this.userSex.Size = new System.Drawing.Size(89, 20);
            this.userSex.TabIndex = 11;
            this.userSex.Text = "性别：男";
            // 
            // userPhone
            // 
            this.userPhone.AutoSize = true;
            this.userPhone.Font = new System.Drawing.Font("宋体", 12F);
            this.userPhone.Location = new System.Drawing.Point(207, 395);
            this.userPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userPhone.Name = "userPhone";
            this.userPhone.Size = new System.Drawing.Size(199, 20);
            this.userPhone.TabIndex = 10;
            this.userPhone.Text = "手机号：19818965587";
            // 
            // userEmail
            // 
            this.userEmail.AutoSize = true;
            this.userEmail.Font = new System.Drawing.Font("宋体", 12F);
            this.userEmail.Location = new System.Drawing.Point(207, 340);
            this.userEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userEmail.Name = "userEmail";
            this.userEmail.Size = new System.Drawing.Size(309, 20);
            this.userEmail.TabIndex = 9;
            this.userEmail.Text = "邮箱：zhengxiang4056@gmail.com";
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.userName.Location = new System.Drawing.Point(207, 285);
            this.userName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(119, 20);
            this.userName.TabIndex = 8;
            this.userName.Text = "昵称：qixqi";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(187, 262);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(797, 1);
            this.panel2.TabIndex = 7;
            // 
            // changeAvatar
            // 
            this.changeAvatar.AutoSize = true;
            this.changeAvatar.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.changeAvatar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(234)))));
            this.changeAvatar.Location = new System.Drawing.Point(67, 262);
            this.changeAvatar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.changeAvatar.Name = "changeAvatar";
            this.changeAvatar.Size = new System.Drawing.Size(89, 20);
            this.changeAvatar.TabIndex = 6;
            this.changeAvatar.Text = "修改头像";
            this.changeAvatar.Click += new System.EventHandler(this.changeAvatar_Click);
            // 
            // fansNum
            // 
            this.fansNum.AutoSize = true;
            this.fansNum.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.fansNum.Location = new System.Drawing.Point(313, 204);
            this.fansNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fansNum.Name = "fansNum";
            this.fansNum.Size = new System.Drawing.Size(79, 20);
            this.fansNum.TabIndex = 5;
            this.fansNum.Text = "粉丝：5";
            // 
            // focusNum
            // 
            this.focusNum.AutoSize = true;
            this.focusNum.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.focusNum.Location = new System.Drawing.Point(207, 204);
            this.focusNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.focusNum.Name = "focusNum";
            this.focusNum.Size = new System.Drawing.Size(79, 20);
            this.focusNum.TabIndex = 4;
            this.focusNum.Text = "关注：5";
            // 
            // userId
            // 
            this.userId.AutoSize = true;
            this.userId.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.userId.Location = new System.Drawing.Point(207, 155);
            this.userId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userId.Name = "userId";
            this.userId.Size = new System.Drawing.Size(139, 20);
            this.userId.TabIndex = 3;
            this.userId.Text = "ID: 201792179";
            // 
            // avatar
            // 
            this.avatar.Image = ((System.Drawing.Image)(resources.GetObject("avatar.Image")));
            this.avatar.Location = new System.Drawing.Point(51, 125);
            this.avatar.Margin = new System.Windows.Forms.Padding(4);
            this.avatar.Name = "avatar";
            this.avatar.Size = new System.Drawing.Size(133, 125);
            this.avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avatar.TabIndex = 2;
            this.avatar.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(51, 90);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 1);
            this.panel1.TabIndex = 1;
            // 
            // title
            // 
            this.title.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.title.Location = new System.Drawing.Point(51, 34);
            this.title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(120, 30);
            this.title.TabIndex = 0;
            this.title.Text = "个人资料";
            // 
            // returnImg
            // 
            this.returnImg.Image = global::GameForum.Properties.Resources.u555;
            this.returnImg.Location = new System.Drawing.Point(25, 62);
            this.returnImg.Margin = new System.Windows.Forms.Padding(4);
            this.returnImg.Name = "returnImg";
            this.returnImg.Size = new System.Drawing.Size(107, 100);
            this.returnImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.returnImg.TabIndex = 61;
            this.returnImg.TabStop = false;
            this.returnImg.Click += new System.EventHandler(this.returnImg_Click);
            // 
            // PersonalCenterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1579, 826);
            this.Controls.Add(this.returnImg);
            this.Controls.Add(this.backPanel);
            this.Controls.Add(this.personalList);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PersonalCenterForm";
            this.Text = "个人中心";
            this.backPanel.ResumeLayout(false);
            this.backPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox personalList;
        private Panel backPanel;
        private Label title;
        private PictureBox avatar;
        private Label fansNum;
        private Label focusNum;
        private Label userId;
        private Label changeAvatar;
        private Panel panel2;
        private Label userName;
        private Label userEmail;
        private Label userPhone;
        private Label userBirthday;
        private Label userSex;
        private Label userJoinTime;
        private Label editInformation;
        private Panel panel1;
        private PictureBox returnImg;
    }
}