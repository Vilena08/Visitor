public interface IElement
{
    // Каждый элемент должен уметь принимать посетителя.
    void Accept(IVisitor visitor);
}