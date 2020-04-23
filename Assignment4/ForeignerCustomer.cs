using System;
using System.Collections.Generic;

namespace Demo.Assignment4
{
    public class ForeignerCustomer : Customer
    {
        
        private string QuocTich;
        private List<ForeignerCustomer> customerNN;

        public ForeignerCustomer(int maKh, string hoTen, DateTime ngayLapHd, int soLuong, int donGia, double thanhTien, string quocTich, List<ForeignerCustomer> customerNn) : base(maKh, hoTen, ngayLapHd, soLuong, donGia, thanhTien)
        {
            QuocTich = quocTich;
            customerNN = customerNn;
        }

        public string QuocTich1
        {
            get => QuocTich;
            set => QuocTich = value;
        }

        public List<ForeignerCustomer> CustomerNn
        {
            get => customerNN;
            set => customerNN = value;
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

        public void addCustomerNN(ForeignerCustomer customer)
        {
            customerNN.Add(customer);
        }

        public double Total()
        {
            return ThanhTien = SoLuong * 2000;
        }

     
      
        public   override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Quoc tich: " + QuocTich + " | " + "Thanh tien: " +  ThanhTien1);
        }

        public void ShowList()
        {
            foreach (ForeignerCustomer c in customerNN)
            {
                
                c.ShowInfo();
            }
        }

        public void TongSL()
        {
            int tongsl = 0;
            foreach (ForeignerCustomer c in customerNN)
            {
                tongsl += c.SoLuong;
                
            }
            Console.WriteLine("Tong so luong dien KH nuoc ngoai su dung: " + tongsl );
        }

        public void TrungBinh()
        {
            double sumtotal = 0;
            foreach (ForeignerCustomer c in customerNN)
            {
                sumtotal += c.ThanhTien;
            }
            Console.WriteLine("Trung binh thanh tien cua nguoi Nuoc Ngoai: " + sumtotal/ (customerNN.Count));
        }
    }
    
}