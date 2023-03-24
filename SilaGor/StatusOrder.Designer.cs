namespace SilaGor
{
    partial class StatusOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatusOrder));
            this.buttonEndOrder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.loginSelect = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonEndOrder
            // 
            this.buttonEndOrder.BackColor = System.Drawing.Color.Transparent;
            this.buttonEndOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEndOrder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonEndOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonEndOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEndOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEndOrder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonEndOrder.Location = new System.Drawing.Point(43, 246);
            this.buttonEndOrder.Name = "buttonEndOrder";
            this.buttonEndOrder.Size = new System.Drawing.Size(453, 84);
            this.buttonEndOrder.TabIndex = 5;
            this.buttonEndOrder.Text = "Завершить заказ";
            this.buttonEndOrder.UseVisualStyleBackColor = false;
            this.buttonEndOrder.Click += new System.EventHandler(this.buttonEndOrder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(48, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(469, 55);
            this.label1.TabIndex = 8;
            this.label1.Text = "Приятной поездки,";
            // 
            // loginSelect
            // 
            this.loginSelect.AutoSize = true;
            this.loginSelect.BackColor = System.Drawing.Color.Transparent;
            this.loginSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginSelect.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loginSelect.Location = new System.Drawing.Point(170, 95);
            this.loginSelect.Name = "loginSelect";
            this.loginSelect.Size = new System.Drawing.Size(255, 55);
            this.loginSelect.TabIndex = 9;
            this.loginSelect.Text = "userName";
            // 
            // StatusOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SilaGor.Properties.Resources.blackGroung;
            this.ClientSize = new System.Drawing.Size(552, 374);
            this.Controls.Add(this.loginSelect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonEndOrder);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "StatusOrder";
            this.Text = "Состояние заказа";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StatusOrder_FormClosed);
            this.Load += new System.EventHandler(this.StatusOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEndOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label loginSelect;
    }
}