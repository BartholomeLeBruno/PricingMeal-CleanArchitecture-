namespace PriceCalculation
{
    using System;
    using System.Collections.Generic;

    public class Pricing
    {

        User user;
        double mealPrice;
        double drinkPrice;
        double dessertPrice;
        double coffeePrice;
        double totalPrice;

        public Pricing(User user, double mealPrice, double drinkPrice, double dessertPrice, double coffeePrice)
        {
            this.user = user;
            this.mealPrice = mealPrice;
            this.drinkPrice = drinkPrice;
            this.dessertPrice = dessertPrice;
            this.coffeePrice = coffeePrice;
        }

        public void computeTotalPrice()
        {
            this.totalPrice = this.mealPrice + this.drinkPrice + this.dessertPrice;
            this.applicateFormula();
            this.totalPrice += this.coffeePrice;
            Console.WriteLine($"Prix à payer : {this.totalPrice}€");
        }

        public void applicateFormula()
        {
            if (this.user.getTransactions().Contains("formule standard"))
            {
                if (this.user.getTransactions().Contains("assiette"))
                {
                    Console.Write("Prix Formule Standard appliquée ");
                    this.totalPrice = 18;
                }
                if (this.user.getTransactions().Contains("sandwich"))
                {
                    Console.Write("Prix Formule Standard appliquée ");
                    this.totalPrice = 13;
                }
            }
            if (this.user.getTransactions().Contains("formule max"))
            {
                if (this.user.getTransactions().Contains("assiette"))
                {
                    Console.Write("Prix Formule Max appliquée ");
                    this.totalPrice = 21;
                }
                if (this.user.getTransactions().Contains("sandwich"))
                {
                    Console.Write("Prix Formule Max appliquée ");
                    this.totalPrice = 16;
                }
            }
        }   
        
    }
}
