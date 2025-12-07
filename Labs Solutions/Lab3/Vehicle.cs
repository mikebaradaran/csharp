namespace LabsSolutions.Lab3;
public class Vehicle
{
    private int distanceTravelled { get; set; }
    private int lane;
    private RegistrationPlate registrationPlate;

    private static int Count { get; set; }
    private const int MAX_SPEED = 200;
    private const int MIN_SPEED = 0;

    private int speed;

    public int Speed
    {
        get { return speed; }
        set
        {
            if (value > MAX_SPEED) value = MAX_SPEED;
            if (value < MIN_SPEED) value = MIN_SPEED;

            speed = value;
        }
    }

    public Vehicle(int lane, int speed)
    {
        registrationPlate = RegistrationPlateFactory.getNextRegistrationPlate();
        if (this.registrationPlate == null)
            Console.WriteLine("No registration plates were available.");

        Vehicle.Count++;
        this.lane = lane;
        this.Speed = speed;
    }
    public int getDistanceTravelled()
    {
        return this.distanceTravelled;
    }

    public void brake(int amount)
    {
        Speed -= amount;
    }

    public void accelerate(int amount)
    {
        Speed += amount;
        distanceTravelled += Speed;
    }

    public string GetDetails()
    {
        return $"Lane: {lane} , Speed: {Speed}, Distance travelled: {distanceTravelled}";
    }
}

