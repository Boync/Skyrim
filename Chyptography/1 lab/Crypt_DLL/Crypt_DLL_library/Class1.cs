using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Crypt_DLL_library
{
    public class Crypt
    {

        public static void evklid(BigInteger a, BigInteger b, ref BigInteger x, ref BigInteger y, ref BigInteger d)
        {
            BigInteger q, r;
            BigInteger x1 = 0, x2 = 1, y1 = 1, y2 = 0;
            //BigInteger d, x, y; //results
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

        public static void diffi_hellman(BigInteger p, BigInteger a, BigInteger x1, BigInteger x2, ref BigInteger z1, ref BigInteger z2)
        {
            BigInteger y1 = new BigInteger();
            BigInteger y2 = new BigInteger();
            y1 = BigInteger.ModPow(a,x1,p);
            //textBox_y1.Text = Convert.ToString(y1);
            y2 = BigInteger.ModPow(a, x2, p);
            //textBox_y2.Text = Convert.ToString(y2);
            z1 = BigInteger.ModPow(y2, x1, p);
            z2 = BigInteger.ModPow(y1, x2, p);
        }
    }
}
