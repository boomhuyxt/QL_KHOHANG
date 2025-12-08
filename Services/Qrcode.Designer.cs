namespace QL_KHO_HANG.Services
{
    partial class Qrcode
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
            this.btnGenerateQR = new System.Windows.Forms.Button();
            this.picQR = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picQR)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerateQR
            // 
            this.btnGenerateQR.Location = new System.Drawing.Point(347, 398);
            this.btnGenerateQR.Name = "btnGenerateQR";
            this.btnGenerateQR.Size = new System.Drawing.Size(75, 43);
            this.btnGenerateQR.TabIndex = 0;
            this.btnGenerateQR.Text = "button1";
            this.btnGenerateQR.UseVisualStyleBackColor = true;
            this.btnGenerateQR.Click += new System.EventHandler(this.button1_Click);
            // 
            // picQR
            // 
            this.picQR.Location = new System.Drawing.Point(55, 12);
            this.picQR.Name = "picQR";
            this.picQR.Size = new System.Drawing.Size(657, 333);
            this.picQR.TabIndex = 1;
            this.picQR.TabStop = false;
            // 
            // Qrcode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 487);
            this.Controls.Add(this.picQR);
            this.Controls.Add(this.btnGenerateQR);
            this.Name = "Qrcode";
            this.Text = "Qrcode";
            ((System.ComponentModel.ISupportInitialize)(this.picQR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenerateQR;
        private System.Windows.Forms.PictureBox picQR;
    }
}