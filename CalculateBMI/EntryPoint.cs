using System;
///first completed Kata.
///Body Mass Index calculator

class EntryPoint
{ 
static void Main()
{
    Console.Write("Enter your weight in pounds: ");
    double weight = Convert.ToDouble(Console.ReadLine());
    Console.Write("Enter your height in inches: ");
    double height = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine(Bmi(weight, height));
}

public static string Bmi(double weight, double height)
{
    string bodyMass = string.Empty;
    double bmi = ((weight / Math.Pow(height, 2)));

    if (bmi <= 18.5) { bodyMass = "Underweight"; }
    else if (bmi <= 25.0) { bodyMass = "Normal"; }
    else if (bmi <= 30.0) { bodyMass = "Overweight"; }
    else if (bmi > 30) { bodyMass = "Obese"; }
    return bodyMass;
}
}

