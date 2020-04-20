using System;
namespace PriceCalculation
{
    public class FoodException : Exception
    {
        public FoodException():base(string.Format("Meal can't be empty !")){}
    }
}
