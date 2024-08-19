namespace C_HelpfulPatterns;

//Завдання: Напишіть код, що визначає подію ThresholdReached, яка виникає при досягненні певного значення лічильника.
internal class EventThresholdReached
{
    private int _threshold;
    private int _total = 0;

    public EventThresholdReached(int threshold)
    {
        _threshold = threshold;
    }

    public void Run()
    {
        EventThresholdReached c = new EventThresholdReached(_threshold);
        c.ThresholdReached += C_ThresholdReached;

        c.Add(3);
        c.Add(7); // Threshold reached.
    }

    private static void C_ThresholdReached(object sender, EventArgs e)
    {
        Console.WriteLine("Threshold reached.");
    }

    public event EventHandler ThresholdReached;

    public void Add(int x)
    {
        _total += x;

        if (_total >= _threshold)
        {
            OnThresholdReached(EventArgs.Empty);
        }
    }

    protected virtual void OnThresholdReached(EventArgs e)
    {
        ThresholdReached?.Invoke(this, e);
    }

}
