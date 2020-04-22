using System.Collections.Generic;

namespace Demo.ThayChuaBTLab23
{
    public class Diamon : Product
    {
        private uint cara;

        public Diamon(int id, string name, int price, uint qty, string image, string desc, List<string> gallery, uint cara) : base(id, name, price, qty, image, desc, gallery)
        {
            this.cara = cara;
        }

        public Diamon(uint cara)
        {
            this.cara = cara;
        }

      
public bool IsReal()
        {
            //cong thuc kiem tra nao do
            if (cara>5)  return true;
            return false;

        }
    }
}