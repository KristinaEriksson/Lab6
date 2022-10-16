using System;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kristina Eriksson .NET 22

            // Object with input parameters
            Dog dog1 = new Dog("Oliwer", 8, 12.0, "brun", "lekfull", true);
            Cat cat1 = new Cat("Gissa", 12, 4.0, "vit", "gosig", 4);
            Parrot parrot1 = new Parrot("Coco", 45, 1.2, "grå", "arg", 10.0);
            Akita akita1 = new Akita("Riki", 8, 8.6, "röd", "modig", true, "Akita Inu");
            CockerSpaniel cockerSpaniel1 = new CockerSpaniel("Smith", 4, 6.0, "Svartvit", "busig", true, "långhårig");
            Human human1 = new Human("Ulrik", 53, 115.5, "ljus", "stressad", "duktig på motorer");

            // Output every objects makeSound method 
            dog1.makeSound();
            Console.WriteLine(" ");
            cat1.makeSound();
            Console.WriteLine(" ");
            parrot1.makeSound();
            Console.WriteLine(" ");
            akita1.makeSound();
            Console.WriteLine(" ");
            cockerSpaniel1.makeSound();
            Console.WriteLine(" ");
            human1.makeSound();
        }
    }
}
