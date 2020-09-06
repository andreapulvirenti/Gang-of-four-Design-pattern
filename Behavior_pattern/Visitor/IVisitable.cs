namespace Visitor
{
    public interface IVisitable
    {
        double Accept(IVisitor visitor);
    }
}