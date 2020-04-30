using System;

namespace Demo.Assignment5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int choise = 0;
            string name, phone;
           
            BookPhone b1 = new BookPhone();
            BookPhone b2 = new BookPhone();
            BookPhone b3 = new BookPhone();
            b1.InsertPhone("Huyen", "03333333");
            b1.InsertPhone("Linh", "0555555");
            b1.InsertPhone("Vanh", "07777777");
            b1.RemovePhone("Huyen");
            
            b1.GetInfo();
        }
    }
}