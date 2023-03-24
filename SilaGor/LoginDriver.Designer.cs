namespace SilaGor
{
    partial class LoginDriver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginDriver));
            this.panel1 = new System.Windows.Forms.Panel();
            this.registerDriverLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AutoLabel = new System.Windows.Forms.Label();
            this.buttonDriverLogin = new System.Windows.Forms.Button();
            this.driverPassField = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.driverLoginField = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::SilaGor.Properties.Resources.blackGroung;
            this.panel1.Controls.Add(this.registerDriverLabel);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.AutoLabel);
            this.panel1.Controls.Add(this.buttonDriverLogin);
            this.panel1.Controls.Add(this.driverPassField);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.driverLoginField);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(675, 662);
            this.panel1.TabIndex = 1;
            // 
            // registerDriverLabel
            // 
            this.registerDriverLabel.AutoSize = true;
            this.registerDriverLabel.BackColor = System.Drawing.Color.Transparent;
            this.registerDriverLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerDriverLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registerDriverLabel.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.registerDriverLabel.Location = new System.Drawing.Point(240, 606);
            this.registerDriverLabel.Name = "registerDriverLabel";
            this.registerDriverLabel.Size = new System.Drawing.Size(196, 25);
            this.registerDriverLabel.TabIndex = 10;
            this.registerDriverLabel.Text = "Стать водителем";
            this.registerDriverLabel.Click += new System.EventHandler(this.registerDriverLabel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(127, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 32);
            this.label3.TabIndex = 9;
            this.label3.Text = "Пароль";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(127, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Логин";
            // 
            // AutoLabel
            // 
            this.AutoLabel.AutoSize = true;
            this.AutoLabel.BackColor = System.Drawing.Color.Transparent;
            this.AutoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AutoLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AutoLabel.Location = new System.Drawing.Point(62, 39);
            this.AutoLabel.Name = "AutoLabel";
            this.AutoLabel.Size = new System.Drawing.Size(563, 69);
            this.AutoLabel.TabIndex = 6;
            this.AutoLabel.Text = "Войдите в аккаунт";
            this.AutoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonDriverLogin
            // 
            this.buttonDriverLogin.BackColor = System.Drawing.Color.Transparent;
            this.buttonDriverLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDriverLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonDriverLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonDriverLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDriverLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDriverLogin.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonDriverLogin.Location = new System.Drawing.Point(188, 501);
            this.buttonDriverLogin.Name = "buttonDriverLogin";
            this.buttonDriverLogin.Size = new System.Drawing.Size(308, 62);
            this.buttonDriverLogin.TabIndex = 2;
            this.buttonDriverLogin.Text = "Войти";
            this.buttonDriverLogin.UseVisualStyleBackColor = false;
            this.buttonDriverLogin.Click += new System.EventHandler(this.buttonDriverLogin_Click);
            // 
            // driverPassField
            // 
            this.driverPassField.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.driverPassField.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.driverPassField.Location = new System.Drawing.Point(133, 377);
            this.driverPassField.Name = "driverPassField";
            this.driverPassField.Size = new System.Drawing.Size(492, 83);
            this.driverPassField.TabIndex = 1;
            this.driverPassField.UseSystemPasswordChar = true;
            this.driverPassField.KeyDown += new System.Windows.Forms.KeyEventHandler(this.driverPassField_KeyDown);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.ErrorImage = global::SilaGor.Properties.Resources.user;
            this.pictureBox2.Image = global::SilaGor.Properties.Resources._lock;
            this.pictureBox2.Location = new System.Drawing.Point(34, 377);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(81, 84);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // driverLoginField
            // 
            this.driverLoginField.AccessibleName = "";
            this.driverLoginField.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.driverLoginField.Location = new System.Drawing.Point(133, 200);
            this.driverLoginField.Name = "driverLoginField";
            this.driverLoginField.Size = new System.Drawing.Size(492, 83);
            this.driverLoginField.TabIndex = 0;
            this.driverLoginField.KeyDown += new System.Windows.Forms.KeyEventHandler(this.driverLoginField_KeyDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.ErrorImage = global::SilaGor.Properties.Resources.user;
            this.pictureBox1.Image = global::SilaGor.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(34, 200);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // TaxiLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 662);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TaxiLogin";
            this.Text = "Driver Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TaxiLogin_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label registerDriverLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label AutoLabel;
        private System.Windows.Forms.Button buttonDriverLogin;
        private System.Windows.Forms.TextBox driverPassField;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox driverLoginField;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}