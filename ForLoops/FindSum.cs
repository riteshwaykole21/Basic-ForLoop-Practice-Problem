using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoops
{
    public class FindSum
    {
        public void Find()
        {
            Console.WriteLine("Enter Ten Natural Number");
            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                sum += n;
            }
            int Avg = sum / 10;
            Console.WriteLine("The Sum Of Ten Number is :" + sum);
            Console.WriteLine("The Avg Of Ten Natural Number : "+ Avg);
        }
    }
}
