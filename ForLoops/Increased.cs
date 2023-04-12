using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoops
{
    public class Increased
    {
        public void Number()
        {
            int k = 1;
            Console.WriteLine("Enter The Number Of Rows");
            int Rows = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= Rows; i++)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write("{0} ", k++);
                Console.Write("\n");
            }
        }
    }
}
