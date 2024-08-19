using System.Text.Json;

namespace C_HelpfulPatterns;

//Завдання: Серіалізуйте об'єкт Person до JSON і десеріалізуйте його назад в об'єкт.
public class Person { public string? Name { get; set; } public int Age { get; set; } }
internal class JsonSerialize
{
    Person person = new Person { Name = "John Doe", Age = 30 };

    public void Run()
    {
        string json = JsonSerializer.Serialize(person);
        Person personDe = JsonSerializer.Deserialize<Person>(json);
        Console.WriteLine(personDe.Age + " " + personDe.Name);
    }
}
