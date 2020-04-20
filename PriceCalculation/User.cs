using System;
using System.Collections.Generic;

namespace PriceCalculation
{
    public class User
    {

        private List<string> transactions;

        public User()
        {
            this.transactions = new List<string>();
        }

        public double chooseMeal(string meal, string mealType)
        {
            transactions.Add(mealType);
            Meal choosenMeal = new Meal(meal, mealType);
            choosenMeal.setPrice(this.transactions);
            return choosenMeal.price;
        }

        public double chooseDrink(string drink, string size)
        {
            transactions.Add(size);
            Drink choosenDrink = new Drink(drink, size);
            choosenDrink.setPrice(this.transactions);
            return choosenDrink.price;
        }

        public double chooseDessert(string dessert, string size)
        {
            transactions.Add(size);
            Dessert choosenDessert = new Dessert(dessert, size);
            choosenDessert.setPrice(this.transactions);
            return choosenDessert.price;
        }

        public double chooseCoffee(string coffee)
        {
            transactions.Add(coffee);
            Coffee choosenCoffee = new Coffee(coffee);
            choosenCoffee.setPrice(this.transactions);
            return choosenCoffee.price;
        }

        public List<string> getTransactions()
        {
            return this.transactions;
        }

    }
}
