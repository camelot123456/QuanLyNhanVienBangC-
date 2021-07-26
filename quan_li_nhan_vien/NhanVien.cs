using System;
using System.Collections.Generic;
using System.Text;

namespace quan_li_nhan_vien
{
    abstract class NhanVien : ILuong
    {
        protected string hoTen;
        protected string namSinh;
        protected string gioiTinh;
        protected string cmnd;
        protected string id;

        public string HoTen { get => hoTen; set => hoTen = value; }
        public string NamSinh { get => namSinh; set => namSinh = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string Cmnd { get => cmnd; set => cmnd = value; }
        public string Id { get => id; set => id = value; }


        public virtual void nhap()
        {
            Console.WriteLine("Ho ten: ");
            HoTen = Console.ReadLine();
            Console.WriteLine("Nam sinh: ");
            NamSinh = Console.ReadLine();
            Console.WriteLine("Gioi tinh: ");
            GioiTinh = Console.ReadLine();
            Console.WriteLine("CMND: ");
            Cmnd = Console.ReadLine();
            Console.WriteLine("ID: ");
            Id = Console.ReadLine();
        }

        public abstract double phuCap();
        public abstract double thucLinh();

        public virtual void xuat()
        {
            StringBuilder buider = new StringBuilder();
            buider.Append("\nHo ten: " + HoTen);
            buider.Append("\nNam sinh: " + NamSinh);
            buider.Append("\nGioi tinh: " + GioiTinh);
            buider.Append("\nCMND: " + Cmnd);
            buider.Append("\nId: " + Id);
            Console.Write(buider.ToString());
        }
    }
}
