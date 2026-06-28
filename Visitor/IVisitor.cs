public interface IVisitor
{
    // Для каждого типа элемента свой метод Visit().
    // Это позволяет посетителю выполнять разные действия для разных типов.
    void Visit(SomeClass1 element);
    void Visit(SomeClass2 element);
    void Visit(SomeClass3 element);
}