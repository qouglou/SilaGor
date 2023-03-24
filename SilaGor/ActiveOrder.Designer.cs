namespace SilaGor
{
    partial class ActiveOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActiveOrder));
            this.label3 = new System.Windows.Forms.Label();
            this.addressDestinationField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.adressHomeField = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nameClient = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(12, 526);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(440, 55);
            this.label3.TabIndex = 17;
            this.label3.Text = "Адрес назначения";
            // 
            // addressDestinationField
            // 
            this.addressDestinationField.AccessibleName = "";
            this.addressDestinationField.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addressDestinationField.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addressDestinationField.Location = new System.Drawing.Point(31, 602);
            this.addressDestinationField.Name = "addressDestinationField";
            this.addressDestinationField.ReadOnly = true;
            this.addressDestinationField.Size = new System.Drawing.Size(689, 83);
            this.addressDestinationField.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(464, 55);
            this.label2.TabIndex = 16;
            this.label2.Text = "Адрес отправления";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(112, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(560, 69);
            this.label1.TabIndex = 15;
            this.label1.Text = "Вы выбрали заказ";
            // 
            // adressHomeField
            // 
            this.adressHomeField.AccessibleName = "";
            this.adressHomeField.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.adressHomeField.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adressHomeField.Location = new System.Drawing.Point(31, 428);
            this.adressHomeField.Name = "adressHomeField";
            this.adressHomeField.ReadOnly = true;
            this.adressHomeField.Size = new System.Drawing.Size(689, 83);
            this.adressHomeField.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(12, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 55);
            this.label4.TabIndex = 19;
            this.label4.Text = "Клиент";
            // 
            // nameClient
            // 
            this.nameClient.AccessibleName = "";
            this.nameClient.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nameClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameClient.Location = new System.Drawing.Point(31, 245);
            this.nameClient.Name = "nameClient";
            this.nameClient.ReadOnly = true;
            this.nameClient.Size = new System.Drawing.Size(689, 83);
            this.nameClient.TabIndex = 18;
            // 
            // ActiveOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SilaGor.Properties.Resources.blackGroung;
            this.ClientSize = new System.Drawing.Size(750, 752);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nameClient);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addressDestinationField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.adressHomeField);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ActiveOrder";
            this.Text = "Активный заказ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ActiveOrder_FormClosed);
            this.Shown += new System.EventHandler(this.ActiveOrder_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addressDestinationField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox adressHomeField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nameClient;
    }
}