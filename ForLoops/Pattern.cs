﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoops
{
    public class Pattern
    {
        public void Number()
        {
            int K = 4;  
            for (int i = 1; i <= K; i++)
            {
                for (int j = 1;j <= i;j++)
                    Console.Write(j);
                Console.Write("\n");
            }
        }
    }
}
