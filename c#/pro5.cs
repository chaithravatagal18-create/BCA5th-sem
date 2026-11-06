using System;

class Animal
{
public virtual void Speak()
{
Console.WriteLine("Animal makes a sound");
}
}
// Derived Class
class Dog : Animal
{
// Overriding
public override void Speak()
{
Console.WriteLine("Dog barks");
}
}
class Program4
{
static void Main()
{
Animal a1 = new Animal();
Animal a2 = new Dog();
a1.Speak();
a2.Speak();
}
}