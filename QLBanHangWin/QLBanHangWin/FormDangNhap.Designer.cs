namespace QLBanHangWin
{
    partial class FormDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDangNhap));
            this.btnLogin = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.lb1 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lberror = new System.Windows.Forms.Label();
            this.cbShowPass = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Location = new System.Drawing.Point(170, 227);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(160, 43);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.Color.Red;
            this.Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel.ForeColor = System.Drawing.Color.White;
            this.Cancel.Location = new System.Drawing.Point(669, 12);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(26, 26);
            this.Cancel.TabIndex = 1;
            this.Cancel.Text = "X";
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.Location = new System.Drawing.Point(66, 107);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(131, 25);
            this.lb1.TabIndex = 2;
            this.lb1.Text = "Tên tài khoản";
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(209, 104);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(209, 30);
            this.txtUserName.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(458, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 254);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // txtPassWord
            // 
            this.txtPassWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassWord.Location = new System.Drawing.Point(209, 163);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.PasswordChar = '*';
            this.txtPassWord.Size = new System.Drawing.Size(209, 30);
            this.txtPassWord.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mật khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(175, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 31);
            this.label2.TabIndex = 8;
            this.label2.Text = "ĐĂNG NHẬP";
            // 
            // lberror
            // 
            this.lberror.AutoSize = true;
            this.lberror.BackColor = System.Drawing.Color.Transparent;
            this.lberror.ForeColor = System.Drawing.Color.Red;
            this.lberror.Location = new System.Drawing.Point(206, 77);
            this.lberror.Name = "lberror";
            this.lberror.Size = new System.Drawing.Size(161, 13);
            this.lberror.TabIndex = 10;
            this.lberror.Text = "Sai mật khẩu hoặc tên tài khoản";
            this.lberror.Visible = false;
            // 
            // cbShowPass
            // 
            this.cbShowPass.AutoSize = true;
            this.cbShowPass.Location = new System.Drawing.Point(209, 204);
            this.cbShowPass.Name = "cbShowPass";
            this.cbShowPass.Size = new System.Drawing.Size(109, 17);
            this.cbShowPass.TabIndex = 11;
            this.cbShowPass.Text = "Hiển thị mật khẩu";
            this.cbShowPass.UseVisualStyleBackColor = true;
            this.cbShowPass.CheckedChanged += new System.EventHandler(this.cbShowPass_CheckedChanged);
            // 
            // FormDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(707, 341);
            this.ControlBox = false;
            this.Controls.Add(this.cbShowPass);
            this.Controls.Add(this.lberror);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPassWord);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.btnLogin);
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Name = "FormDangNhap";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtPassWord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lberror;
        private System.Windows.Forms.CheckBox cbShowPass;
    }
}