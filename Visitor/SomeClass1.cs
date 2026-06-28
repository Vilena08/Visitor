public class SomeClass1 : IElement
{
    public int SomeProperty1 { get; set; }

    public SomeClass1(int value)
    {
        SomeProperty1 = value;
    }

    // Принимаем посетителя и перенаправляем вызов обратно к посетителю.
    // visitor.Visit(this) — this имеет тип SomeClass1, поэтому вызывается нужный метод.
    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
}