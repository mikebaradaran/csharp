using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabsSolutions.Lab10;
public abstract class Animal : Moveable
{
    internal AnimalType animalType;

    private string name;

    public Animal(string name)
    {
        this.name = name;
    }

    public string getName()
    {
        return name;
    }

    public virtual void move()
    {
        Console.WriteLine("Animal moving!");
    }
}
