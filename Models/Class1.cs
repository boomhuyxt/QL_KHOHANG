using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZXing;

namespace QL_KHO_HANG.Models
{
    internal class Class1
    {
        public string Content { get; set; }      // Nội dung QR (random)
        public Bitmap QRImage { get; set; }      // Ảnh QR đã tạo
    }
}
