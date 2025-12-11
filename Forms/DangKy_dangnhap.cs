using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_KHO_HANG.form
{
    public partial class DangKy_dangnhap : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect,
            int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        public DangKy_dangnhap()
        {
            InitializeComponent();
        }

        private void DangKy_dangnhap_Load(object sender, EventArgs e)
        {
            Panel pnlUser = new Panel();
            pnlUser.Size = new Size(260, 40);
            pnlUser.BackColor = Color.White;
            pnlUser.BorderStyle = BorderStyle.FixedSingle;
            pnlUser.Padding = new Padding(10, 8, 0, 0);

            pnlUser.Region = System.Drawing.Region.FromHrgn(
                CreateRoundRectRgn(0, 0, pnlUser.Width, pnlUser.Height, 15, 15)
            );

            this.Controls.Add(pnlUser);
        }
    }
}
