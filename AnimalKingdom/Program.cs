using System;
using System.Runtime.CompilerServices;

namespace AnimalKingdom
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Random rand = new Random();
            Animal[] animals = new Animal[10];

            for (int i = 0; i < 10; i++)
            {
                int valueGenerated = rand.Next(4);

                switch (valueGenerated)
                {
                    case 0:
                        animals[i] = new Bat();
                        break;
                    case 1:
                        animals[i] = new Bee();
                        break;
                    case 2:
                        animals[i] = new Cat();
                        break;
                    case 3:
                        animals[i] = new Dog();
                        break;
                }
            }
            
            foreach (Animal a in animals){
                Console.Write($"{a.GetType().Name}{a.Sound()}");
                if (a is IMammal)
                    Console.Write(
                        $"\t| No.Nipples = {(a as IMammal).NumberOfNipples}");
                if (a is ICanFly)
                    Console.Write(
                        $"\t| No.Wings = {(a as ICanFly).NumberOfWings}");
                Console.WriteLine();
            }
        }
    }
}
