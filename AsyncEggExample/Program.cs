using AsyncEggExample.Ingredients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncEggExample
{
    class Program
    {
        static void Main(string[] args)
        {
            EggService eggService = new EggService();
            var eggTask = eggService.FryEggAsync();
            var cheeseTask = eggService.AddCheeseAsync();         
            var meatTask = eggService.AddMeatAsync();
            var veggiesTask = eggService.AddVeggiesAsync();
            var omeletteTask = eggService.PutOmeletteOnPlate();

            Task.WhenAll(eggTask, cheeseTask, meatTask, veggiesTask);
            Egg egg = eggTask.Result;
            Cheese cheese = cheeseTask.Result;
            Veggies veggies = veggiesTask.Result;
            Meat meat = meatTask.Result;
            Omelette omelette = omeletteTask.Result;

            Console.ReadKey();
        }
    }
}
