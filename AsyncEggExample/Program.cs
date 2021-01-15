﻿using AsyncEggExample.Ingredients;
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
            var veggiesTask = eggService.AddVeggiesAsync();
            var meatTask = eggService.AddMeatAsync();
            var omeletteTask = eggService.PutOmeletteOnPlate();


            Egg egg = eggTask.Result;
            Cheese cheese = cheeseTask.Result;
            Veggies veggies = veggiesTask.Result;
            Meat meat = meatTask.Result;
            Omelette omelette = omeletteTask.Result;

            Console.ReadKey();
        }
    }
}
