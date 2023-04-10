using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoops
{
    public class CubeNumber
    {
        public void cube()
        {
            Console.WriteLine("Enter A Number");
            int Number = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < Number; i++)
            {
                Console.WriteLine("Number is : {0} and cube of the {1} is : {2}\n", i ,i ,(i*i*i));
            }
        }
    }
}
