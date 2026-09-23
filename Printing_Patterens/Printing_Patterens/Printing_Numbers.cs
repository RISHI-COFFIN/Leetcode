using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printing_Patterens
{

     class Printing_Numbers
    {
       public void Patteren()
        {

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }

                Console.Write("\n");
            }

        }

    }
}
