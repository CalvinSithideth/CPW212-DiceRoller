using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller
{
    class Program
    {
        static void Main(string[] args)
        {
            Die die1 = new Die();
            Die die2 = new Die();
            Die die3 = new Die();

            Console.WriteLine(die1.Roll());
            Console.WriteLine(die2.Roll());
            Console.WriteLine(die3.Roll());
            Console.ReadKey();
        }
    }
}
