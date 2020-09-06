using System;
namespace Visitor
{
    public class ProductSoldInPieces : AProduct, IVisitable
    {
        private double unitPrice;
        private int unitCount;

        public ProductSoldInPieces(string code, string description, double uPrice, int count)
        {
            this.Code = code;
            this.Description = description;
            this.unitPrice = uPrice;
            this.unitCount = count;
        }

        public double UnitPrice
        {
            get
            {
                return unitPrice;
            }
            set
            {
                unitPrice = value;
            }
        }

        public int UnitCount
        {
            get
            {
                return unitCount;
            }
            set
            {
                unitCount = value;
            }
        }

        public double Accept(IVisitor visitor)
        {
            var price = visitor.Visit(this);
            Console.WriteLine($" { this.Description} : {price} Euro");
            return price;
        }

    }
}