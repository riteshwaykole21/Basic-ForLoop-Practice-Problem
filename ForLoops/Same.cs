using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoops
{
    public class Same
    {
        public void Pattern()
        {
            Console.WriteLine("Enter The Number Of Rows");
            int Rows = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= Rows; i++)
            {
                for(int j = 1; j <= i; j++)
                    Console.Write(i);
                    Console.Write("\n");
            }
        }
    }
}
