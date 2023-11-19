namespace yarıçapı_girilen_dairenin_alanı_va_cevresi
{
    partial class Form1
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
            this.txtYaricap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCevre = new System.Windows.Forms.Label();
            this.lblAlan = new System.Windows.Forms.Label();
            this.btnGoster = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtYaricap
            // 
            this.txtYaricap.Location = new System.Drawing.Point(151, 45);
            this.txtYaricap.Name = "txtYaricap";
            this.txtYaricap.Size = new System.Drawing.Size(100, 20);
            this.txtYaricap.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "yarıçapı giriniz";
            // 
            // lblCevre
            // 
            this.lblCevre.AutoSize = true;
            this.lblCevre.Location = new System.Drawing.Point(56, 117);
            this.lblCevre.Name = "lblCevre";
            this.lblCevre.Size = new System.Drawing.Size(34, 13);
            this.lblCevre.TabIndex = 2;
            this.lblCevre.Text = "çevre";
            // 
            // lblAlan
            // 
            this.lblAlan.AutoSize = true;
            this.lblAlan.Location = new System.Drawing.Point(56, 178);
            this.lblAlan.Name = "lblAlan";
            this.lblAlan.Size = new System.Drawing.Size(27, 13);
            this.lblAlan.TabIndex = 3;
            this.lblAlan.Text = "alan";
            // 
            // btnGoster
            // 
            this.btnGoster.Location = new System.Drawing.Point(14, 208);
            this.btnGoster.Name = "btnGoster";
            this.btnGoster.Size = new System.Drawing.Size(158, 23);
            this.btnGoster.TabIndex = 4;
            this.btnGoster.UseVisualStyleBackColor = true;
            this.btnGoster.Click += new System.EventHandler(this.btnGoster_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(329, 243);
            this.Controls.Add(this.btnGoster);
            this.Controls.Add(this.lblAlan);
            this.Controls.Add(this.lblCevre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtYaricap);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtYaricap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCevre;
        private System.Windows.Forms.Label lblAlan;
        private System.Windows.Forms.Button btnGoster;
    }
}

