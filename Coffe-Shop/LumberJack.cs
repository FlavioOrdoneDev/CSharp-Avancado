using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffe_Shop
{
    public class LumberJack
    {
        public LumberJack(string name)
        {
            this.name = name;
            meal = new Stack<FlapJack>();
        }

        private string name;
        public string Name { get { return name; } }

        private Stack<FlapJack> meal;

        public int FlapJackCount { get { return meal.Count; } }

        public void TakeFlapJacks(FlapJack food, int howMany)
        {
            for (int i = 0; i < howMany; i++)
            {
                meal.Push(food);
            }
        }

        public void EatFlapJacks()
        {
            Console.WriteLine(Name + " comendo panquecas");
            foreach (var item in meal)
            {
                Console.WriteLine(Name + " comeu um " + item.ToString().ToLower() + " panqueca.");
            }
        }

    }
}
