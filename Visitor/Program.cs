using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Создаём список разнородных элементов.
        List<IElement> elements = new List<IElement>
        {
            new SomeClass1(1), // int
            new SomeClass2(2), // int
            new SomeClass3(3)  // int
        };

        // Создаём посетителя, который умеет их обрабатывать.
        IVisitor visitor = new PrintVisitor();

        // Перебираем все элементы. Каждый из них принимает посетителя.
        // Посетитель сам решает, какой метод вызвать для каждого элемента.
        foreach (IElement element in elements)
        {
            element.Accept(visitor);
        }
    }
}
//Паттерн Visitor позволяет добавить новую операцию к группе объектов, не изменяя сами объекты. В моём коде интерфейс IVisitor определяет метод Visit() для каждого типа элемента. Конкретный посетитель PrintVisitor реализует логику вывода свойств. Элементы (SomeClass1, SomeClass2, SomeClass3) принимают посетителя через метод Accept(), вызывая visitor.Visit(this). Это обеспечивает двойную диспетчеризацию: какой элемент вызван, и какой посетитель используется.