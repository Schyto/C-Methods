﻿using System;

namespace MethodsExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello - What is your first name?");
        var userName = Console.ReadLine();

            Console.WriteLine($"Hi, {userName}. What is your favorite color?");
        var color = Console.ReadLine();

            Console.WriteLine($"{color} is my favorite too! What is your favorite animal?");
        var animal = Console.ReadLine();

            Console.WriteLine($"{animal}'s are great! Now what is your favorite band?");
        var band = Console.ReadLine();
        }
    }
}