using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoops
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to For Loop Exercies");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("1 : Display First 10 Natyral Number");
                Console.WriteLine("Enter A Option");
                int Option = Convert.ToInt32(Console.ReadLine());
                switch(Option)
                {
                    case 1:
                        NaturalNumber no = new NaturalNumber();
                        no.Number();
                        break;
                    case 2:
                        flag = false;
                        break;
                }
                Console.ReadLine();
            }


        }
    }
}
