using System;
using System.Collections.Generic;

namespace PriceCalculation
{
    public class Dessert : Food
    {
        private string size;

        public Dessert(string name, string size) : base(name)
        {
            this.size = size;
        }

        public override void setPrice(List<string> transactions)
        {

            if(transactions.Contains("petit"))
            {
                this.price = this.size.Equals("normal") ? +2 : +4;
            }
            else if(transactions.Contains("moyen"))
            {
                if (transactions.Contains("assiette"))
                {
                    if (this.size.Equals("normal"))
                    {
                        transactions.Add("formule standard");
                    }
                    else
                        this.price += 4;
                }
                if (transactions.Contains("sandwich"))
                {
                    if (this.size.Equals("normal"))
                    {
                        transactions.Add("formule standard");
                    }
                    else
                        this.price += 4;
                }
            }
            else if (transactions.Contains("grand"))
            {
                if (transactions.Contains("assiette"))
                {
                    if (!this.size.Equals("normal"))
                    {
                        transactions.Add("formule max");
                    }
                    else
                        this.price += 2;
                }
                if (transactions.Contains("sandwich"))
                {
                    if (!this.size.Equals("normal"))
                    {
                        transactions.Add("formule max");
                    }
                    else
                        this.price += 2;
                }
            }
        }
    }
}
