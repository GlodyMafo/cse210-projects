class BreathingActivity : Activity
{
 public BreathingActivity() : base("Breathing Exercise", "Relax by focusing on your breathing.") 
 {

  }

    protected override void Run()
    {
        for (int i = 0; i < _duration / 6; i++)
        {
            Console.WriteLine("Inhale...");
            ShowSpinner(3);
            Console.WriteLine("Exhale...");
            ShowSpinner(3);
        }
    }

}