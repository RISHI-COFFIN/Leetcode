using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printing_Patterens
{
     class Inverted_Side
    {

        public void side_inverted()
        {

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 5; j >= i; j--)
                {
                    Console.Write("*");
                }

                Console.Write("\n");
            }

        }
        
    }
}
