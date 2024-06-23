using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Program
    {
        public void btd()
        {
            int a;
            int i = 0;
            double rem, result = 0;
            Console.Write("\nEnter Binary Number : ");
            a = Convert.ToInt32(Console.ReadLine());
            while (a != 0)
            {
                rem = a % 10;
                result = result + rem * Math.Pow(2, i++);
                a = a / 10;
            }
            Console.WriteLine("Decimal Number is : " + result);
            Console.ReadLine();
        }
        public void Main(string[] args)
        {
            Console.WriteLine("\n Riya Shah \t 170410107108 ");
            Program p = new Program();
            p.btd();
        }
    }
}