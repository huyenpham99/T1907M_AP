using System;
using Demo.Lab2;

namespace Demo.Assignment3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int _id;
            string _name;
            double _price;
            int _qty;
            string _image;
            string _desc;
         
         Cart cart = new Cart("1", " Huyen ", 1, "HN", "vietnam");
         Product product = new Product();
         Console.WriteLine("Enter id: ");
         _id = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("Enter name: ");
         _name = Convert.ToString(Console.ReadLine());
         Console.WriteLine("Enter price: ");
         _price = Convert.ToDouble(Console.ReadLine());
         Console.WriteLine("Enter qty: ");
         _qty = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("Enter image: ");
         _image = Convert.ToString(Console.ReadLine());
         Console.WriteLine("Enter desc: ");
         _desc = Convert.ToString(Console.ReadLine());
         cart.AddProduct(new Product(_id, _name,_price, _qty, _image, _desc));
         cart.showInfo();
         cart.grandTotalCal();
         
        }
    }
}