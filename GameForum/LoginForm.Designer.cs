namespace GameForum
{
    partial class LoginForm
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
            this.userPass = new System.Windows.Forms.TextBox();
            this.userPassPic = new System.Windows.Forms.PictureBox();
            this.userNamePic = new System.Windows.Forms.PictureBox();
            this.userName = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.Button();
            this.visitorLogin = new System.Windows.Forms.Button();
            this.toRegister = new System.Windows.Forms.Label();
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
            this.title.TabIndex = 1;
            this.title.Text = "游戏论坛";
            // 
            // userPass
            // 
            this.userPass.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.userPass.Location = new System.Drawing.Point(644, 269);
            this.userPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.userPass.Name = "userPass";
            this.userPass.PasswordChar = '*';
            this.userPass.Size = new System.Drawing.Size(399, 42);
            this.userPass.TabIndex = 6;
            // 
            // userPassPic
            // 
            this.userPassPic.Image = global::GameForum.Properties.Resources.u6;
            this.userPassPic.Location = new System.Drawing.Point(557, 269);
            this.userPassPic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.userPassPic.Name = "userPassPic";
            this.userPassPic.Size = new System.Drawing.Size(47, 44);
            this.userPassPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userPassPic.TabIndex = 8;
            this.userPassPic.TabStop = false;
            // 
            // userNamePic
            // 
            this.userNamePic.Image = global::GameForum.Properties.Resources.u5;
            this.userNamePic.Location = new System.Drawing.Point(557, 188);
            this.userNamePic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.userNamePic.Name = "userNamePic";
            this.userNamePic.Size = new System.Drawing.Size(47, 44);
            this.userNamePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userNamePic.TabIndex = 7;
            this.userNamePic.TabStop = false;
            // 
            // userName
            // 
            this.userName.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.userName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.userName.Location = new System.Drawing.Point(644, 188);
            this.userName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(399, 42);
            this.userName.TabIndex = 5;
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(155)))), ((int)(((byte)(213)))));
            this.login.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.login.ForeColor = System.Drawing.Color.White;
            this.login.Location = new System.Drawing.Point(863, 388);
            this.login.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(133, 50);
            this.login.TabIndex = 10;
            this.login.Text = "登录";
            this.login.UseVisualStyleBackColor = false;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // visitorLogin
            // 
            this.visitorLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(155)))), ((int)(((byte)(213)))));
            this.visitorLogin.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.visitorLogin.ForeColor = System.Drawing.Color.White;
            this.visitorLogin.Location = new System.Drawing.Point(644, 388);
            this.visitorLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.visitorLogin.Name = "visitorLogin";
            this.visitorLogin.Size = new System.Drawing.Size(133, 50);
            this.visitorLogin.TabIndex = 9;
            this.visitorLogin.Text = "游客登录";
            this.visitorLogin.UseVisualStyleBackColor = false;
            this.visitorLogin.Click += new System.EventHandler(this.visitorLogin_Click);
            // 
            // toRegister
            // 
            this.toRegister.AutoSize = true;
            this.toRegister.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toRegister.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toRegister.Location = new System.Drawing.Point(721, 485);
            this.toRegister.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.toRegister.Name = "toRegister";
            this.toRegister.Size = new System.Drawing.Size(202, 24);
            this.toRegister.TabIndex = 11;
            this.toRegister.Text = "没有账号，注册？";
            this.toRegister.Click += new System.EventHandler(this.toRegister_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1540, 826);
            this.Controls.Add(this.toRegister);
            this.Controls.Add(this.login);
            this.Controls.Add(this.visitorLogin);
            this.Controls.Add(this.userPass);
            this.Controls.Add(this.userPassPic);
            this.Controls.Add(this.userNamePic);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.title);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LoginForm";
            this.Text = "登录页面";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginForm_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LoginForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.userPassPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userNamePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.TextBox userPass;
        private System.Windows.Forms.PictureBox userPassPic;
        private System.Windows.Forms.PictureBox userNamePic;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Button visitorLogin;
        private System.Windows.Forms.Label toRegister;
    }
}