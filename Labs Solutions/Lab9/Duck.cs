namespace LabsSolutions.Lab9;

public class Duck : Bird
{
    public Duck(string name) : base(name)
    {
    }
    
    public override void makeNest()
    {
        Console.WriteLine("Making a nest like a Duck!");
    }
}
