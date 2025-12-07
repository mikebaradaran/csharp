using System.Drawing;

namespace LabsSolutions.Lab7;
public class Shape
{
    public Color Colour { get; set; }
    Point Position { get; set; }

    public Shape(Color colour, Point position)
    {
        this.Colour = colour;
        this.Position = position;
    }
    public virtual double GetArea()
    {
        return 0;
    }
    public virtual double GetCircumfrence()
    {
        return 0;
    }

    public virtual string GetDetails()
    {
        return $"Colour: {Colour}, X: {Position.X}, Y: {Position.Y}";
    }
}

public class Rectangle : Shape
{
    int sideA, sideB;

    public Rectangle(int sideA, int sideB, Color colour, Point position)
    : base(colour, position)
    {
        this.sideA = sideA;
        this.sideB = sideB;
    }

    public override double GetArea()
    {
        return sideA * sideB;
    }
    public override double GetCircumfrence()
    {
        return 2 * (sideA + sideB);
    }

    public override string GetDetails()
    {
        return base.GetDetails() + $", SideA:{sideA}, SideB: {sideB}, Area: {GetArea()}, Circumfrence: {GetCircumfrence()}";
    }
}

public class Circle : Shape
{
    protected int radius;

    public Circle(int radius, Color colour, Point position)
    : base(colour, position)
    {
        this.radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * this.radius * this.radius;
    }
    public override double GetCircumfrence()
    {
        return 2 * Math.PI * this.radius;
    }

    public override string GetDetails()
    {
        return base.GetDetails() + $", Radius: {radius}, Area: {GetArea()}, Circumfrence: {GetCircumfrence()}";
    }
}
public class Sphere : Circle
{
    public Sphere(int radius, Color colour, Point position)
        : base(radius, colour, position)
    {
    }
    public double GetVolume()
    {
        return (4 / 3F) * Math.PI * Math.Pow(this.radius, 3);
    }
    
    public override string GetDetails()
    {
        return base.GetDetails() + ", Volume:" + GetVolume();
    }
}
