﻿using System;

namespace Felande
{
    class Program
    {

        static void Main(string[] args)
        { 
    

            Console.WriteLine("Hej, välkommen till uppgift 1!");
            Console.WriteLine("Tryck på en knapp för att fortsätta...");
            Console.ReadKey();

            String name = "Linda";

            
            Console.WriteLine($"Här ser du en sträng representerat av variablen 'namn': {name}");
            Console.WriteLine("Tryck på en knapp för att fortsätta...");
            Console.ReadKey();

            bool sant = true;

            Console.WriteLine();
            Console.WriteLine($"Boolean eller bool är en användbar datatyp när man vill avgör om något är sant eller falskt. Här ser vi variablen sants värde: {sant}");
            Console.WriteLine("Tryck på en knapp för att fortsätta...");
            Console.ReadKey();

          

            DateTime datum = DateTime.Now;

            Console.WriteLine();
            Console.WriteLine($"Här ser du ett datum representerat av variablen 'datum': {datum}");
            Console.WriteLine("Tryck på en knapp för att fortsätta...");
            Console.ReadKey();

            double decimaltal = 0.5;

        Console.WriteLine();
            Console.WriteLine($"Här ser du ett flyttal representerat av variablen 'decimaltal': {decimaltal}");
            Console.WriteLine("Tryck på en knapp för att fortsätta...");

            int helttal = 30;

        Console.WriteLine();
            Console.WriteLine($"Här ser du ett heltal representerat av variablen 'heltal': {helttal}");
            Console.WriteLine("Tryck på en knapp för att fortsätta...");
            Console.ReadKey();

            Console.ReadKey();

        }
    }
}


           
