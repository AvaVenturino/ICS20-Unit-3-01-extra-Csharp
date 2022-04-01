// Created by: Ava Venturino
// Created on: March 2022
//
// This program accepts user input

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function accepts user input
        int baseA;
        int baseB;
        int height;

        Console.WriteLine("This program finds the area of a trapezoid.");
        Console.WriteLine("");
        Console.WriteLine("Formula = (( base a + base b) / 2) x height.");
        Console.WriteLine("");
        Console.Write("Enter the base a of the trapezoid (mm): ");
        baseA = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the base b of the trapezoid (mm): ");
        baseB = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the height of the triangle (mm): ");
        height = Convert.ToInt32(Console.ReadLine());

        Double area = ((baseA + baseB) / 2) * height;

        Console.WriteLine("");
        Console.Write("Area of the trapezoid = " + area + " mm³");
        Console.ReadKey();
        Console.WriteLine("\nDone.");
    }
}