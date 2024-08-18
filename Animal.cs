namespace C_HelpfulPatterns;

//Дано: Базовий клас Animal з методом MakeSound().
//Завдання: Створіть клас-нащадок Dog, який перевизначає метод MakeSound() і виводить "Woof".
abstract class Animal
{
    public abstract void MakeSound();
}

class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Woof");
    }
}
