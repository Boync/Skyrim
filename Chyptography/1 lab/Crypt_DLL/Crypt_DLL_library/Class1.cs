using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crypt_DLL_library
{
    public class Crypt
    {
        public static long power_mod(long a, long x, long m)
        {
            // y = a^x mod m
            long y = 1;
            for (long i = 1; i < x + 1; i++)
            {
                y = (y * a) % m;
            }
            return y;
        }

        public static void evklid(long a, long b, ref long x, ref long y, ref long d)
        {
            long q, r;
            long x1 = 0, x2 = 1, y1 = 1, y2 = 0;
            //long d, x, y; //results
            if (b == 0) { d = a; x = 1; y = 0; }
            while (b > 0)
            {
                q = a / b;
                r = a - q * b;
                x = x2 - q * x1;
                y = y2 - q * y1;
                a = b;
                b = r;
                x2 = x1;
                x1 = x;
                y2 = y1;
                y1 = y;

            }
            d = a;
            x = x2;
            y = y2;
        }

        public static void diffi_hellman(long p, long a, long x1, long x2, ref long z1, ref long z2)
        {
            long y1 = power_mod(a, x1, p);
            //textBox_y1.Text = Convert.ToString(y1);
            long y2 = power_mod(a, x2, p);
            //textBox_y2.Text = Convert.ToString(y2);
            z1 = power_mod(y2, x1, p);
            z2 = power_mod(y1, x2, p);
        }
    }
}
