using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ForLoops
{
    public class NTerm
    {
        public void Sum()
        {
            int Sum = 0;
            Console.WriteLine("Sum of N Natural Number");
            Console.WriteLine("Enter A Number");
            int Number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= Number; i++)
            {
                Sum += i;
            }
            Console.WriteLine(Sum);
        }
    }
}
