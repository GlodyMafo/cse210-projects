
abstract class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    // public int GetDuration ()
    // {
    //     return _duration;
    // }

    public void Start()
    {
        Console.WriteLine($"\nStarting {_name}...\n{_description}");
        Console.Write("Enter duration (in seconds): ");
        _duration = int.Parse(Console.ReadLine());
        Run();
        Console.WriteLine("\nActivity completed!\n");
    }

    protected void ShowSpinner(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i} ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    protected abstract void Run();
}