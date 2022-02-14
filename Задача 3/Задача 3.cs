using System;

namespace Numbers
{
    class Program
        //Плисова Вика 2-1ис
    {
        static void Main(string[] args)
        {
            int a, b;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            if (GetLength(a, b))
            {
                Console.WriteLine("Цифр в числе A больше, чем в B");
            }
            else if (GetLengthInverse(a, b))
            {
                Console.WriteLine("Цифр в числе B больше, чем в A");
            }
            else
            {
                Console.WriteLine("Кол-во цифр одинаково в обоих числах");
            }
        }

        static bool GetLength(int A, int B)
        {
            while (A > 0 && B > 0)
            {
                A = A / 10;
                B = B / 10;
            }

            if (A > B)
                return true;
            return false;
        }
        static bool GetLengthInverse(int A, int B)
        {
            while (A > 0 && B > 0)
            {
                A = A / 10;
                B = B / 10;
            }

            if (A < B)
                return true;
            return false;
        }
    }
}