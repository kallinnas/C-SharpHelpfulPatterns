namespace C_HelpfulPatterns;

//Дано: Інтерфейс IMovable з методом Move().
//Завдання: Реалізуйте цей інтерфейс у класі Car, який виводить на екран "Car is moving".
interface IMovable
{
    void Move();
}

class Car : IMovable
{
    public void Move()
    {
        Console.WriteLine("Car is moving");
    }
}
