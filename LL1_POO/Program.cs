using System;

public class Node
{
    public int Data;
    public Node Next;

    public Node(int data)
    {
        Data = data;
        Next = null;
    }
}

public class LinkedList
{
    public Node Head;

    public void Add(int data)
    {
        Node newNode = new Node(data);
        if (Head == null)
        {
            Head = newNode;
        }
        else
        {
            Node current = Head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }
    }

    public void AddToNthPosition(int data, int position)
    {
        

        Node newNode = new Node(data);

        if (position == 0)
        {
            newNode.Next = Head;
            Head = newNode;
            return;
        }

        Node current = Head;
        int currentPosition = 0;

        while (current != null && currentPosition < position - 1)
        {
            current = current.Next;
            currentPosition++;
        }

        if (current == null)
        {
            Console.WriteLine("Pozitia iese din limitele listei.");
            return;
        }

        newNode.Next = current.Next;
        current.Next = newNode;
    }

    public void Print()
    {
        Node current = Head;
        while (current != null)
        {
            Console.Write(current.Data + " ");
            current = current.Next;
        }
        Console.WriteLine();
    }

    public void Pop()
    {

        Head = Head.Next;
    }

    public void DeleteNthElement(int n)
    {
        

        if (n == 0)
        {
            if (Head != null)
            {
                Head = Head.Next;
            }
            return;
        }

        Node current = Head;
        int currentPosition = 0;

        while (current != null && currentPosition < n - 1)
        {
            current = current.Next;
            currentPosition++;
        }

        if (current == null || current.Next == null)
        {
            Console.WriteLine("Position exceeds the length of the list. Element not deleted.");
            return;
        }

        current.Next = current.Next.Next;
    }

    public void Swap(int position1, int position2)
    {
        if (position1 < 0 || position2 < 0)
        {
            Console.WriteLine("Invalid positions. Positions should be non-negative integers.");
            return;
        }

        if (position1 == position2)
        {
            // No need to swap if positions are the same
            return;
        }

        Node prev1 = null, curr1 = Head;
        int currentPosition1 = 0;

        while (curr1 != null && currentPosition1 < position1)
        {
            prev1 = curr1;
            curr1 = curr1.Next;
            currentPosition1++;
        }

        Node prev2 = null, curr2 = Head;
        int currentPosition2 = 0;

        while (curr2 != null && currentPosition2 < position2)
        {
            prev2 = curr2;
            curr2 = curr2.Next;
            currentPosition2++;
        }

        if (curr1 == null || curr2 == null)
        {
            Console.WriteLine("One or both positions exceed the length of the list. Elements not swapped.");
            return;
        }

        // Perform the swap by updating the Next pointers
        if (prev1 != null)
        {
            prev1.Next = curr2;
        }
        else
        {
            Head = curr2;
        }

        if (prev2 != null)
        {
            prev2.Next = curr1;
        }
        else
        {
            Head = curr1;
        }

        Node temp = curr1.Next;
        curr1.Next = curr2.Next;
        curr2.Next = temp;
    }




}


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
                Console.WriteLine("Aria dreptunghiului este: " + rectangle.CalculateArea());
                break;
            default:
                Console.WriteLine("Alegere gresita!");
                break;

        }

        LinkedList list = new LinkedList();
        list.Add(1);
        list.Add(2);
        list.Add(3);
        list.AddToNthPosition(4, 0);
        list.Pop();
        list.Print();
        list.DeleteNthElement(2);
        list.Swap(0, 1);
        list.Print();


        Console.ReadKey();
    }
}
