using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabsSolutions.Lab9;

public class Program
{
    public static void Start()
    {
        Animal[] animals = { new Duck("Donald"), new Penguin("Happy feet"), new Fish("Mino") };
        foreach (Animal animal in animals)
        {
            Console.WriteLine(animal.Name);
            if (animal is Bird)
            {
                ((Bird)animal).makeNest();
            }
        }

    }
}
