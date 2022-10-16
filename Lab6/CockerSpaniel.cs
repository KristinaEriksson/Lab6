using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6
{
    // Class that inheriting from Dog
    class CockerSpaniel : Dog
    {
        // Field that only Akita has
        string hairy;
        // Constructor with derived input parameters
        public CockerSpaniel(string name, int age, double weight, string color, string mood, bool huntingInstinct, string hairy) : base(name, age, weight, color, mood, huntingInstinct)
        {
            this.hairy = hairy;
        }
        // Constructor with default value
        public CockerSpaniel()
        {
            this.hairy = "Mycket och lång päls";
        }
        // Method
        public void FureCare()
        {
            Console.WriteLine("Hunden kräver mycket pälsvård.");
        }
        // Method that override the makeSound method in Animal the parent class
        public override void makeSound()
        {
            Console.WriteLine("Cocker spanieln säger : Voff voff!");
        }
    }
}
