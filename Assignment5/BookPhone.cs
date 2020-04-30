using System;
using System.Collections;
using System.Collections.Generic;

namespace Demo.Assignment5
{
    public class BookPhone : Phone
    {
        List<NamePhone>  phoneList = new List<NamePhone>();

        public override void InsertPhone(string name, string number)
        {
            foreach (NamePhone p in phoneList)
            {
                if (p.Name.Equals(number))
                {
                    if (p.Number.Equals(number))
                    {
                        return;
                    }

                    p.Number = p.Number + " : " + number;
                    return;
                }
            }
            phoneList.Add(new NamePhone(name, number));
        }

        public override void RemovePhone(string name)
        {
            foreach (NamePhone n in phoneList)
            {
                if (n.Name.Equals(name))
                {
                    phoneList.Remove(n);
                    return;
                }
            }
        }
        public override void UpdatePhone(string name, string newphone)
        {
            foreach (NamePhone p in phoneList)
            {
                if (p.Name.Equals(name))
                {
                    p.Number = newphone;
                    return;
                }
            }
        }

        public override NamePhone SearchPhone(string name)
        {
            foreach (NamePhone p in phoneList)
            {
                if (p.Name.Equals(name))
                {
                   
                    return p;
                }
            }
            return null;
        }

        public void GetInfo()
        {
            Console.WriteLine("Danh sach Contact: ");
            for (int i = 0; i < phoneList.Count; i++)
            {
                NamePhone namePhone = phoneList[i];
                Console.WriteLine("Ten: " + namePhone.Name + " | " + "SDT: " + namePhone.Number);
            }
        }
    }
}