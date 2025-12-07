namespace LabsSolutions.Lab10;

public abstract class Bird : Animal
{
    public Bird(string name) : base(name)
    {
        this.animalType = AnimalType.Bird;
    }

    public abstract void makeNest();
}

public class Duck : Bird, Flyable, Swimmable
{

    public Duck(string name) : base(name)
    {
    }

    public override void makeNest()
    {
        Console.WriteLine("Making a nest like a Duck!");

    }
    public override void move()
    {
        Console.WriteLine("Moveing like a Duck!");

    }
    public virtual void swim()
    {
        Console.WriteLine("Diving under water like a Duck!");

    }
    public void fly()
    {
        Console.WriteLine("Flying like a Duck!");
    }

}

public class Fish : Animal, Swimmable
{
    public Fish(string name) : base(name)
    {
        animalType = AnimalType.Fish;
    }

    public override void move()
    {
        Console.WriteLine("Moving like a fish!");

    }

    public virtual void swim()
    {
        Console.WriteLine("Swiming like a fish!");

    }

}


public class Penguin : Bird, Swimmable
{
    public Penguin(string name) : base(name)
    {
    }
    public override void makeNest()
    {
        Console.WriteLine("Making a nest like a Penguin!");
    }

    public void swim()
    {
        Console.WriteLine("Swiming like a Penguin!");

    }

    public override void move()
    {
        Console.WriteLine("Moveing like a Penguin!");
    }
}



