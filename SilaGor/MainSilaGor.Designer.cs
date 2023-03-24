namespace SilaGor
{
    partial class MainSilaGor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainSilaGor));
            this.buttonSelect = new System.Windows.Forms.Button();
            this.adressHomeField = new System.Windows.Forms.TextBox();
            this.loginSelect = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addressDestinationField = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonSelect
            // 
            this.buttonSelect.BackColor = System.Drawing.Color.Transparent;
            this.buttonSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSelect.FlatAppearance.BorderSize = 0;
            this.buttonSelect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonSelect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSelect.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSelect.Location = new System.Drawing.Point(142, 646);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(453, 55);
            this.buttonSelect.TabIndex = 2;
            this.buttonSelect.Text = "Заказать такси";
            this.buttonSelect.UseVisualStyleBackColor = false;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // adressHomeField
            // 
            this.adressHomeField.AccessibleName = "";
            this.adressHomeField.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.adressHomeField.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adressHomeField.Location = new System.Drawing.Point(32, 333);
            this.adressHomeField.Name = "adressHomeField";
            this.adressHomeField.Size = new System.Drawing.Size(689, 83);
            this.adressHomeField.TabIndex = 0;
            this.adressHomeField.KeyDown += new System.Windows.Forms.KeyEventHandler(this.adressHomeField_KeyDown);
            // 
            // loginSelect
            // 
            this.loginSelect.AutoSize = true;
            this.loginSelect.BackColor = System.Drawing.Color.Transparent;
            this.loginSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginSelect.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loginSelect.Location = new System.Drawing.Point(282, 122);
            this.loginSelect.Name = "loginSelect";
            this.loginSelect.Size = new System.Drawing.Size(313, 69);
            this.loginSelect.TabIndex = 6;
            this.loginSelect.Text = "userName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(87, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(590, 69);
            this.label1.TabIndex = 7;
            this.label1.Text = "Добро пожаловать,";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(13, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(474, 55);
            this.label2.TabIndex = 8;
            this.label2.Text = "Введите свой адрес";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(13, 447);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(636, 55);
            this.label3.TabIndex = 10;
            this.label3.Text = "Введите адрес назначения";
            // 
            // addressDestinationField
            // 
            this.addressDestinationField.AccessibleName = "";
            this.addressDestinationField.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addressDestinationField.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addressDestinationField.Location = new System.Drawing.Point(32, 523);
            this.addressDestinationField.Name = "addressDestinationField";
            this.addressDestinationField.Size = new System.Drawing.Size(689, 83);
            this.addressDestinationField.TabIndex = 1;
            this.addressDestinationField.KeyDown += new System.Windows.Forms.KeyEventHandler(this.addressDestinationField_KeyDown);
            // 
            // MainSilaGor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SilaGor.Properties.Resources.blackGroung;
            this.ClientSize = new System.Drawing.Size(751, 728);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addressDestinationField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginSelect);
            this.Controls.Add(this.adressHomeField);
            this.Controls.Add(this.buttonSelect);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainSilaGor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сила Гор";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainSilaGor_FormClosed);
            this.Load += new System.EventHandler(this.MainSilaGor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.TextBox adressHomeField;
        private System.Windows.Forms.Label loginSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addressDestinationField;
    }
}