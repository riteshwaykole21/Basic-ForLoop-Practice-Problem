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
                Console.WriteLine("2 : Sum Of Ten Natural Number");
                Console.WriteLine("3 : Sum Of N Natural Number");
                Console.WriteLine("4 : Enter Ten Natural Number");
                Console.WriteLine("5 : Cube Of The Number");
                Console.WriteLine("6 : Multiplication Table");
                Console.WriteLine("7 : pattern of ");
                Console.WriteLine("8 : Number Pattern");
                Console.WriteLine("9 : Same Number Pattern");
                Console.WriteLine("10 : Increased Pattern");
                Console.WriteLine("Enter A Option");
                int Option = Convert.ToInt32(Console.ReadLine());
                switch(Option)
                {
                    case 1:
                        NaturalNumber no = new NaturalNumber();
                        no.Number();
                        break;
                    case 2:
                        SumOfNumber sumOfNumber = new SumOfNumber();
                        sumOfNumber.Number();
                        break;
                    case 3:
                        NTerm term = new NTerm();
                        term.Sum();
                        break;
                    case 4:
                        FindSum findSum = new FindSum();
                        findSum.Find();
                        break;
                    case 5:
                        CubeNumber cubeNumber = new CubeNumber();
                        cubeNumber.cube();
                        break;
                    case 6:
                        Table table = new Table();
                        table.Program();
                        break;
                    case 7:
                        Trangle trangle = new Trangle();
                        trangle.Input();
                        break;
                    case 8:
                        Pattern pattern = new Pattern();
                        pattern.Number();
                        break;
                    case 9:
                        Same same = new Same();
                        same.Pattern();
                        break;
                    case 10:
                        Increased increased = new Increased();
                        increased.Number();
                        break;
                    case 12:
                        flag = false;
                        break;
                }
                Console.ReadLine();
            }


        }
    }
}
