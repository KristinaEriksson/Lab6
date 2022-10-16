using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6
{
    // Child class that derived from Animal the parent class
    class Human : Animal
    {
        // Field that only Human has
        string crafting;
        // Constructor with derived input parameters
        public Human(string name, int age, double weight, string color, string mood, string crafting) : base(name, age, weight, color, mood)
        {
            this.crafting = crafting;
        }
        // Constructor with default value
        public Human()
        {
            this.crafting = "Kan tillverka saker.";
        }
        // Method
        public void sing()
        {
            Console.WriteLine("Määniskor sjunger.");
        }
        // Method that override the makeSound method in Animal the parent class
        public override void makeSound()
        {
            Console.WriteLine("Människan säger : Hejsan hejsan!");
        }
    }
}
