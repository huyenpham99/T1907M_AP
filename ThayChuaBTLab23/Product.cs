using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Demo.ThayChuaBTLab23
{
    public class Product
    {
        protected int id;
        protected string name;
        protected int price;
        protected uint qty; //dam bao so luong khong am
        protected string image;
        protected string desc;
        protected List<string> gallery;

        public Product(int id, string name, int price, uint qty, string image, string desc, List<string> gallery)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.qty = qty;
            this.image = image;
            this.desc = desc;
            this.gallery = gallery;
        }

        public Product()
        {
            this.gallery = new List<string>();

        }

        public int Id //khai bao 1 propoties
        {
            get { return id;}
            set { this.id = value; }
        }

        public string Name
        {
            get => name; //lamda expression
            set => name = value;
        }

        public int Price
        {
            get => price;
            set => price = value;
        }

        public uint Qty
        {
            get => qty;
            set => qty = value;
        }

        public string Image
        {
            get => image;
            set => image = value;
        }

        public string Desc
        {
            get => desc;
            set => desc = value;
        }

        public List<string> Gallery
        {
            get => gallery;
            set => gallery = value;
        }

        //constructor tuự động chạy khi tạo đối tượng,
        //có tác dụng làm CV ta muốn làm(gán GT ban đầu)
        public void GetInfo()
        {
            Console.WriteLine("ID:" + id + "Name:" + name + "Price:" + price + "Qty: " + qty);
        }

        public bool CheckStock()
        {
            if (qty>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool AddGallery(string image)
        {
            if (gallery.Count >=10)
            {
                Console.WriteLine("Anh da vuot qua so luong, can xoa bot truoc khi them");
                return false;
            }
               // Console.WriteLine("Nhap link anh: ");
               // string new_image = Console.ReadLine();
               //gallery.Add(new_image);
               gallery.Add(image);
               return true;
        }

        public void RemoveGallery()
        {
            Console.WriteLine("Danh sach in anh: ");
            for (int i= 0; i < gallery.Count; i++)
            {
                Console.WriteLine((i+1) + "." + gallery[i]);
            }
            Console.WriteLine("Chon anh de xoa: ");
            int stt = Convert.ToInt32(Console.ReadLine());
            gallery.RemoveAt(stt);
            
        }

        public bool RemoveImage(string image)
        {
            return gallery.Remove(image);
        }

        public bool RemoveAt(int number)
        {
            if (number < gallery.Count && number >0)
            {
                gallery.RemoveAt(number);
                return true;
            }
                return false;
            
        }
    }
}