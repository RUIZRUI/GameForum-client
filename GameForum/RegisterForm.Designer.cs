namespace GameForum
{
    partial class RegisterForm
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
            this.title = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.TextBox();
            this.reset = new System.Windows.Forms.Button();
            this.userPass = new System.Windows.Forms.TextBox();
            this.userPassCheck = new System.Windows.Forms.TextBox();
            this.userEmail = new System.Windows.Forms.TextBox();
            this.userPhone = new System.Windows.Forms.TextBox();
            this.userPhonePic = new System.Windows.Forms.PictureBox();
            this.userEmailPic = new System.Windows.Forms.PictureBox();
            this.userPassCheckPic = new System.Windows.Forms.PictureBox();
            this.userPassPic = new System.Windows.Forms.PictureBox();
            this.userNamePic = new System.Windows.Forms.PictureBox();
            this.register = new System.Windows.Forms.Button();
            this.toLogin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userPhonePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userEmailPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPassCheckPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPassPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userNamePic)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.title.Location = new System.Drawing.Point(701, 50);
            this.title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(181, 40);
            this.title.TabIndex = 0;
            this.title.Text = "游戏论坛";
            // 
            // userName
            // 
            this.userName.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.userName.Location = new System.Drawing.Point(644, 148);
            this.userName.Margin = new System.Windows.Forms.Padding(4);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(399, 42);
            this.userName.TabIndex = 1;
            // 
            // reset
            // 
            this.reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(155)))), ((int)(((byte)(213)))));
            this.reset.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.reset.ForeColor = System.Drawing.Color.White;
            this.reset.Location = new System.Drawing.Point(644, 594);
            this.reset.Margin = new System.Windows.Forms.Padding(4);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(133, 50);
            this.reset.TabIndex = 6;
            this.reset.Text = "重置";
            this.reset.UseVisualStyleBackColor = false;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // userPass
            // 
            this.userPass.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.userPass.Location = new System.Drawing.Point(644, 229);
            this.userPass.Margin = new System.Windows.Forms.Padding(4);
            this.userPass.Name = "userPass";
            this.userPass.PasswordChar = '*';
            this.userPass.Size = new System.Drawing.Size(399, 42);
            this.userPass.TabIndex = 2;
            // 
            // userPassCheck
            // 
            this.userPassCheck.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.userPassCheck.Location = new System.Drawing.Point(644, 310);
            this.userPassCheck.Margin = new System.Windows.Forms.Padding(4);
            this.userPassCheck.Name = "userPassCheck";
            this.userPassCheck.PasswordChar = '*';
            this.userPassCheck.Size = new System.Drawing.Size(399, 42);
            this.userPassCheck.TabIndex = 3;
            // 
            // userEmail
            // 
            this.userEmail.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.userEmail.Location = new System.Drawing.Point(644, 388);
            this.userEmail.Margin = new System.Windows.Forms.Padding(4);
            this.userEmail.Name = "userEmail";
            this.userEmail.Size = new System.Drawing.Size(399, 42);
            this.userEmail.TabIndex = 4;
            // 
            // userPhone
            // 
            this.userPhone.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.userPhone.Location = new System.Drawing.Point(644, 469);
            this.userPhone.Margin = new System.Windows.Forms.Padding(4);
            this.userPhone.Name = "userPhone";
            this.userPhone.Size = new System.Drawing.Size(399, 42);
            this.userPhone.TabIndex = 5;
            // 
            // userPhonePic
            // 
            this.userPhonePic.Image = global::GameForum.Properties.Resources.u26;
            this.userPhonePic.Location = new System.Drawing.Point(557, 469);
            this.userPhonePic.Margin = new System.Windows.Forms.Padding(4);
            this.userPhonePic.Name = "userPhonePic";
            this.userPhonePic.Size = new System.Drawing.Size(47, 44);
            this.userPhonePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userPhonePic.TabIndex = 9;
            this.userPhonePic.TabStop = false;
            // 
            // userEmailPic
            // 
            this.userEmailPic.Image = global::GameForum.Properties.Resources.u31;
            this.userEmailPic.Location = new System.Drawing.Point(557, 388);
            this.userEmailPic.Margin = new System.Windows.Forms.Padding(4);
            this.userEmailPic.Name = "userEmailPic";
            this.userEmailPic.Size = new System.Drawing.Size(47, 44);
            this.userEmailPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userEmailPic.TabIndex = 8;
            this.userEmailPic.TabStop = false;
            // 
            // userPassCheckPic
            // 
            this.userPassCheckPic.Image = global::GameForum.Properties.Resources.u21;
            this.userPassCheckPic.Location = new System.Drawing.Point(557, 310);
            this.userPassCheckPic.Margin = new System.Windows.Forms.Padding(4);
            this.userPassCheckPic.Name = "userPassCheckPic";
            this.userPassCheckPic.Size = new System.Drawing.Size(47, 44);
            this.userPassCheckPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userPassCheckPic.TabIndex = 6;
            this.userPassCheckPic.TabStop = false;
            // 
            // userPassPic
            // 
            this.userPassPic.Image = global::GameForum.Properties.Resources.u6;
            this.userPassPic.Location = new System.Drawing.Point(557, 229);
            this.userPassPic.Margin = new System.Windows.Forms.Padding(4);
            this.userPassPic.Name = "userPassPic";
            this.userPassPic.Size = new System.Drawing.Size(47, 44);
            this.userPassPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userPassPic.TabIndex = 4;
            this.userPassPic.TabStop = false;
            // 
            // userNamePic
            // 
            this.userNamePic.Image = global::GameForum.Properties.Resources.u5;
            this.userNamePic.Location = new System.Drawing.Point(557, 148);
            this.userNamePic.Margin = new System.Windows.Forms.Padding(4);
            this.userNamePic.Name = "userNamePic";
            this.userNamePic.Size = new System.Drawing.Size(47, 44);
            this.userNamePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userNamePic.TabIndex = 3;
            this.userNamePic.TabStop = false;
            // 
            // register
            // 
            this.register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(155)))), ((int)(((byte)(213)))));
            this.register.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.register.ForeColor = System.Drawing.Color.White;
            this.register.Location = new System.Drawing.Point(863, 594);
            this.register.Margin = new System.Windows.Forms.Padding(4);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(133, 50);
            this.register.TabIndex = 7;
            this.register.Text = "注册";
            this.register.UseVisualStyleBackColor = false;
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // toLogin
            // 
            this.toLogin.AutoSize = true;
            this.toLogin.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toLogin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toLogin.Location = new System.Drawing.Point(721, 691);
            this.toLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.toLogin.Name = "toLogin";
            this.toLogin.Size = new System.Drawing.Size(202, 24);
            this.toLogin.TabIndex = 10;
            this.toLogin.Text = "已有账号，登录？";
            this.toLogin.Click += new System.EventHandler(this.toLogin_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1579, 826);
            this.Controls.Add(this.toLogin);
            this.Controls.Add(this.register);
            this.Controls.Add(this.userPhone);
            this.Controls.Add(this.userEmail);
            this.Controls.Add(this.userPhonePic);
            this.Controls.Add(this.userEmailPic);
            this.Controls.Add(this.userPassCheck);
            this.Controls.Add(this.userPassCheckPic);
            this.Controls.Add(this.userPass);
            this.Controls.Add(this.userPassPic);
            this.Controls.Add(this.userNamePic);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.title);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RegisterForm";
            this.Text = "注册页面";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RegisterForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.userPhonePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userEmailPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPassCheckPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPassPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userNamePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.PictureBox userNamePic;
        private System.Windows.Forms.PictureBox userPassPic;
        private System.Windows.Forms.TextBox userPass;
        private System.Windows.Forms.PictureBox userPassCheckPic;
        private System.Windows.Forms.TextBox userPassCheck;
        private System.Windows.Forms.PictureBox userEmailPic;
        private System.Windows.Forms.PictureBox userPhonePic;
        private System.Windows.Forms.TextBox userEmail;
        private System.Windows.Forms.TextBox userPhone;
        private System.Windows.Forms.Button register;
        private System.Windows.Forms.Label toLogin;
    }
}