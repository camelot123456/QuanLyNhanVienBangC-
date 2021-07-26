using System;
using System.Collections.Generic;
using System.Text;

namespace quan_li_nhan_vien
{
    class DanhSachNhanVien
    {
        Dictionary<string, NhanVien> list = new Dictionary<string, NhanVien>();


        public void nhap()
        {
            int chon = 0;
            do
            {
                StringBuilder buider = new StringBuilder();
                buider.Append("\n1/Nhan vien bien che");
                buider.Append("\n2/Nhan vien hop dong");
                buider.Append("\n0/Quay lai");
                Console.WriteLine(buider.ToString());
                chon = Convert.ToInt16(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        NhanVienBienChe nvbc = new NhanVienBienChe();
                        nvbc.nhap();
                        list.Add(nvbc.Id, nvbc);
                        Console.WriteLine("Nhap thanh cong");
                        break;
                    case 2:
                        NhanVienHopDong nvhd = new NhanVienHopDong();
                        nvhd.nhap();
                        list.Add(nvhd.Id, nvhd);
                        Console.WriteLine("Nhap thanh cong");
                        break;
                    default:
                        break;
                }
            } while (chon != 0);
        }

        public void xuat()
        {
            foreach (NhanVien nhanVien in list.Values)
            {
                if (nhanVien is NhanVienBienChe)
                {
                    NhanVienBienChe nvbc = (NhanVienBienChe)nhanVien;
                    nvbc.xuat();
                }
                else
                {
                    NhanVienHopDong nvhd = (NhanVienHopDong)nhanVien;
                    nvhd.xuat();
                }
            }
        }

        public double tongQuyLuong()
        {
            double tong = 0;
            foreach (NhanVien nhanVien in list.Values)
            {
                tong += nhanVien.thucLinh();
            }
            return tong;
        }

        public NhanVien tim(string id)
        {
            foreach (NhanVien nhanVien in list.Values)
            {
                if (nhanVien.Id.Equals(id.Trim()))
                {
                    return nhanVien;
                }
            }
          
            return null;
        }

        public void xoa(string id)
        {
            try
            {
                foreach (NhanVien nhanVien in list.Values)
                {
                    if (nhanVien.Id.Equals(id.Trim()))
                    {
                        list.Remove(id);
                        Console.WriteLine("Xoa thanh cong");
                        break;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("\nID khong ton tai!");
            }
        }

        public void menu()
        {
            int chon = 0;
            do
            {
                StringBuilder builder = new StringBuilder();
                builder.Append("\nQUAN LY NHAN VIEN");
                builder.Append("\n1/Them");
                builder.Append("\n2/Xuat");
                builder.Append("\n3/Tong luong");
                builder.Append("\n4/Tim");
                builder.Append("\n5/Xoa");
                builder.Append("\n0.Thoat");
                builder.Append("\nMoi ban chon chuc nang: ");
                Console.WriteLine(builder.ToString());
                chon = Convert.ToInt16(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        nhap();
                        break;
                    case 2:
                        xuat();
                        break;
                    case 3:
                        Console.WriteLine("\nTong luong nhan vien: " + tongQuyLuong());
                        break;
                    case 4:
                        Console.WriteLine("\nNhap Id can tim: ");
                        string id = Console.ReadLine();
                        NhanVien nv = tim(id);
                        if (nv != null)
                        {
                            nv.xuat();
                        } else
                        {
                            Console.WriteLine("\nId khong ton tai");
                        }
                        
                        break;
                    case 5:
                        Console.WriteLine("\nNhap id can xoa: ");
                        id = Console.ReadLine();
                        xoa(id);
                        break;
                    default:
                        Console.WriteLine("\nMoi ban chon chuc nang khac!");
                        break;
                }
            } while (chon != 0);
        }
            
    }
}
