using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1_2
{
    internal class Input
    {
        public static int InputMin(string msg)
        {
            Console.WriteLine(msg);
            while (true)
            {
                string input = Console.ReadLine();
                if (byte.TryParse(input, out byte res) && res <= 60 && res >= 0)
                {
                    return res;
                }
                else
                {
                    Console.WriteLine("Введите число от 0 до 60");
                }
            }
        }
        public static int InputHour(string msg)
        {
             Console.WriteLine(msg);
                while (true)
                {
                    string input = Console.ReadLine();
                    if (byte.TryParse(input, out byte res) && res <= 24 && res >= 0)
                    {
                        return res;
                    }
                    else
                    {
                        Console.WriteLine("Введите число от 0 до 24");
                    }
                }
        }
    }
}
