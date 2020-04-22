using System;
using System.Collections.Generic;

namespace Demo.ThayChuaBTLab23
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Product p1 = new Product(1, "san pham1", 2, 1,  "mota sp1", "Hihi", new List<string>());
            p1.AddGallery("anh2");
            Fashion f1 =new Fashion(1 , "fashion1", 2, 1, "anh12", "ao nam", new List<string>(),  "red", 36  );
            Diamon d1 = new Diamon(3, "kimcuong", 150000, 1, "anh3", "kim cuong that", new List<string>(), 18 );
            Cart c1 = new Cart(1, "Pham Huyen", 0, new List<Product>(), "HN", "VN" );
            c1.AddProduct(p1);
            c1.AddProduct(f1);
            c1.AddProduct(d1);
            Console.WriteLine("Tong tien thanh toan: " +c1.FinalTotal());
        }
    }
}