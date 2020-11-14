using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Zoo.Canine;

namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hipopótamo");
            Hippo hippo = new Hippo();
            hippo.Name = "Hipopótamo";
            hippo.Food = "50k de grama";
            hippo.MakeNoise();
            hippo.Eat();
            hippo.Sleep();
            hippo.Roam();

            SaltarLinhas();

            Console.WriteLine("Felinos");

            SaltarLinhas();
            Console.WriteLine("Tigre");
            Tiger tiger = new Tiger();
            tiger.Name = "Tigre";
            tiger.Food = "30k de carne";
            tiger.MakeNoise();
            tiger.Eat();
            tiger.Sleep();
            tiger.Roam();

            SaltarLinhas();
            Console.WriteLine("Leão");
            Lion lion = new Lion();
            lion.Name = "Leão";
            lion.Food = "30k de carne";
            lion.MakeNoise();
            lion.Eat();
            lion.Sleep();
            lion.Roam();

            SaltarLinhas();
            Console.WriteLine("Gato");
            Cat cat = new Cat();
            cat.Name = "Gato";
            cat.Food = "5k de carne";
            cat.MakeNoise();
            cat.Eat();
            cat.Sleep();
            cat.Roam();

            SaltarLinhas();

            Console.WriteLine("Caninos");

            SaltarLinhas();
            Console.WriteLine("Cachorro");
            Dog dog = new Dog();
            dog.Name = "Cachorro";
            dog.Food = "10k de ração";
            dog.MakeNoise();
            dog.Eat();
            dog.Sleep();
            dog.Roam();

            SaltarLinhas();
            Console.WriteLine("Lobo");
            Wolf wolf = new Wolf();
            wolf.Name = "Cachorro";
            wolf.Food = "10k de ração";
            wolf.MakeNoise();
            wolf.Eat();
            wolf.Sleep();
            wolf.Roam();

            Console.ReadKey();
        }

        public static void SaltarLinhas()
        {
            Console.WriteLine();
            Console.WriteLine("-------------------");
            Console.WriteLine();
        }
    }
}
