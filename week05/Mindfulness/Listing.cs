class ListingActivity : Activity
{
    public ListingActivity() : base("Listing Exercise", "List as many things as you can about a topic.") 
    {
        
     }

    protected override void Run()
    {
        Console.WriteLine("Think about things you are grateful for.");
        ShowSpinner(3);
        List<string> responses = new List<string>();

        Console.WriteLine("Start listing! (Press Enter after each response, type 'done' to finish):");
        string response;
        while ((response = Console.ReadLine().ToLower()) != "done")
        {
            responses.Add(response);
        }

        Console.WriteLine($"You listed {responses.Count} items!");
    }
}