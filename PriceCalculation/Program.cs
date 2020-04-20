using System;
using System.Collections.Generic;

namespace PriceCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            double mealPrice = user.chooseMeal(args[1], args[0]);
            double drinkPrice = user.chooseDrink(args[2], args[3]);

            double dessertPrice = user.chooseDessert(args[4], args[5]);

            double coffeePrice = user.chooseCoffee(args[6]);

            Pricing pricing = new Pricing(user, mealPrice, drinkPrice, dessertPrice, coffeePrice);

            pricing.computeTotalPrice();


        }
    }
}
