using System;
using System.Collections.Generic;
using System.Text;

namespace quan_li_nhan_vien
{
    class NhanVienBienChe : NhanVien
    {

        private double heSoLuong;
        private double luongCoBan;

        public double HeSoLuong { get => heSoLuong; set => heSoLuong = value; }
        public double LuongCoBan { get => luongCoBan; set => luongCoBan = value; }

        public override void nhap()
        {
            base.nhap();
            Console.WriteLine("He so luong: ");
            HeSoLuong = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Luong co ban: ");
            LuongCoBan = Convert.ToDouble(Console.ReadLine());
        }

        public override double phuCap()
        {
            return LuongCoBan / 10;
        }

        public override double thucLinh()
        {
            return HeSoLuong * LuongCoBan + phuCap();
        }

        public override void xuat()
        {
            base.xuat();
            StringBuilder buider = new StringBuilder();
            buider.Append("\nHe so luong: "+HeSoLuong);
            buider.Append("\nLuong co ban: " + LuongCoBan);
            buider.Append("\nPhu cap: " + phuCap());
            buider.Append("\nThuc linh: " + thucLinh());
            Console.WriteLine(buider.ToString());
        }

    }
}
