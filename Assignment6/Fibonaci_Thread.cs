using System;
using System.Threading;

namespace Demo.Assignment6
{
    public class Fibonaci_Thread
    {
        public static void Main(string[] args)
        {
            string str;
            int fb1, fb2, fb;
            Console.Write("nhap so n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            fb = 0;
            fb1 = 1;
            fb2 = 1;
            do
            {
                fb = fb1 + fb2;
                fb2 = fb1;
                fb1 = fb;
                Console.Write("\n" +fb1);
                Thread.Sleep(100);
            } while (fb1 + fb2 <n); 
            
        }
        
    }
}