using System;
using System.Collections.Generic;

namespace PriceCalculation
{

    public class Meal : Food
    {

        private string mealType;

        public Meal(string name, string mealType):base(name)
        {
            this.mealType = mealType;
            if (string.IsNullOrEmpty(mealType))
                    throw new FoodException();
        }

        public override void setPrice(List<string> transactions)
        {
            if (this.mealType.Equals("assiette"))
            {
                this.price += 15;
            }
            if(this.mealType.Equals("sandwich"))
            {
                this.price += 10;
            }

        }

    }
}