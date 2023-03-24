namespace SilaGor
{
    partial class RegisterDriver
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterDriver));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.registerDriverLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nameDriverField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.surnameDriverField = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AutoLabel = new System.Windows.Forms.Label();
            this.buttonDriverRegister = new System.Windows.Forms.Button();
            this.passDriverField = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.loginDriverField = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoScrollMargin = new System.Drawing.Size(0, 50);
            this.panel1.BackgroundImage = global::SilaGor.Properties.Resources.blackGroung;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.registerDriverLabel);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.nameDriverField);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.surnameDriverField);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.AutoLabel);
            this.panel1.Controls.Add(this.buttonDriverRegister);
            this.panel1.Controls.Add(this.passDriverField);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.loginDriverField);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(768, 667);
            this.panel1.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(206, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(367, 38);
            this.label5.TabIndex = 15;
            this.label5.Text = "Заполните поля ниже";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // registerDriverLabel
            // 
            this.registerDriverLabel.AutoSize = true;
            this.registerDriverLabel.BackColor = System.Drawing.Color.Transparent;
            this.registerDriverLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerDriverLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registerDriverLabel.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.registerDriverLabel.Location = new System.Drawing.Point(275, 965);
            this.registerDriverLabel.Name = "registerDriverLabel";
            this.registerDriverLabel.Size = new System.Drawing.Size(179, 25);
            this.registerDriverLabel.TabIndex = 14;
            this.registerDriverLabel.Text = "Авторизоваться";
            this.registerDriverLabel.Click += new System.EventHandler(this.registerDriverLabel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(127, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 32);
            this.label4.TabIndex = 13;
            this.label4.Text = "Имя";
            // 
            // nameDriverField
            // 
            this.nameDriverField.AccessibleName = "";
            this.nameDriverField.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameDriverField.Location = new System.Drawing.Point(133, 204);
            this.nameDriverField.Name = "nameDriverField";
            this.nameDriverField.Size = new System.Drawing.Size(512, 83);
            this.nameDriverField.TabIndex = 0;
            this.nameDriverField.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nameDriverField_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(127, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 32);
            this.label2.TabIndex = 11;
            this.label2.Text = "Фамилия";
            // 
            // surnameDriverField
            // 
            this.surnameDriverField.AccessibleName = "";
            this.surnameDriverField.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surnameDriverField.Location = new System.Drawing.Point(133, 381);
            this.surnameDriverField.Name = "surnameDriverField";
            this.surnameDriverField.Size = new System.Drawing.Size(512, 83);
            this.surnameDriverField.TabIndex = 1;
            this.surnameDriverField.KeyDown += new System.Windows.Forms.KeyEventHandler(this.surnameDriverField_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(127, 681);
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
            this.label1.Location = new System.Drawing.Point(127, 505);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Логин";
            // 
            // AutoLabel
            // 
            this.AutoLabel.AutoSize = true;
            this.AutoLabel.BackColor = System.Drawing.Color.Transparent;
            this.AutoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AutoLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AutoLabel.Location = new System.Drawing.Point(84, 26);
            this.AutoLabel.Name = "AutoLabel";
            this.AutoLabel.Size = new System.Drawing.Size(621, 55);
            this.AutoLabel.TabIndex = 6;
            this.AutoLabel.Text = "Хотите стать водителем?";
            this.AutoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonDriverRegister
            // 
            this.buttonDriverRegister.BackColor = System.Drawing.Color.Transparent;
            this.buttonDriverRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDriverRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonDriverRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonDriverRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDriverRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDriverRegister.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonDriverRegister.Location = new System.Drawing.Point(187, 869);
            this.buttonDriverRegister.Name = "buttonDriverRegister";
            this.buttonDriverRegister.Size = new System.Drawing.Size(387, 62);
            this.buttonDriverRegister.TabIndex = 4;
            this.buttonDriverRegister.Text = "Зарегистрироваться";
            this.buttonDriverRegister.UseVisualStyleBackColor = false;
            this.buttonDriverRegister.Click += new System.EventHandler(this.buttonDriverRegister_Click);
            // 
            // passDriverField
            // 
            this.passDriverField.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.passDriverField.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passDriverField.Location = new System.Drawing.Point(133, 733);
            this.passDriverField.Name = "passDriverField";
            this.passDriverField.Size = new System.Drawing.Size(512, 83);
            this.passDriverField.TabIndex = 3;
            this.passDriverField.UseSystemPasswordChar = true;
            this.passDriverField.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passDriverField_KeyDown);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.ErrorImage = global::SilaGor.Properties.Resources.user;
            this.pictureBox2.Image = global::SilaGor.Properties.Resources._lock;
            this.pictureBox2.Location = new System.Drawing.Point(34, 733);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(81, 84);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // loginDriverField
            // 
            this.loginDriverField.AccessibleName = "";
            this.loginDriverField.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginDriverField.Location = new System.Drawing.Point(133, 556);
            this.loginDriverField.Name = "loginDriverField";
            this.loginDriverField.Size = new System.Drawing.Size(512, 83);
            this.loginDriverField.TabIndex = 2;
            this.loginDriverField.KeyDown += new System.Windows.Forms.KeyEventHandler(this.loginDriverField_KeyDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.ErrorImage = global::SilaGor.Properties.Resources.user;
            this.pictureBox1.Image = global::SilaGor.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(34, 556);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // RegisterDriver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 667);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RegisterDriver";
            this.Text = "Register";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegisterDriver_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label registerDriverLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nameDriverField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox surnameDriverField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label AutoLabel;
        private System.Windows.Forms.Button buttonDriverRegister;
        private System.Windows.Forms.TextBox passDriverField;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox loginDriverField;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label5;
    }
}