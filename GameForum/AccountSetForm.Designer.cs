using System.Drawing;
using System.Windows.Forms;

namespace GameForum
{
    partial class AccountSetForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountSetForm));
            this.personalList = new System.Windows.Forms.ListBox();
            this.backPanel = new System.Windows.Forms.Panel();
            this.confirm = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.female = new System.Windows.Forms.RadioButton();
            this.male = new System.Windows.Forms.RadioButton();
            this.userEmail = new System.Windows.Forms.TextBox();
            this.userPhone = new System.Windows.Forms.TextBox();
            this.userJoinTime = new System.Windows.Forms.TextBox();
            this.userBirthday = new System.Windows.Forms.TextBox();
            this.userName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.userJoinTimeLabel = new System.Windows.Forms.Label();
            this.userBirthdayLabel = new System.Windows.Forms.Label();
            this.userSexLabel = new System.Windows.Forms.Label();
            this.userPhoneLabel = new System.Windows.Forms.Label();
            this.userEmailLabel = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.changeAvatar = new System.Windows.Forms.Label();
            this.fansNum = new System.Windows.Forms.Label();
            this.focusNum = new System.Windows.Forms.Label();
            this.userId = new System.Windows.Forms.Label();
            this.avatar = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.backPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).BeginInit();
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
            this.personalList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.personalList.Name = "personalList";
            this.personalList.Size = new System.Drawing.Size(199, 255);
            this.personalList.TabIndex = 0;
            this.personalList.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.personalList_DrawItem);
            this.personalList.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.personalList_MeasureItem);
            // 
            // backPanel
            // 
            this.backPanel.AutoScroll = true;
            this.backPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.backPanel.Controls.Add(this.confirm);
            this.backPanel.Controls.Add(this.cancel);
            this.backPanel.Controls.Add(this.female);
            this.backPanel.Controls.Add(this.male);
            this.backPanel.Controls.Add(this.userEmail);
            this.backPanel.Controls.Add(this.userPhone);
            this.backPanel.Controls.Add(this.userJoinTime);
            this.backPanel.Controls.Add(this.userBirthday);
            this.backPanel.Controls.Add(this.userName);
            this.backPanel.Controls.Add(this.label1);
            this.backPanel.Controls.Add(this.userJoinTimeLabel);
            this.backPanel.Controls.Add(this.userBirthdayLabel);
            this.backPanel.Controls.Add(this.userSexLabel);
            this.backPanel.Controls.Add(this.userPhoneLabel);
            this.backPanel.Controls.Add(this.userEmailLabel);
            this.backPanel.Controls.Add(this.userNameLabel);
            this.backPanel.Controls.Add(this.panel2);
            this.backPanel.Controls.Add(this.changeAvatar);
            this.backPanel.Controls.Add(this.fansNum);
            this.backPanel.Controls.Add(this.focusNum);
            this.backPanel.Controls.Add(this.userId);
            this.backPanel.Controls.Add(this.avatar);
            this.backPanel.Controls.Add(this.panel1);
            this.backPanel.Controls.Add(this.title);
            this.backPanel.Location = new System.Drawing.Point(333, 62);
            this.backPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.backPanel.Name = "backPanel";
            this.backPanel.Size = new System.Drawing.Size(1026, 624);
            this.backPanel.TabIndex = 1;
            // 
            // confirm
            // 
            this.confirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(155)))), ((int)(((byte)(213)))));
            this.confirm.Font = new System.Drawing.Font("宋体", 11F);
            this.confirm.ForeColor = System.Drawing.Color.White;
            this.confirm.Location = new System.Drawing.Point(479, 706);
            this.confirm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(107, 44);
            this.confirm.TabIndex = 23;
            this.confirm.Text = "确定";
            this.confirm.UseVisualStyleBackColor = false;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(155)))), ((int)(((byte)(213)))));
            this.cancel.Font = new System.Drawing.Font("宋体", 11F);
            this.cancel.ForeColor = System.Drawing.Color.White;
            this.cancel.Location = new System.Drawing.Point(313, 706);
            this.cancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(107, 44);
            this.cancel.TabIndex = 22;
            this.cancel.Text = "取消";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.Font = new System.Drawing.Font("宋体", 11F);
            this.female.Location = new System.Drawing.Point(417, 488);
            this.female.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(49, 23);
            this.female.TabIndex = 21;
            this.female.TabStop = true;
            this.female.Text = "女";
            this.female.UseVisualStyleBackColor = true;
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.Checked = true;
            this.male.Font = new System.Drawing.Font("宋体", 11F);
            this.male.Location = new System.Drawing.Point(313, 488);
            this.male.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(49, 23);
            this.male.TabIndex = 20;
            this.male.TabStop = true;
            this.male.Text = "男";
            this.male.UseVisualStyleBackColor = true;
            // 
            // userEmail
            // 
            this.userEmail.Font = new System.Drawing.Font("宋体", 15F);
            this.userEmail.Location = new System.Drawing.Point(313, 344);
            this.userEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.userEmail.Name = "userEmail";
            this.userEmail.Size = new System.Drawing.Size(332, 36);
            this.userEmail.TabIndex = 19;
            this.userEmail.Text = "zhengxiang4056@gmail.com";
            // 
            // userPhone
            // 
            this.userPhone.Font = new System.Drawing.Font("宋体", 15F);
            this.userPhone.Location = new System.Drawing.Point(313, 411);
            this.userPhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.userPhone.Name = "userPhone";
            this.userPhone.Size = new System.Drawing.Size(332, 36);
            this.userPhone.TabIndex = 18;
            this.userPhone.Text = "19818965587";
            // 
            // userJoinTime
            // 
            this.userJoinTime.Enabled = false;
            this.userJoinTime.Font = new System.Drawing.Font("宋体", 15F);
            this.userJoinTime.Location = new System.Drawing.Point(313, 614);
            this.userJoinTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.userJoinTime.Name = "userJoinTime";
            this.userJoinTime.Size = new System.Drawing.Size(332, 36);
            this.userJoinTime.TabIndex = 17;
            this.userJoinTime.Text = "2020-06-06  00:25:34";
            // 
            // userBirthday
            // 
            this.userBirthday.Font = new System.Drawing.Font("宋体", 15F);
            this.userBirthday.Location = new System.Drawing.Point(313, 545);
            this.userBirthday.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.userBirthday.Name = "userBirthday";
            this.userBirthday.Size = new System.Drawing.Size(332, 36);
            this.userBirthday.TabIndex = 16;
            this.userBirthday.Text = "1999-04-22";
            // 
            // userName
            // 
            this.userName.Font = new System.Drawing.Font("宋体", 15F);
            this.userName.Location = new System.Drawing.Point(313, 276);
            this.userName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(332, 36);
            this.userName.TabIndex = 15;
            this.userName.Text = "qixqi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(234)))));
            this.label1.Location = new System.Drawing.Point(888, 285);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "修改资料";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // userJoinTimeLabel
            // 
            this.userJoinTimeLabel.AutoSize = true;
            this.userJoinTimeLabel.Font = new System.Drawing.Font("宋体", 12F);
            this.userJoinTimeLabel.Location = new System.Drawing.Point(207, 622);
            this.userJoinTimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userJoinTimeLabel.Name = "userJoinTimeLabel";
            this.userJoinTimeLabel.Size = new System.Drawing.Size(109, 20);
            this.userJoinTimeLabel.TabIndex = 13;
            this.userJoinTimeLabel.Text = "入坑时间：";
            // 
            // userBirthdayLabel
            // 
            this.userBirthdayLabel.AutoSize = true;
            this.userBirthdayLabel.Font = new System.Drawing.Font("宋体", 12F);
            this.userBirthdayLabel.Location = new System.Drawing.Point(207, 555);
            this.userBirthdayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userBirthdayLabel.Name = "userBirthdayLabel";
            this.userBirthdayLabel.Size = new System.Drawing.Size(69, 20);
            this.userBirthdayLabel.TabIndex = 12;
            this.userBirthdayLabel.Text = "生日：";
            // 
            // userSexLabel
            // 
            this.userSexLabel.AutoSize = true;
            this.userSexLabel.Font = new System.Drawing.Font("宋体", 12F);
            this.userSexLabel.Location = new System.Drawing.Point(207, 488);
            this.userSexLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userSexLabel.Name = "userSexLabel";
            this.userSexLabel.Size = new System.Drawing.Size(69, 20);
            this.userSexLabel.TabIndex = 11;
            this.userSexLabel.Text = "性别：";
            // 
            // userPhoneLabel
            // 
            this.userPhoneLabel.AutoSize = true;
            this.userPhoneLabel.Font = new System.Drawing.Font("宋体", 12F);
            this.userPhoneLabel.Location = new System.Drawing.Point(207, 420);
            this.userPhoneLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userPhoneLabel.Name = "userPhoneLabel";
            this.userPhoneLabel.Size = new System.Drawing.Size(89, 20);
            this.userPhoneLabel.TabIndex = 10;
            this.userPhoneLabel.Text = "手机号：";
            // 
            // userEmailLabel
            // 
            this.userEmailLabel.AutoSize = true;
            this.userEmailLabel.Font = new System.Drawing.Font("宋体", 12F);
            this.userEmailLabel.Location = new System.Drawing.Point(207, 352);
            this.userEmailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userEmailLabel.Name = "userEmailLabel";
            this.userEmailLabel.Size = new System.Drawing.Size(69, 20);
            this.userEmailLabel.TabIndex = 9;
            this.userEmailLabel.Text = "邮箱：";
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.userNameLabel.Location = new System.Drawing.Point(207, 285);
            this.userNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(69, 20);
            this.userNameLabel.TabIndex = 8;
            this.userNameLabel.Text = "昵称：";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(187, 262);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.avatar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            // AccountSetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1579, 826);
            this.Controls.Add(this.backPanel);
            this.Controls.Add(this.personalList);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AccountSetForm";
            this.Text = "账号设置 - 个人资料";
            this.backPanel.ResumeLayout(false);
            this.backPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).EndInit();
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
        private Label userNameLabel;
        private Label userEmailLabel;
        private Label userPhoneLabel;
        private Label userBirthdayLabel;
        private Label userSexLabel;
        private Label userJoinTimeLabel;
        private Label label1;
        private Panel panel1;
        private TextBox userEmail;
        private TextBox userPhone;
        private TextBox userJoinTime;
        private TextBox userBirthday;
        private TextBox userName;
        private RadioButton female;
        private RadioButton male;
        private Button confirm;
        private Button cancel;
    }
}