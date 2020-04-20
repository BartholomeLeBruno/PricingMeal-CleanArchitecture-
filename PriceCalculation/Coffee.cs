using System;
using System.Collections.Generic;

namespace PriceCalculation
{
    public class Coffee : Food
    {
        public Coffee(string name):base(name)
        {
        }

        public override void setPrice(List<string> transactions)
        {
            if (transactions.Contains("assiette")
                && transactions.Contains("moyen")
                    && transactions.Contains("normal")
                     && this.name.Equals("yes"))
            {
                Console.Write(" avec café offert!");
            }
            else
                this.price += 1;
        }
    }
}
