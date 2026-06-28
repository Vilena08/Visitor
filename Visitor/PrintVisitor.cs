using System;

public class PrintVisitor : IVisitor
{
    // Каждый метод Visit() знает, как работать с конкретным типом элемента.
    public void Visit(SomeClass1 element)
    {
        Console.WriteLine(element.SomeProperty1);
    }

    public void Visit(SomeClass2 element)
    {
        Console.WriteLine(element.SomeProperty2);
    }

    public void Visit(SomeClass3 element)
    {
        Console.WriteLine(element.SomeProperty3);
    }
}