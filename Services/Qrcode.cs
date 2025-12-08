using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using QL_KHO_HANG.Services;
using System.CodeDom.Compiler;

namespace QL_KHO_HANG.Services
{
    public partial class Qrcode : Form
    {
        public Qrcode()
        {
            InitializeComponent();
        }
        BarcodeReader barcode = new BarcodeReader();
        string resultcode;
        private void button1_Click(object sender, EventArgs e)
        {
            // Gọi service tạo QR
            var qrData = lolheo.GenerateQR();

            // Hiển thị QR lên PictureBox
            picQR.Image = qrData.QRImage;

            // Thông báo nội dung QR
            MessageBox.Show($"Đã tạo QR!\nNội dung: {qrData.Content}");

        }
    }
}
