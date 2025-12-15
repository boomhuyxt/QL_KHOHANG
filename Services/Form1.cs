using System;
using System.Drawing;
using System.Windows.Forms;
using QRCoder;
using Zen.Barcode;

namespace QL_KHO_HANG.Services
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // =======================
        // TẠO QR CODE
        // =======================
        private void btnQRCode_Click(object sender, EventArgs e)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(txtID1.Text, QRCodeGenerator.ECCLevel.H);
            QRCode qrCode = new QRCode(qrCodeData);

            pictureBox1.Image = qrCode.GetGraphic(10);
        }

        // =======================
        // TẠO QR + BARCODE
        // =======================
        private void button1_Click(object sender, EventArgs e)
        {
            // ----- QR CODE -----
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(textBox2.Text, QRCodeGenerator.ECCLevel.H);
            QRCode qrCode = new QRCode(qrCodeData);

            pictureBox1.Image = qrCode.GetGraphic(10);

            // ----- BARCODE -----
            string barcodeText = textBox2.Text;

            try
            {
                Code128BarcodeDraw barcode = BarcodeDrawFactory.Code128WithChecksum;
                pictureBox2.Image = barcode.Draw(barcodeText, 60);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tạo mã vạch: " + ex.Message);
            }
        }

        // =======================
        // TẠO BARCODE
        // =======================
        private void btnBarCode_Click(object sender, EventArgs e)
        {
            string barcodeText = txtID2.Text;

            try
            {
                Code128BarcodeDraw barcode = BarcodeDrawFactory.Code128WithChecksum;
                pictureBox2.Image = barcode.Draw(barcodeText, 60);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tạo mã vạch: " + ex.Message);
            }
        }
    }
}
