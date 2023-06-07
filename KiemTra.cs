using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoNguyenTo
{
    internal class KiemTra
    {
        public static bool check(int a)
        {
            if(a <= 1) return false;
            for(int i=2;i <= Math.Sqrt(a);i++)
            {
                if(a%i == 0) return false;
            }
            return true;
        }
    }
}
