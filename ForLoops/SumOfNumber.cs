using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoops
{
    public class SumOfNumber
    {
        public void Number()
        {
            Console.WriteLine("Sum of Ten Natural Number");
            int sum = 0;
            for (int i = 0; i <= 10; i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);
              
        }
    }
}
