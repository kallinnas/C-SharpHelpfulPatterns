using System.Diagnostics.Metrics;

namespace C_HelpfulPatterns;

//Завдання: Напишіть код, що створює два потоки, один з яких збільшує змінну, а інший – зменшує, з контролем за станом змінної.
internal class Multithreading
{
    private static int counter = 0;
    private static readonly object _lock = new object();

    public void Run()
    {
        Thread incrementThread = new Thread(Increment);
        Thread decrementThread = new Thread(Decrement);

        incrementThread.Start();
        decrementThread.Start();

        incrementThread.Join();
        decrementThread.Join();

        Console.WriteLine($"Final counter value: {counter}");
    }

    static void Increment()
    {
        for (int i = 0; i < 1000; i++)
        {
            lock (_lock)
            {
                counter++;
            }
        }
    }

    static void Decrement()
    {
        for (int i = 0; i < 1000; i++)
        {
            lock (_lock)
            {
                counter--;
            }
        }
    }

}
