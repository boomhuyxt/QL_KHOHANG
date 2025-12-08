using QL_KHO_HANG.Models;
using ZXing;
using ZXing.QrCode;
using System;
using System.Drawing;

namespace QL_KHO_HANG.Services
{
    internal class lolheo
    {
        // Hàm tạo QR code ngẫu nhiên
        public static Class1 GenerateQR()
        {
            // 1. Tạo chuỗi ngẫu nhiên
            string randomString = Guid.NewGuid().ToString();

            // 2. Tạo QR bằng ZXing
            var writer = new BarcodeWriter
            {
                Format = BarcodeFormat.QR_CODE,
                Options = new QrCodeEncodingOptions
                {
                    Height = 200,
                    Width = 200,
                    Margin = 1
                }
            };

            Bitmap qrImage = writer.Write(randomString);

            // 3. Trả model chứa dữ liệu QR
            return new Class1
            {
                Content = randomString,
                QRImage = qrImage
            };
        }
    }
}
