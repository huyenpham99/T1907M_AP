using System;
using System.Xml;
using Demo.ThayChuaBTLab23;

namespace Demo.Assignment4
{
    public class Customer
    {
        protected int MaKH;
        protected string HoTen;
        protected DateTime NgayLapHD;
        protected int SoLuong;
        protected int DonGia;
        protected double ThanhTien;

        public Customer(int maKh, string hoTen, DateTime ngayLapHd, int soLuong, int donGia, double thanhTien)
        {
            MaKH = maKh;
            HoTen = hoTen;
            NgayLapHD = ngayLapHd;
            SoLuong = soLuong;
            DonGia = donGia;
            ThanhTien = thanhTien;
        }

        public int MaKh
        {
            get => MaKH;
            set => MaKH = value;
        }

        public string HoTen1
        {
            get => HoTen;
            set => HoTen = value;
        }

        public DateTime NgayLapHd
        {
            get => NgayLapHD;
            set => NgayLapHD = value;
        }

        public int SoLuong1
        {
            get => SoLuong;
            set => SoLuong = value;
        }

        public int DonGia1
        {
            get => DonGia;
            set => DonGia = value;
        }

        public double ThanhTien1
        {
            get => ThanhTien;
            set => ThanhTien = value;
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine("ID:" + MaKH +  " | " + "Ho va Ten: " + HoTen + " | " + "Ngay lap HD: " + NgayLapHD + " | "  + "So luong: " + SoLuong + "Don gia: " + DonGia );
        }
    }
}