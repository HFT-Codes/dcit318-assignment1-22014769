using System;

class TicketPriceCalculator
{
    const decimal RegularPrice = 10m;
    const decimal DiscountedPrice = 7m;

    static void Main()
    {
        Console.WriteLine("Ticket Price Calculator");
        int age = ReadAge();
        decimal ticketPrice = age <= 12 || age >= 65 ? DiscountedPrice : RegularPrice;

        Console.WriteLine($"Ticket price: GHC {ticketPrice:0.00}");
    }

    static int ReadAge()
    {
        while (true)
        {
            Console.Write("Enter your age: ");
            if (int.TryParse(Console.ReadLine(), out int age) && age >= 0)
            {
                return age;
            }

            Console.WriteLine("Invalid age. Please enter a non-negative whole number.");
        }
    }
}
