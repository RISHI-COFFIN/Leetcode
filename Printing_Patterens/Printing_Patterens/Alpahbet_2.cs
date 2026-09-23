using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printing_Patterens
{
     class Alpahbet_2
    {

        public void Alph2()
        {


            int total_row = 5;

            for (int i = 1; i <= total_row; i++)
            {

                for (int j = 1; j <= i; j++)
                {
                    Console.Write((char)(64 + j));
                }

                Console.Write("\n");

            }

        }

    }
}
