using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1_1
{
    class Input
    {
        public static uint InputUInt(string msg)
        {
            uint res;
            string input;
            while (true)
            {
                Console.WriteLine(msg);
                input = Console.ReadLine();
                if(uint.TryParse(input, out res))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Число должно быть натуральным");
                }
            }
            return res;
        }
        public static bool InputBool(string msg)
        {
            string input;
            while (true) 
            {
                Console.WriteLine(msg);
                input = Console.ReadLine();
                if (input == "true")
                {
                    return true;
                }
                if (input == "false")
                {
                    return false;
                }
                Console.WriteLine("Введите true или false ");
            }
        }
        public static string InputString(string msg)
        {
            string input;
            while (true)
            {
                Console.WriteLine(msg);
                input = Console.ReadLine();
                if((!string.IsNullOrWhiteSpace(input)))
                {
                    return input;
                }
                else
                {
                    Console.WriteLine("Пустая строка ");
                }
            }
        }
    }
}
