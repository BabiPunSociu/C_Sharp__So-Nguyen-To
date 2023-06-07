using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoNguyenTo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            do
            {
                Console.Write("Nhap so nguyen duong a (a>1): a = ");
                a = Convert.ToInt32(Console.ReadLine());
            } while (a <= 1);
            
            Console.WriteLine();
            Console.WriteLine(KiemTra.check(a));
        }
    }
}
