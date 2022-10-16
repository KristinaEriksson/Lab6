using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6
{
    // Child class that derived from Animal the parent class
    class Cat : Animal
    {
        // Field that only Cat has
        int numLegs;
        // Constructor with derived input parameters
        public Cat(string name, int age, double weight, string color, string mood, int numLegs) : base(name, age, weight, color, mood)
        {
            this.numLegs = numLegs;
        }
        // Constructor with default value 
        public Cat()
        {
            this.numLegs = 4;
        }
        // Method
        public void Walk()
        {
            Console.WriteLine("Katten går på fyra ben.");
        }
        // Method that override the makeSound method in Animal the parent class
        public override void makeSound()
        {
            Console.WriteLine("Katten säger : Mjau!");
        }
    }
}
