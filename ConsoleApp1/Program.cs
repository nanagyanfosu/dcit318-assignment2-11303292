using System;
class Animal() {
    public virtual void MakeSound() {
        Console.WriteLine("Some generic sound");
    }

}

class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Bark");
    }
}

class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Meow");
    }
}

class Program
{
    public static void Main()
    {
        Animal animal = new();
        animal.MakeSound();
        Dog dog = new();
        dog.MakeSound();
        Cat cat = new();
        cat.MakeSound();
    }
}


