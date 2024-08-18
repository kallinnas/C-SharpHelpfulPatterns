using System.Text;
using System.Text.RegularExpressions;

namespace C_HelpfulPatterns;

//Завдання: Напишіть розширюючий метод для класу string, який перевіряє, чи є рядок паліндромом.
internal class Palindrome
{
    public void Run()
    {
        string palindrome = "Madam, I'm Adam";
        StringBuilder sb = new StringBuilder();

        foreach (var c in palindrome)
        {
            if (Regex.IsMatch(c.ToString(), "[a-z]", RegexOptions.IgnoreCase))
            {
                sb.Append(c);
            }
        }

        palindrome = sb.ToString().ToLower();

        Console.WriteLine(palindrome.SequenceEqual(palindrome.Reverse()));
    }
}
