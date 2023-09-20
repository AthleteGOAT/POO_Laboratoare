using System;



public abstract class Shape
{
    public abstract double CalculateArea();
}

public class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }
    public Circle() { }


    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}

public class Rectangle : Shape
{
    public double Length { get; set; }
    public double Width { get; set; }

    public Rectangle(double length, double width)
    {
        Length = length;
        Width = width;
    }

    public Rectangle() { }

    public override double CalculateArea()
    {
        return Length * Width;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Circle circle = new Circle();
        Rectangle rectangle = new Rectangle();
        Console.WriteLine("Introduceti ce aria carei figuri doriti sa aflati: ");
        Console.WriteLine("1 - Cerc;\n2 - Dreptunghi\n");
        int userAreaChoise = Convert.ToInt32(Console.ReadLine());
        switch (userAreaChoise)
        {
            case 1:
                Console.WriteLine("Introduceti raza cercului: ");
                int circleRadius = Convert.ToInt32(Console.ReadLine());
                circle.Radius = circleRadius;
                Console.WriteLine("Aria cercului este: " + circle.CalculateArea());
                break;
            case 2:
                Console.WriteLine("Introduceti Latimea: ");
                int rectangleWidth = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Introduceti Lungimea dreptunghiului: ");
                int rectangleLength = Convert.ToInt32(Console.ReadLine());
                rectangle.Length = rectangleLength;
                rectangle.Width = rectangleWidth;
                Console.WriteLine("Aria dreptunghiului este  : " + rectangle.CalculateArea());
                break;
            default:
                Console.WriteLine("Alegere gresita!");
                break;

        }

        


        Console.ReadKey();
    }
}

