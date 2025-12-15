namespace QL_KHO_HANG.Services
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
        /// <param name="disposing">
        /// true if managed resources should be disposed; otherwise, false.
        /// </param>
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtID1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnQRCode = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnBarCode = new System.Windows.Forms.Button();
            this.btnQRandBar = new System.Windows.Forms.Button();
            this.txtID2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();

            // textBox1
            this.textBox1.BackColor = System.Drawing.Color.YellowGreen;
            this.textBox1.Font = new System.Drawing.Font(
                "Monotype Corsiva",
                26F,
                System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic,
                System.Drawing.GraphicsUnit.Point,
                ((byte)(0))
            );
            this.textBox1.Location = new System.Drawing.Point(166, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(460, 66);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Tạo QRcode + Barcode";

            // txtID1
            this.txtID1.Location = new System.Drawing.Point(12, 89);
            this.txtID1.Name = "txtID1";
            this.txtID1.Size = new System.Drawing.Size(300, 26);
            this.txtID1.TabIndex = 1;
            this.txtID1.Text = "ID 1:";

            // pictureBox1
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 138);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 300);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;

            // btnQRCode
            this.btnQRCode.Font = new System.Drawing.Font(
                "Microsoft Sans Serif",
                14F,
                System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic
            );
            this.btnQRCode.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnQRCode.Location = new System.Drawing.Point(35, 444);
            this.btnQRCode.Name = "btnQRCode";
            this.btnQRCode.Size = new System.Drawing.Size(227, 44);
            this.btnQRCode.TabIndex = 3;
            this.btnQRCode.Text = "Tạo QR code";
            this.btnQRCode.UseVisualStyleBackColor = true;
            this.btnQRCode.Click += new System.EventHandler(this.btnQRCode_Click);

            // textBox2
            this.textBox2.Location = new System.Drawing.Point(419, 111);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(330, 26);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "Nhập ID tạo QR code +Barcode";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

            // pictureBox2
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(419, 338);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(330, 100);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;

            // btnBarCode
            this.btnBarCode.Font = new System.Drawing.Font(
                "Microsoft Sans Serif",
                14F,
                System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic
            );
            this.btnBarCode.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnBarCode.Location = new System.Drawing.Point(470, 444);
            this.btnBarCode.Name = "btnBarCode";
            this.btnBarCode.Size = new System.Drawing.Size(227, 44);
            this.btnBarCode.TabIndex = 7;
            this.btnBarCode.Text = "Tạo BarCode";
            this.btnBarCode.UseVisualStyleBackColor = true;
            this.btnBarCode.Click += new System.EventHandler(this.btnBarCode_Click);

            // btnQRandBar
            this.btnQRandBar.Font = new System.Drawing.Font(
                "Microsoft Sans Serif",
                14F,
                System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic
            );
            this.btnQRandBar.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnQRandBar.Location = new System.Drawing.Point(366, 161);
            this.btnQRandBar.Name = "btnQRandBar";
            this.btnQRandBar.Size = new System.Drawing.Size(422, 44);
            this.btnQRandBar.TabIndex = 8;
            this.btnQRandBar.Text = "Tạo QR Code và Bar Code";
            this.btnQRandBar.UseVisualStyleBackColor = true;
            this.btnQRandBar.Click += new System.EventHandler(this.button1_Click);

            // txtID2
            this.txtID2.Location = new System.Drawing.Point(419, 306);
            this.txtID2.Name = "txtID2";
            this.txtID2.Size = new System.Drawing.Size(330, 26);
            this.txtID2.TabIndex = 9;
            this.txtID2.Text = "ID 2:";

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 535);
            this.Controls.Add(this.txtID2);
            this.Controls.Add(this.btnQRandBar);
            this.Controls.Add(this.btnBarCode);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnQRCode);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtID1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "GD Qrcode + Barcode";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtID1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnQRCode;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnBarCode;
        private System.Windows.Forms.Button btnQRandBar;
        private System.Windows.Forms.TextBox txtID2;
    }
}
