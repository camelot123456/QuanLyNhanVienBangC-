using System;
using System.Collections.Generic;
using System.Text;

namespace quan_li_nhan_vien
{
    class NhanVienHopDong : NhanVien
    {
        private double mucLuong;

        public double MucLuong { get => mucLuong; set => mucLuong = value; }

        public override void nhap()
        {
            base.nhap();
            Console.WriteLine("Muc luong: ");
            MucLuong = Convert.ToDouble(Console.ReadLine());
        }

        public override void xuat()
        {
            base.xuat();
            StringBuilder buider = new StringBuilder();
            buider.Append("\nMuc luong: "+MucLuong);
            buider.Append("\nPhu cap: " + phuCap());
            buider.Append("\nThuc linh: " + thucLinh());
            Console.WriteLine(buider.ToString());
        }

        public override double phuCap()
        {
            return MucLuong / 10;
        }

        public override double thucLinh()
        {
            return MucLuong + phuCap();
        }
    }
}
