﻿using System;
using System.Collections.Generic;
using Demo.Lab2;

namespace Demo.Assignment3
{
   public class Cart : Product
    {
        public string _iD;
        public string _customer;
        public double _grantTotal;
        public string city;
        public string country;
        public List<Product> products = new List<Product>();
        public List<double> totals = new List<double>();

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public Cart()
        {
        }

        public Cart(string iD, string customer, double grantTotal, string city, string country)
        {
            _iD = iD;
            _customer = customer;
            _grantTotal = grantTotal;
            this.city = city;
            this.country = country;
        }

        public Cart(int id, string name, double price, int qty, string image, string desc, string iD, string customer, double grantTotal, string city, string country) : base(id, name, price, qty, image, desc)
        {
            _iD = iD;
            _customer = customer;
            _grantTotal = grantTotal;
            this.city = city;
            this.country = country;
        }

        public void showInfo()
                 {
                     
                     Console.WriteLine("======Customer information======= ");
                     Console.WriteLine("Customer id: " + _iD + " | " + "Name: " + _customer + " | " + "City: " + city + " | " + "Country: " + country);
                     foreach (Product p in products)
                     {
                         Console.WriteLine("ID: " + p._id + " | " + "Name: " + p._name + " | " + "Price: " + p._price + " | " + "Qty: " + p._qty + " | " + "Image: " + p._image + 
                                           " | " + "Desc: " + p._desc);
                     }
                 }

        public void RemoveProduct()
        {
            string removeName;
            Console.WriteLine("Nhap san pam muon xoa: ");
            removeName = Convert.ToString(Console.ReadLine());
            for (int i = 0; i < products.Count; i++)
            {
                if (removeName.Equals(productList[i]._name))
                {
                    products.RemoveAt(i);
                    Console.WriteLine("Da xoa thanh cong");
                }
                else
                {
                    Console.WriteLine("Khong co ten cua san pham tren!");
                }
            }
        }

        public void grandTotalCal()
        {
            foreach (Product p in products)
            {
                _grantTotal = p._price * p._qty;
                totals.Add(_grantTotal);
            }
            

            double fee;
            if (country == "vietnam")
            {
                if (city == "HN" | city =="HCM")
                {
                    fee = _grantTotal * 0.01;
                    Console.WriteLine("Tong tien chua bao gom phi ship: " + _grantTotal);
                    Console.WriteLine("Phi ship:  " +( fee));
                    Console.WriteLine("Tong tien:" + (_grantTotal + fee));
                }
                else
                {
                    fee = _grantTotal * 0.02;
                    Console.WriteLine("Tong tien chua bao gom phi ship: " + _grantTotal);
                    Console.WriteLine("Phi ship:  " +( fee));
                    Console.WriteLine("Tong tien:" + (_grantTotal + fee));
                }
            }
            else
            {
                fee = _grantTotal * 0.05;
                Console.WriteLine("Tong tien chua bao gom phi ship: " + _grantTotal);
                Console.WriteLine("Phi ship:  " +( fee));
                Console.WriteLine("Tong tien:" + (_grantTotal + fee));
            }

        }
    }
}