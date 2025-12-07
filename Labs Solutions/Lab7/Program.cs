using System.Drawing;

namespace LabsSolutions.Lab7;

public class Program
{
    public static void Start()
    {
        Rectangle shape1 = new Rectangle(10, 20, Color.Black, new Point(1, 1));
        Circle shape2 = new Circle(10, Color.Black, new Point(1, 1));
        Sphere shape3 = new Sphere(10, Color.Black, new Point(1, 1));

        List<Shape> shapes = new List<Shape>();
        shapes.Add(shape1);
        shapes.Add(shape2);
        shapes.Add(shape3);

        foreach (var shape in shapes)
        {
            Console.WriteLine($"Circumfrence of {shape} is {shape.GetCircumfrence()}");
            Console.WriteLine($"Area of {shape} is {shape.GetArea()}");
            if(shape is Sphere)
                Console.WriteLine($"Volume of Sphere is ((Sphere)shape).GetVolume()");
        }


    }
}
