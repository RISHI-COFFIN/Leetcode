using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printing_Patterens
{
     class Diamond
    {

        public void diamond()
        {
            int total_row, row, space, symbol;

            Console.WriteLine("Enter the total number of rows");
            total_row = Convert.ToInt32(Console.ReadLine());

            for(row = 1; row <= total_row; row++)
            {

                for(space = 1; space <= (total_row - row); space++)
                {
                    Console.Write(" ");

                }

                for (symbol = 1; symbol <= ((2*row) - 1); symbol++)
                {
                    Console.Write("*");

                }

                Console.Write("\n");

            }

            for(row = total_row - 1; row >= 1; row--)
            {


                for (space = 1; space <= (total_row - row); space++)
                {
                    Console.Write(" ");

                }

                for (symbol = 1; symbol <= ((2 * row) - 1); symbol++)
                {
                    Console.Write("*");

                }

                Console.Write("\n");

            }

        }

    }
}
