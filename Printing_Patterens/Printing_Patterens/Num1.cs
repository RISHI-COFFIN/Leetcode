using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printing_Patterens
{
    internal class Num1
    {

        public void num1()
        {

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }

                Console.Write("\n");
            }

        }
    }
}
