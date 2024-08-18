using System.Text.RegularExpressions;

namespace C_HelpfulPatterns;

//Завдання: Напишіть регулярний вираз, який перевіряє, чи містить рядок тільки цифри.
internal class RegexNumeric
{
    public void Run()
    {
        string pattern = @"^\d+$";

        string authors = "Mahesh Chand, Raj Kumar, Mike Gold, Allen O'Neill, Marshal Troll 32423423";
        string nums = "453534534";

        Console.WriteLine(Regex.IsMatch(authors, pattern));
        Console.WriteLine(Regex.IsMatch(nums, pattern));
    }

}
