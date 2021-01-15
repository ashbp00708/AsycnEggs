using AsyncEggExample.Ingredients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncEggExample
{
    class EggService
    {
        public async Task<Egg> FryEggAsync()
        {
            Console.WriteLine("Crack the egg", Console.ForegroundColor = ConsoleColor.Yellow);
            await Task.Delay(1000);
            Console.WriteLine("Stir the yolk", Console.ForegroundColor = ConsoleColor.Yellow);
            await Task.Delay(1000);
            Console.WriteLine("Pour in the pan", Console.ForegroundColor = ConsoleColor.Yellow);
            await Task.Delay(1000);
            Console.ResetColor();
            return new Egg();

        }
        public async Task<Cheese> AddCheeseAsync()
        {
            Console.WriteLine("Add desired cheese blend", Console.ForegroundColor = ConsoleColor.DarkYellow);
            await Task.Delay(2000);
            Console.WriteLine("Wait for cheese to melt", Console.ForegroundColor = ConsoleColor.DarkYellow);
            Console.ResetColor();
            return new Cheese();
        }
        public async Task<Meat> AddMeatAsync()
        {
            Console.WriteLine("Select meat to add to omelette", Console.ForegroundColor = ConsoleColor.Red);
            await Task.Delay(2000);
            Console.WriteLine("wait for meat to cook", Console.ForegroundColor = ConsoleColor.Red);
            Console.ResetColor();
            return new Meat();

        }
        public async Task<Veggies> AddVeggiesAsync()
        {
            Console.WriteLine("Chop selected veggies", Console.ForegroundColor = ConsoleColor.Green);
            await Task.Delay(2000);
            Console.WriteLine("Add veggies to omelette", Console.ForegroundColor = ConsoleColor.Green);
            await Task.Delay(2000);
            Console.WriteLine("Add veggies to omelette", Console.ForegroundColor = ConsoleColor.Green);
            Console.ResetColor();
            return new Veggies();
        }
        public async Task<Omelette> PutOmeletteOnPlate()
        {
           
            Console.WriteLine("Taking omelette out of pan");
            await Task.Delay(4000);
            Console.WriteLine("Placing omelette on plate");
            await Task.Delay(4000);
            Console.WriteLine("Serving with desired sides");
            await Task.Delay(4000);
            return new Omelette();

        }


    }
}
