// See https://aka.ms/new-console-template for more information
using IteratorList.Agregator;

Console.WriteLine("Hello, World!");

var list = new [] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

var aggregate  = new ConcreteAggregate<int>(list);

var iterator = aggregate.CreateIterator();

while (iterator.MoveNext())
{
    Console.WriteLine(iterator.Current);
}