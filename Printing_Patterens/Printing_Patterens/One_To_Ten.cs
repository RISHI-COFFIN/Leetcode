using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printing_Patterens
{
    internal class One_To_Ten
    {

        public void Till_Ten()
        {

            int num = 1;

            for(int i = 1; i<= 5; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write(num);
                    num++;
                }

                Console.Write("\n");
            }

        }


    }
}
