namespace LabsSolutions.Lab1;
public class Program
{
    public static void Start()
    {
        // Console.WriteLine("Hello, World!");
        var lifeInsurance = new LifeInsurance();
        double money = lifeInsurance.Calculate();
        Console.WriteLine($"Please pay ${money} each month.");
    }
}
