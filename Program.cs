using System;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
class Program
{
    static void Main()
    {
        Console.Write("Hi there!\nThis is my first steps into making a physics engine in C#.\n");
        Console.WriteLine("What do you want to do here?");
        Console.WriteLine("1-Add two vectors\n2-Subtract two vectors\n3-Scale a vector\n4-Magnitude of a vector\n5-Normalize a vector\n6-Dot product of a vector\n7-Nothing");
        char usrChoice = Console.ReadKey().KeyChar;
        switch (usrChoice)
        {
            case '1':
                vec2 a = new vec2();
                vec2 b = new vec2();
                Console.WriteLine("\nEnter the x and y values for the first vector:");
                if (float.TryParse(Console.ReadLine(), out float x))
                {
                    a.x = x;
                }
                else
                {
                    throw new ArgumentException("Invalid number!");
                }
                if (float.TryParse(Console.ReadLine(), out float y))
                {
                    a.y = y;
                }
                else
                {
                    throw new ArgumentException("Invalid number!");
                }
                Console.WriteLine("Enter the x and y values for the second vector:");
                if (float.TryParse(Console.ReadLine(), out float x2))
                {
                    b.x = x2;
                }
                else
                {
                    throw new ArgumentException("Invalid number!");
                }
                if (float.TryParse(Console.ReadLine(), out float y2))
                {
                    b.y = y2;
                }
                else
                {
                    throw new ArgumentException("Invalid number!");
                }
                vec2 result = a.add(b);
                Console.WriteLine($"The result for the addition is [ {result.x}, {result.y} ]");
                break;
            case '2':
                vec2 d = new vec2();
                vec2 c = new vec2();
                Console.WriteLine("\nEnter the x and y values for the first vector:");
                if (float.TryParse(Console.ReadLine(), out float x3))
                {
                    d.x = x3;
                }
                else
                {
                    throw new ArgumentException("Invalid number!");
                }
                if (float.TryParse(Console.ReadLine(), out float y3))
                {
                    d.y = y3;
                }
                else
                {
                    throw new ArgumentException("Invalid number!");
                }
                Console.WriteLine("Enter the x and y values for the second vector:");
                if (float.TryParse(Console.ReadLine(), out float x4))
                {
                    c.x = x4;
                }
                else
                {
                    throw new ArgumentException("Invalid number!");
                }
                if (float.TryParse(Console.ReadLine(), out float y4))
                {
                    c.y = y4;
                }
                else
                {
                    throw new ArgumentException("Invalid number!");
                }
                vec2 result2 = d.sub(c);
                Console.WriteLine($"The result for the subtraction is [ {result2.x}, {result2.y} ]");
                break;
            case '3':
                vec2 e = new vec2();
                Console.WriteLine("\nEnter the x and y values for the vector:");
                if (float.TryParse(Console.ReadLine(), out float x5))
                {
                    e.x = x5;
                }
                else
                {
                    throw new ArgumentException("Invalid number!");
                }
                if (float.TryParse(Console.ReadLine(), out float y5))
                {
                    e.y = y5;
                }
                else
                {
                    throw new ArgumentException("Invalid number!");
                }
                Console.WriteLine("Enter the scalar value:");
                if (float.TryParse(Console.ReadLine(), out float scalar))
                {
                    vec2 result3 = e.scale(scalar);
                    Console.WriteLine($"The result for the scaling is [ {result3.x}, {result3.y} ]");
                }
                else
                {
                    throw new ArgumentException("Invalid number!");
                }
                break;
            case '4':
                vec2 f = new vec2();
                Console.WriteLine("\nEnter the x and y values for the vector:");
                if (float.TryParse(Console.ReadLine(), out float x6))
                {
                    f.x = x6;
                }
                else
                {
                    throw new ArgumentException("Invalid number!");
                }
                if (float.TryParse(Console.ReadLine(), out float y6))
                {
                    f.y = y6;
                }
                else
                {
                    throw new ArgumentException("Invalid number!");
                }
                float result4 = f.mag();
                Console.WriteLine($"The magnitude of the vector is {result4}");
                break;
            case '5':
                vec2 g = new vec2();
                Console.WriteLine("\nEnter the x and y values for the vector:");
                if (float.TryParse(Console.ReadLine(), out float x7))
                {
                    g.x = x7;
                }
                else
                {
                    throw new ArgumentException("Invalid number!");
                }
                if (float.TryParse(Console.ReadLine(), out float y7))
                {
                    g.y = y7;
                }
                else
                {
                    throw new ArgumentException("Invalid number!");
                }
                vec2 result5 = g.norm();
                Console.WriteLine($"The normalized vector is [ {result5.x}, {result5.y} ]");
                break;
            case '6':
                vec2 h = new vec2();
                vec2 i = new vec2();
                Console.WriteLine("\nEnter the x and y values for the first vector:");
                if (float.TryParse(Console.ReadLine(), out float x8))
                {
                    h.x = x8;
                }
                else
                {
                    throw new ArgumentException("Invalid number!");
                }
                if (float.TryParse(Console.ReadLine(), out float y8))
                {
                    h.y = y8;
                }
                else
                {
                    throw new ArgumentException("Invalid number!");
                }
                Console.WriteLine("Enter the x and y values for the second vector:");
                if (float.TryParse(Console.ReadLine(), out float x9))
                {
                    i.x = x9;
                }
                else
                {
                    throw new ArgumentException("Invalid number!");
                }
                if (float.TryParse(Console.ReadLine(), out float y9))
                {
                    i.y = y9;
                }
                else
                {
                    throw new ArgumentException("Invalid number!");
                }
                float result6 = h.dot(i);
                Console.WriteLine($"The dot product of the two vectors is {result6}");
                break;
            case '7':
                Console.WriteLine("\nExiting the program.");
                break;
            default:
                Console.WriteLine("\nInvalid choice. Exiting the program.");
                break;
        }
    }
}