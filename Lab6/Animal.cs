using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6
{   
    // Parent class
    class Animal
    {
        // Field with input parameters
        string name;
        int age;
        double weigth;
        string color;
        string mood;

        // Constructor
        public Animal(string name, int age, double weight, string color, string mood)
        {
            this.name = name;
            this.age = age;
            this.weigth = weight;
            this.color = color;
            this.mood = mood;
        }
        // Constructor with default values
        public Animal()
        {
            this.name = "unknown";
            this.age = 0;
            this.weigth = 0.0;
            this.color = "unknown";
            this.mood = "unknown";
        }

        // Method 
        public void Food()
        {
            Console.WriteLine("Djuret äter.");
        }
        // Method
        public void Sleep()
        {
            Console.WriteLine("Djuret sover.");
        }

        // Method that allows been override
        public virtual void makeSound()
        {
            Console.WriteLine("Djuret låter.");
        }
    }
}
