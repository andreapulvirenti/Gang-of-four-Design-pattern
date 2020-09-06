namespace Visitor
{
    public interface IVisitor
    {
         double Visit(ProductSoldInPieces product);
         double Visit(ProductSoldInWeight product);

    }
}