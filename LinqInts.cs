namespace C_HelpfulPatterns;

//Дано: Масив цілих чисел int[] numbers = { 2, 7, 5, 8, 3, 1, 9, 4 };
//Завдання: Використовуючи LINQ, відсортуйте числа за зростанням і виведіть їх.
internal class LinqInts
{
    public void Run()
    {
        int[] numbers = { 2, 7, 5, 8, 3, 1, 9, 4 };

        IEnumerable<int> result = from num in numbers
                                  orderby num ascending
                                  select num;

        foreach (int number in result)
        {
            Console.WriteLine(number);
        }
    }
}
