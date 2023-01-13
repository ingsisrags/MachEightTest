// See https://aka.ms/new-console-template for more information
using Microsoft.VisualBasic;
using System.Runtime.CompilerServices;
using Test;

internal class Program
{
    private static void Main(string[] args)
    {

            Console.WriteLine("Ingres a list of numbers separated with coma(,)");

            var entrance = Console.ReadLine();

            Console.WriteLine("Ingres a number for the sum");

            var numForSum = Console.ReadLine();
            var arrayString = entrance?.Split(",");
            var listInt = Array.ConvertAll(arrayString, int.Parse);
            ICalculate _calculate = new Calculate( listInt , int.Parse(numForSum));
            _calculate.Cal();

            Console.ReadKey();


    }
}