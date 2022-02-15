using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackMagic
{
    class Program
    {
        static char[] symbols = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'K' };
        static char Chosen;
        static void Show()
        {
            Random Magic = new Random();
            Chosen = symbols[Magic.Next(0, 10)];
            for (int i = 0;  i < 100; i +=5)
            {
                for (int k = 0; k<5;k++)
                {
                    if (i + k == 9 || i + k == 18 || i + k == 27 || i + k == 36 || i + k == 45 || i + k == 54 || i + k == 63 || i + k == 72 || i + k == 81 || i + k == 0) Console.Write($"{i + k} = {Chosen}\t");
                    else Console.Write( $"{i+k} = {symbols[Magic.Next(0, 10)]}\t");
                }
                Console.WriteLine();
            }
        }
        static void MAGIC()
        {
            Console.Clear();
            Console.WriteLine($"Your symbol is {Chosen}"+
                "\nCreated by DizzzM)");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("1)   Imagine 2 digit number" +
                "\n2)   Subtract from it each value digit"+
                "\n3)   Find result in the following list"+
                "\n4)   Press any key"+
                "\n5)   Oh, oh, oh it`s magic!");
            Show();
            Console.ReadKey();
            MAGIC();
            Console.ReadKey();
        }
    }
}
