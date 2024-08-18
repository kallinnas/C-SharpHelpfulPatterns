namespace C_HelpfulPatterns;

//Дано: Метод int Divide(int a, int b)
//Завдання: Напишіть код для виклику цього методу з обробкою можливого виключення ділення на нуль.
internal class HandleError
{
    public void Run()
    {
        try
        {
            Divide(2, 0);
        }

        catch (DivideByZeroException ex)
        { 
            Console.WriteLine(ex.ToString());
        }
    }

    public int Divide(int a, int b)
    {
        return a / b;
    }

}
