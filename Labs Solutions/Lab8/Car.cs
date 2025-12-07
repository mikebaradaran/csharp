namespace LabsSolutions.Lab8;

public class Car
{
    private string Model { get; set; }
    protected int Speed { get; set; }

    public Car(string model)
    {
        Model = model;
    }

    public void GetToSixty()
    {
        Speed = 60;
    }
    public virtual void Accelerate(int seconds)
    {
        Speed = Speed + (5 * seconds);
    }
    public virtual string GetDetails()
    {
        return "Model:" + Model + ", Speed:" + Speed;
    }
}

