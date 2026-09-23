using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printing_Patterens
{
     class Inverse_number
    {

        public void num_inverse()
        {

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 5; j >= i; j--)
                {
                    Console.Write(j);
                }

                Console.Write("\n");
            }
        }

    }
}
