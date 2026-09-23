using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printing_Patterens
{
    internal class Side_Pyramid
    {

        public void Side()
        {

            int rows;
            Console.WriteLine("Enter the number of rows");
            rows = Convert.ToInt32(Console.ReadLine()); 

            for(int i = 1; i <= rows; i++)
            {
                for(int j = 1; j <= rows; j++)
                {
                    if((i+j) <= rows)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }

                Console.Write("\n");
            }

        } 

    }
}
