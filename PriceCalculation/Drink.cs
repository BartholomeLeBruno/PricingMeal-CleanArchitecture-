using System;
using System.Collections.Generic;

namespace PriceCalculation
{
    public class Drink : Food
    {
        private string size;

        public Drink(string name, string size) : base(name)
        {
            this.size = size;
        }

        public override void setPrice(List<string> transactions)
        {
            switch(this.size)
            {
                case "petit":
                    this.price += 2;
                    break;
                case "moyen":
                    this.price += 3;
                    break;
                case "grand":
                    this.price += 4;
                    break;
            }
        }
    }
}
