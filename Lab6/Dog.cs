using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6
{
    // Child class that derived from Animal the parent class
    class Dog : Animal
    {
        // Field that only Dog has
        bool huntingInstinct;

        // Constructor with derived input parameters
        public Dog(string name, int age, double weight, string color, string mood, bool huntingInstinct) : base(name,age,weight,color,mood)
        {
            this.huntingInstinct = huntingInstinct;
        }
        // Constructor with default value 
        public Dog()
        {
            this.huntingInstinct = true;
        }
        // Method
        public void hunting()
        {
            Console.WriteLine("Hunden är bra hjälp vid jakt.");
        }
        // Method that override the makeSound method in Animal the parent class
        public override void makeSound()
        {
            Console.WriteLine("Hunden säger : Voff!");
        }
    }
}
