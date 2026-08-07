using System;
using System.Collections.Generic;

public class Program
{
    static void Main(string[] args)
    {
	part1(); // cars
        employeesLab();
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

    /*
        Elon Musk (CEO)
        └── Tom Zhu (Senior VP)
            ├── Kevin (Web Developer)       
            ├── Sue (SpaceX Web Designer)   
            └── Mike (IT Manager)
                ├── Bob (X Tester)          
                └── Linda (SpaceX designer)
     */
    private static void employeesLab()
    {
        List<Employee> employees = new List<Employee>();

        Employee emp1 = new SkilledWorker("Bob", "X Tester");
        Employee emp2 = new Employee("Linda", "SpaceX designer");
        Employee emp3 = new SkilledWorker("Kevin", "Web Developer");
        Employee emp4 = new SkilledWorker("Sue", "SpaceX Web Designer");
        Manager manager1 = new Manager("Mike", "IT Manager");
        Manager SVP = new Manager("Tom Zhu", "Senior VP");
        Manager CEO = new Manager("Elon Musk", "CEO");

        manager1.AddEmployee(emp1);
        manager1.AddEmployee(emp2);

        SVP.AddEmployee(emp3);
        SVP.AddEmployee(emp4);

        SVP.AddEmployee(manager1);
        CEO.AddEmployee(SVP);
        Console.WriteLine(CEO.GetDetails());
    }

}


