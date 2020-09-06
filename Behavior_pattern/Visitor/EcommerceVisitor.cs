namespace Visitor
{
    public class EcommerceVisitor : IVisitor
    {
        public double Visit(ProductSoldInPieces product)
        {
            double price = product.UnitCount * product.UnitPrice;
            return price - (price * 0.1); //10% less 

        }
        public double Visit(ProductSoldInWeight product)
        {
            double price = product.Weight * product.WeightPrice;
            return price - (price * 0.1);
        }
    }
}