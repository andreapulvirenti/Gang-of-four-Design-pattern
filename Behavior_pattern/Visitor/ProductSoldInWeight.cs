using System;
namespace Visitor
{
    public class ProductSoldInWeight : AProduct, IVisitable
    {
        private double weightPrice;
        private double weight;


        public ProductSoldInWeight(string code, string description, double wPrice, int weight)
        {
            this.Code = code;
            this.Description = description;
            this.weightPrice = wPrice;
            this.weight = weight;
        }

        public double WeightPrice
        {
            get
            {
                return weightPrice;
            }
            set
            {
                weightPrice = value;
            }
        }


        public double Weight
        {
            get
            {
                return weight;
            }
            set
            {
                weight = value;
            }
        }
        public double Accept(IVisitor visitor)
        {
            var price = visitor.Visit(this);
            Console.WriteLine($"{ this.Description} x {weightPrice} Eur/kg ({weight} Kg): {price} Euro");
            return price;
        }
 
    }
}