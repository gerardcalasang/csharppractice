abstract class Animal
{
    public void Eat()
    {
        Console.WriteLine("Yum yum\n");
    }
    public abstract void MakeSound();
}

class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("woof woof\n");
    }
}

class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("meow meow\n");
    }
}

public class Animals
{
    public static void Main(string[] args)
    {
        var Muning = new Cat();
        var Bruno = new Dog();
        Muning.Eat();
        Bruno.Eat();
        Muning.MakeSound();
        Bruno.MakeSound();
    }
}


