using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Sheet07_Q1
{
    public abstract class Animal
    {
        public abstract void MakeSound();
    }

    class Lion : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Roaring of Lion");
        }
    }

    class Tiger : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Growling of Tiger");
        }
    }

    class Elephant : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Trumpets of an Elephant");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> Animals = new List<Animal>();

            Console.WriteLine("Enter the type of animal: ");
            string animalType = Console.ReadLine();

            Animal animalSound = null;

            switch(animalType.ToLower())
            {
                case "tiger":
                    animalSound = new Tiger();break;
                case "lion":
                    animalSound = new Lion();break;
                case "elephant":
                    animalSound = new Elephant();break;


            }

            Animals.Add(animalSound);
            Console.WriteLine("Animal Added");
            Console.WriteLine("The sound of the added animal");

            foreach (var animal in Animals)
            {
                animal.MakeSound();
            }
            Console.ReadLine();



        }
    }

}
