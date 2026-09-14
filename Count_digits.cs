using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maths
{
    internal class Count_digits
    {
        public int Count_digit(int x)
        {

            int count = 0;

            while (x > 0)
            {
       

                count++;

                x = x / 10;

              
            }

            return count;

        }


        static void Main(string[] args)
        {


            Count_digits obj = new Count_digits();

            Console.WriteLine(obj.Count_digit(667));
        }

    }
}
