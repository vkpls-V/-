﻿using System;

namespace Tasks
{
    class MyHello
{
    static void Main(string[] args)
    {
        Console.WriteLine("myhello");
        string name;
        name = Console.ReadLine();
        Console.WriteLine($"Привет, {name}");
        Console.ReadKey();
    }
}
}