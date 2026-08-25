using System;

class TriangleTypeIdentifier
{
    static void Main()
    {
        Console.WriteLine("Triangle Type Identifier");
        double firstSide = ReadSide("first");
        double secondSide = ReadSide("second");
        double thirdSide = ReadSide("third");

        if (firstSide + secondSide <= thirdSide ||
            firstSide + thirdSide <= secondSide ||
            secondSide + thirdSide <= firstSide)
        {
            Console.WriteLine("The sides do not form a valid triangle.");
        }
        else if (firstSide == secondSide && secondSide == thirdSide)
        {
            Console.WriteLine("Triangle type: Equilateral");
        }
        else if (firstSide == secondSide || firstSide == thirdSide || secondSide == thirdSide)
        {
            Console.WriteLine("Triangle type: Isosceles");
        }
        else
        {
            Console.WriteLine("Triangle type: Scalene");
        }
    }

    static double ReadSide(string sideName)
    {
        while (true)
        {
            Console.Write($"Enter the length of the {sideName} side: ");
            if (double.TryParse(Console.ReadLine(), out double sideLength) && sideLength > 0)
            {
                return sideLength;
            }

            Console.WriteLine("Invalid side length. Please enter a value greater than 0.");
        }
    }
}
