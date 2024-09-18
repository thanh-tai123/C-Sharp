using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LESSON_2.BaiTapCoBan.Bai3
{
    class Animal
    {
        public string Name { get; set; }
        public Animal(string Name)
        {
            this.Name = Name;
        }
        public virtual void makeSound()
        {
            Console.WriteLine("Animal");
        }
    }
    class Dog : Animal
    {
        public Dog(string Name) : base(Name) { }

        public override void makeSound()
        {
            Console.WriteLine($"Ten {Name} keu Dog..");
        }
    }
    class Cat : Animal
    {
        public Cat(string Name) : base(Name) { }
        public override void makeSound()
        {
            Console.WriteLine($"Ten {Name} keu Cat..");
        }
    }
    class Bird : Animal
    {
        public Bird(string Name) : base(Name) { }
        public override void makeSound()
        {
            Console.WriteLine($"Ten {Name} keu Bird..");
        }
    }

}