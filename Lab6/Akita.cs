using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6
{
    // Class that inheriting from Dog
    class Akita : Dog
    {
        // Field that only Akita has
        string breed;
        // Constructor with derived input parameters
        public Akita(string name, int age, double weight, string color, string mood, bool huntingInstinct, string breed) : base(name, age, weight, color, mood, huntingInstinct)
        {
            this.breed = breed;
        }
        // Constructor with default value
        public Akita()
        {
            this.breed = "Akita Inu, japansk hundras";
        }
        // Method
        public void bearDog()
        {
            Console.WriteLine("Akita jagar björn.");
        }
        // Method that override the makeSound method in Animal the parent class
        public override void makeSound()
        {
            Console.WriteLine("Akitan säger : WooFF! ");
        }
    }
}
