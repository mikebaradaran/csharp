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

        Employee emp1 = new Employee("Bob", "Tester");
        Employee emp2 = new Employee("Linda", "Developer");
        Employee emp3 = new SkilledWorker("Kevin", "Developer");
        Employee emp4 = new SkilledWorker("Sue", "Designer");

        Manager manager1 = new Manager("Steve", "IT Manager");
        manager1.AddEmployee(emp1);
        manager1.AddEmployee(emp2);

        Manager manager2 = new Manager("Mike", "CEO");
        manager2.AddEmployee(emp3);
        manager2.AddEmployee(emp4);

        manager2.AddEmployee(manager1);
        Console.WriteLine(manager2.GetDetails());
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
