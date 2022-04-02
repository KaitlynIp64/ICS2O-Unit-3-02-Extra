// Created by: Kaitlyn Ip
// Created on: Mar 2022
//
// This program finds the perimeter of a right triangle.

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function accepts user input
        float Base;
        float Width;
        float Height;
        //input
        Console.WriteLine("This program finds the volume of a pyramid.");
        Console.WriteLine("");
        Console.Write("Enter the base: ");
        Base = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the width: ");
        Width = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the height: ");
        Height = Convert.ToInt32(Console.ReadLine());
        //process
        Double volume = (Base * Width * Height) / 3;
        //output
        Console.WriteLine("");
        Console.Write("Volume: " + volume.ToString("0.00") + "mm³");
        Console.ReadKey();
        Console.WriteLine("\nDone.");
    }
}