using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoops
{
    public class Trangle
    {
        public void Input()
        {
            Console.WriteLine("Input Number Of Rows");
            int Rows = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= Rows; i++)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write("*");
                    Console.Write("\n");
                
            }
        }
    }
}
