using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maths
{
    internal class Reverse_number
    {

        public int reverse(int x)
        {

            int rev = 0;

            while(x > 0)
            {
                int last = x % 10;

                x = x / 10;

                rev = (rev * 10) + last;
            }

            return rev;

        }


        static void Main(string[] args)
        {

            
            Reverse_number obj = new Reverse_number();

            Console.WriteLine(obj.reverse(27845));
        }


    }
}
