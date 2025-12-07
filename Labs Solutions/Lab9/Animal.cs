using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabsSolutions.Lab9;
    public abstract class Animal
    {
        internal AnimalType animalType;
        internal string Name { get; set; }

    public Animal(string name)
    {
        Name = name;
    }

    }
