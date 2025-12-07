using System.Reflection;

namespace LabsSolutions.Lab8;
public class RacingCar : Car
{
    string Driver { get; set; }
    int TurboFactor { get; set; }

    public RacingCar(string model) : base(model)
    {
    }
    public void race()
    {
        Console.WriteLine("Racing!");
    }
    public override void Accelerate(int seconds)
    {
        base.Accelerate(seconds + Speed * TurboFactor);
    }

    public override string GetDetails()
    {
        return base.GetDetails() + "Driver:" + Driver + ", Turbo factor:" + TurboFactor;
    }


}