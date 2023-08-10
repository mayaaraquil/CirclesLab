using CirclesLab;
using System.ComponentModel.DataAnnotations;
using Validator = CirclesLab.Validator;

static void Main(string[] args)
{
    Console.WriteLine("Circle Application");

    double radius = Validator.GetValidRadiusInput();
    Circle circle = new Circle(radius);

    Console.WriteLine($"Diameter: {circle.CalculateDiameter()}");
    Console.WriteLine($"Circumference: {circle.CalculateCircumference()}");
    Console.WriteLine($"Area: {circle.CalculateArea()}");

    while (Validator.GetYesNoInput("Do you want the circle to grow?"))
    {
        circle.Grow();
        Console.WriteLine($"Cirlce has grown. New radius is {circle.GetRadius()}");
        Console.WriteLine($"Diameter: {circle.CalculateDiameter()}");
        Console.WriteLine($"Circumference: {circle.CalculateCircumference()}");
        Console.WriteLine($"Area: {circle.CalculateArea()}");
    }
    Console.WriteLine($"Okay then, Bye bye! Circle's final radius is {circle.GetRadius()}");
}
