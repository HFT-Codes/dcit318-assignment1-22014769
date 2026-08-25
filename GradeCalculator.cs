using System;

class GradeCalculator
{
    static void Main()
    {
        Console.WriteLine("Grade Calculator");
        double grade = ReadGrade();

        string letterGrade;
        if (grade >= 90)
        {
            letterGrade = "A";
        }
        else if (grade >= 80)
        {
            letterGrade = "B";
        }
        else if (grade >= 70)
        {
            letterGrade = "C";
        }
        else if (grade >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        Console.WriteLine($"Letter grade: {letterGrade}");
    }

    static double ReadGrade()
    {
        while (true)
        {
            Console.Write("Enter a numerical grade between 0 and 100: ");
            if (double.TryParse(Console.ReadLine(), out double grade) && grade >= 0 && grade <= 100)
            {
                return grade;
            }

            Console.WriteLine("Invalid grade. Please enter a value from 0 to 100.");
        }
    }
}
