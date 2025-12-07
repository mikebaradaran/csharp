namespace LabsSolutions.Lab8;

public class Program
{
    public static void Start()
    {
        part1();
        part2();
    }

    private static void part2()
    {
        List<Employee> employees = new List<Employee>();
        employees.Add(new Employee("Bob", "Tester"));
        employees.Add(new Employee("Linda", "Developer"));

        Manager manager = new Manager("Mike", "Trainer");
        manager.employees = employees;
        Console.WriteLine(manager.GetDetails());
    }

    private static void part1()
    {
        List<Car> cars = new List<Car>();
        cars.Add(new Car("Ford"));
        cars.Add(new RacingCar("Ferrari"));
        cars.Add(new Car("BMW"));
        processCars(cars);
    }

    private static void processCars(List<Car> cars)
    {
        foreach (Car car in cars)
        {
            car.GetToSixty();
            Console.WriteLine(car.GetDetails());
        }
    }

}
