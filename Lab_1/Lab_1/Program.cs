using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class Program
    {
        static string DecToOct(int dec)
        {
            string s = "";
            string oct="";
            int ost;
            while (dec>=8)
            {
                ost = dec % 8;
                s = s + Convert.ToString(ost);
                dec = dec / 8;
            }
            s = s + Convert.ToString(dec);
            for (int i=s.Length; i>0; i--)
                oct = oct + s[i-1];
            return oct;
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Десятичное число: ");
            int d =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Восьмиричное: {DecToOct(d)}");
            Console.ReadKey();

        }
    }
}
