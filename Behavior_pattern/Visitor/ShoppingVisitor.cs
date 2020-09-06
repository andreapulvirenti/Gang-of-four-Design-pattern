namespace Visitor
{
    public class ShoppingVisitor : IVisitor
    {
        public double Visit(ProductSoldInPieces product)
        {
            return product.UnitCount * product.UnitPrice;
        }
        public double Visit(ProductSoldInWeight product)
        {
            return product.Weight * product.WeightPrice;

        }
    }
}