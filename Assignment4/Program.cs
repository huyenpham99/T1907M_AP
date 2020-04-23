using System;
using System.Collections.Generic;

namespace Demo.Assignment4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ForeignerCustomer f1 = new ForeignerCustomer(1, "Huyen", DateTime.Now, 50, 2000, 0, "Japanese", new List<ForeignerCustomer>());
            ForeignerCustomer f2 = new ForeignerCustomer(2, "abc", DateTime.Now, 65, 2000, 0, "Sing", new List<ForeignerCustomer>());
            ForeignerCustomer f3 = new ForeignerCustomer(3, "jj", DateTime.Now, 50, 2000, 0, "Quatar", new List<ForeignerCustomer>());
            ForeignerCustomer f4 = new ForeignerCustomer(4, "kk", DateTime.Now, 70, 2000, 0, "Chinese", new List<ForeignerCustomer>());
            f1.addCustomerNN(f1);
            f1.addCustomerNN(f2);
            f1.addCustomerNN(f3);
            f1.addCustomerNN(f4);
            f1.ShowList();
            f1.TongSL();
            f1.TrungBinh();
         //VietNamCustomer v1 = new VietNamCustomer(1, "Huyen", DateTime.Today, 56, 0, 0, "Kinh doanh", 1, new List<VietNamCustomer>());
       //  VietNamCustomer v2 = new VietNamCustomer(1, "Huyen", DateTime.Today, 56, 0, 0, "Kinh doanh", 1, new List<VietNamCustomer>());
      //   VietNamCustomer v3 = new VietNamCustomer(1, "Huyen", DateTime.Today, 56, 0, 0, "Kinh doanh", 1, new List<VietNamCustomer>());
      //   VietNamCustomer v4 = new VietNamCustomer(1, "Huyen", DateTime.Today, 56, 0, 0, "Kinh doanh", 1, new List<VietNamCustomer>());
     //    v1.addCustomer(v1);
      //   v1.addCustomer(v2);
     //    v1.addCustomer(v3);
      //   v1.addCustomer(v4);
        }
    }
}