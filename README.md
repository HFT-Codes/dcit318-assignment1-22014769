# DCIT 318 Assignment 1

This repository contains three independent C# console applications for DCIT 318: Programming II.

## Applications

- **Grade Calculator** (`GradeCalculator.cs`)
  - Accepts a grade from 0 to 100.
  - Displays the corresponding letter grade:
    - 90 and above: A
    - 80-89: B
    - 70-79: C
    - 60-69: D
    - Below 60: F

- **Ticket Price Calculator** (`TicketPriceCalculator.cs`)
  - Calculates the movie ticket price from the customer's age.
  - The discounted price is GHC 7.00 for children aged 12 and below and senior citizens aged 65 and above.
  - The regular price is GHC 10.00.

- **Triangle Type Identifier** (`TriangleTypeIdentifier.cs`)
  - Accepts the lengths of three sides.
  - Identifies a valid triangle as equilateral, isosceles, or scalene.
  - Rejects invalid side combinations that cannot form a triangle.

## Running the Applications

Each file has its own `Main` method, so compile and run one file at a time. Open the required file in Visual Studio or Visual Studio Code with the C# extension, then run it.

With the .NET SDK installed, a temporary console project can also be created for any file:

```powershell
dotnet new console -n GradeCalculator
Copy-Item .\GradeCalculator.cs .\GradeCalculator\Program.cs -Force
dotnet run --project .\GradeCalculator
```

Replace `GradeCalculator` in the commands with `TicketPriceCalculator` or `TriangleTypeIdentifier` to run the other applications.
