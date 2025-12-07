namespace LabsSolutions.Lab9;
public class Penguin : Bird
{
    public Penguin(string name) : base(name)
    {
    }

    public override void makeNest()
    {
        Console.WriteLine("Making a nest like a Penguin!");
    }
}
