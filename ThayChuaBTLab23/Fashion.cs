﻿using System.Collections.Generic;

namespace Demo.ThayChuaBTLab23
{
    public class Fashion : Product
    {
        private string color;
        private int size;

        public Fashion(int id, string name, int price, uint qty, string image, string desc, List<string> gallery, string color, int size) : base(id, name, price, qty, image, desc, gallery)
        {
            this.color = color;
            this.size = size;
        }

        public Fashion(string color, int size)
        {
            this.color = color;
            this.size = size;
        }

        public bool CheckColor(string color)
        {
            if (this.color.Equals(color)  &&  this.qty >0)
            {
                return true;
            }

            return false;
        }

        public bool CheckSize(int size)
        {
            if (this.size.Equals(size) && qty > 0)
            {
                return true;
            }

            return false;
        }
        
        
    }
}