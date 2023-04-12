using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoops
{
    public class Table
    {
        public void Program()
        {
            Console.WriteLine("Enter The Number Of The Table");
            int N = Convert.ToInt32(Console.ReadLine());
            for ( int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} * {1} = {2}", N,i,(i*N));
            }
        }
    }
}
