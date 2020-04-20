using System;
using System.Collections.Generic;

namespace PriceCalculation
{

    public abstract class Food
    {

       protected string name;
       public double price;

        protected Food(string name)
        {
            this.name = name;
        }

        public abstract void setPrice(List<string> transactions);


    }
}
