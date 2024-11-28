// See https://aka.ms/new-console-template for more information
using CircleLab;

Console.WriteLine("Hello, World!");

/*  The application prompts the user to enter a radius; the user may enter a number with decimals (double) */
Console.WriteLine("Welcome to the Circle Tester");
Circle circleObject = new Circle(0);
Console.Write("Enter radius: ");
while (true)
{
    double radius = double.Parse(Console.ReadLine());
    circleObject = new Circle(radius);
    try
    {
        circleObject.GetPositiveNumber(radius);
        break;
    }
    catch (ArgumentException)
    {
        //circleObject.GetPositiveNumber(6.0);
        Console.Write("Invalid number. Try again: ");
    }
}
CircleCalculations();

while (true)
{
    Console.Write("Should the circle grow? Y/N: ");
    string userAnswer = Console.ReadLine();

    if (userAnswer.ToLower() == "y")
    {
        Console.WriteLine("The circle is magically growing.");
        circleObject.Grow();
        //Console.WriteLine($"Diameter: {circleObject.CalculateDiameter()}");
        CircleCalculations();
        //Console.WriteLine(radius);
    }
    else
    {
        Console.WriteLine($"Goodbye! The circle's final radius is {circleObject.GetRadius()} ");
        break;
    }
}
void CircleCalculations()
{
    Console.WriteLine($"Diameter: {circleObject.CalculateDiameter()}");
    Console.WriteLine($"Circumference: {circleObject.CalculateCircumference()}");
    Console.WriteLine($"Area: {circleObject.CalculateArea()}");
}

Console.WriteLine("Press any key to quit.");
Console.ReadKey();