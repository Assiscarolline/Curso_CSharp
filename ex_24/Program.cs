﻿using System;

namespace ex_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string genero;

            Console.Write("Digite o genero: ");
            genero = Console.ReadLine().ToUpper();

            while (genero != "F" && genero != "M")
            {
                Console.Write("Digite o genero");
                genero = Console.ReadLine();

            }
            Console.WriteLine("Bem vindos e bem vindas ao curso de C#!");
        } 
    }
}