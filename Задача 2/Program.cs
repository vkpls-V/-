using System;


namespace MySumm
{
    class MySumm
    {
        static void Main(string[] args)
        {
            Console.WriteLine("mysum");
            Console.WriteLine(args.Length);
            Console.WriteLine(Convert.ToInt32(args[0]) + Convert.ToInt32(args[1]));
        }
    }
}