using System;
using System.Collections.Generic;

namespace Demo.Assignment4
{
    public class VietNamCustomer :Customer
    {
        private string DoiTuongKH;
        private int DinhMuc;
        private List<VietNamCustomer> customerVN;

        public VietNamCustomer(int maKh, string hoTen, DateTime ngayLapHd, int soLuong, int donGia, double thanhTien, string doiTuongKh, int dinhMuc, List<VietNamCustomer> customerVn) : base(maKh, hoTen, ngayLapHd, soLuong, donGia, thanhTien)
        {
            DoiTuongKH = doiTuongKh;
            DinhMuc = dinhMuc;
            customerVN = customerVn;
        }

        public string DoiTuongKh
        {
            get => DoiTuongKH;
            set => DoiTuongKH = value;
        }

        public int DinhMuc1
        {
            get => DinhMuc;
            set => DinhMuc = value;
        }

        public List<VietNamCustomer> CustomerVn
        {
            get => customerVN;
            set => customerVN = value;
        }

        public int MaKh1
        {
            get => MaKH;
            set => MaKH = value;
        }

        public string HoTen2
        {
            get => HoTen;
            set => HoTen = value;
        }

        public DateTime NgayLapHd1
        {
            get => NgayLapHD;
            set => NgayLapHD = value;
        }

        public int SoLuong2
        {
            get => SoLuong;
            set => SoLuong = value;
        }

        public int DonGia2
        {
            get => DonGia;
            set => DonGia = value;
        }

        public double ThanhTien2
        {
            get => ThanhTien;
            set => ThanhTien = value;
        }

        public void addCustomer(VietNamCustomer customer)
        {
            customerVN.Add(customer);
        }
        
        public new double Total()
        {
            int newprice;
            if (DinhMuc < 50)
            {
                newprice = 1000;
            }
            else if (DinhMuc > 50 && DinhMuc < 100)
            {
                newprice = 1200;
            }
            else if (DinhMuc > 100 && DinhMuc < 200)
            {
                newprice = 1500;
            }
            else
            {
                newprice = 2000;
            }

            if (SoLuong <= DinhMuc)
            {
                return ThanhTien = newprice * SoLuong;
            }
            else
            {
                return ThanhTien = DinhMuc * newprice + (SoLuong - DinhMuc) * newprice * 2.5;
            }
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine(" | Loai KH:"+DoiTuongKh+" | Dinh muc "+DinhMuc+" | Thanh Tien:");
        }
        
        public void showList()
        {
            Console.WriteLine("Danh Sach KH VietNam:");
            foreach (VietNamCustomer c in customerVN)
            {
                c.ShowInfo();
            }
        }
        public void TongSL()
        {
            int sumQty = 0;
            foreach (VietNamCustomer c in customerVN )
            {
                sumQty += c.SoLuong;
            }

            Console.WriteLine("Tong so luong dien kh Viet Nam :"+sumQty);
        }
    }
}