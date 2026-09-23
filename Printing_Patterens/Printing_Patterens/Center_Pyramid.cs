using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printing_Patterens
{
     class Center_Pyramid
    {

        public void Center()
        {
            int total_rows, rows, space, symbol;

            Console.WriteLine("Enter Total numbers of rows");
            total_rows = Convert.ToInt32(Console.ReadLine());

            for(rows = 1; rows <= total_rows; rows++)
            {

                for(space = 1; space <= (total_rows - rows); space++)
                {
                    Console.Write(" ");
                }

                for(symbol = 1; symbol <= ((2*rows)-1); symbol++)
                {
                    Console.Write("*");
                }

                Console.Write("\n");

            }

        }

    }
}
