namespace C_HelpfulPatterns;

//Завдання: Напишіть код, який створює текстовий файл, записує в нього рядки та читає їх з файлу.
internal class Reader
{
    public void Run()
    {
        string path = @"D:\Example.txt";

        if (!File.Exists(path))
        {
            File.Create(path).Close();
        }

        using (TextWriter textWriter = new StreamWriter(path))
        {
            textWriter.WriteLine("First line.");
        }

        Console.WriteLine(File.ReadAllText(path));
    }
}
