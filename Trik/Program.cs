using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trik
{
    class Program
    {
        
        static void Main(string[] args)
        {
            bool leftCup = true;
            bool middleCup = false;
            bool rightCup = false;
            bool temp = false;

            foreach (var c in Console.ReadLine())
            {
                switch (c)
                {
                    case 'A': temp = middleCup; middleCup = leftCup; leftCup = temp; break;
                    case 'B': temp = middleCup; middleCup = rightCup; rightCup = temp; break;
                    case 'C': temp = rightCup; rightCup = leftCup; leftCup = temp; break;
                }
            }
            if (leftCup)
            {
                Console.WriteLine(1);
            }
            else if (middleCup)
            {
                Console.WriteLine(2);
            }
            else if (rightCup)
            {
                Console.WriteLine(3);
            }
        }
    }
}
