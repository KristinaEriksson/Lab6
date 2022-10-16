using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6
{   // Child class that derived from Animal the parent class
    class Parrot : Animal
    {
        // Field that only Parrot has
        double flySpeed;
        // Constructor with derived input parameters
        public Parrot(string name, int age, double weight, string color, string mood, double flySpeed) : base(name, age, weight, color, mood)
        {
            this.flySpeed = flySpeed;
        }
        // Constructor with default value
        public Parrot()
        {
            this.flySpeed = 5.5;
        }
        // Method
        public void Fly()
        {
            Console.WriteLine("Papegojan flyger.");
        }
        // Method that override the makeSound method in Animal the parent class
        public override void makeSound()
        {
            Console.WriteLine("Papegojan säger : Goddag!!");
        }
    }
}
