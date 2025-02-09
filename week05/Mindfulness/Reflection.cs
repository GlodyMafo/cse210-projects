class ReflectionActivity : Activity
{
private List<string> Prompts = new List<string>
    {
        "Think of a time you helped someone.",
        "Recall a moment you felt truly happy.",
        "Remember a challenge you overcame."
    };

    public ReflectionActivity() : base("Reflection Exercise", "Think deeply about meaningful experiences.") 
    { 

    }

    protected override void Run()
    {
        Random random = new Random();
        string prompt = Prompts[random.Next(Prompts.Count)];
        Console.WriteLine($"\n{prompt}");
        ShowSpinner(_duration);
    }
}