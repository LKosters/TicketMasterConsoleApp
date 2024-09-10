Console.WriteLine("-- Welcome to ticketmaster! --");

bool app = true;
string[] events = {"Event 1", "Event 2", "Event 3", "Event 4"};
List<string> chosenEvents = new List<string>();

while (app)
{
    Console.WriteLine("-- What do you want to do? --");
    Console.WriteLine("[0] Add event");
    Console.WriteLine("[1] Remove event");
    Console.WriteLine("[2] Show chosen events");
    Console.WriteLine("[3] Quit app");
    
    string navigation = Console.ReadLine();

    if (navigation == "0")
    {
        Console.WriteLine("-- Choose an event: --");

        int index = 0;
        foreach (var evt in events)
        {
            Console.WriteLine("[" + index + "] " + evt);
            index++;
        }

        string choice = Console.ReadLine();
        int eventIndex;

        if (int.TryParse(choice, out eventIndex) && eventIndex >= 0 && eventIndex < events.Length)
        {
            chosenEvents.Add(events[eventIndex]);
        }
        else
        {
            Console.WriteLine("Invalid choice, please try again.");
        }
    } else if (navigation == "1")
    {
        Console.WriteLine("-- Choose an event to delete: --");
        
        int index = 0;
        foreach (var evt in chosenEvents)
        {
            Console.WriteLine("[" + index + "] " + evt);
            index++;
        }
        
        string choice = Console.ReadLine();
        int eventIndex;

        if (int.TryParse(choice, out eventIndex) && eventIndex >= 0 && eventIndex < events.Length)
        {
            chosenEvents.Remove(chosenEvents[eventIndex]);
        }
        else
        {
            Console.WriteLine("Invalid choice, please try again.");
        }
    } else if (navigation == "2")
    {
        if (chosenEvents.Count > 0)
        {
            Console.WriteLine("-- Your chosen events: --");
            foreach (var evt in chosenEvents)
            {
                Console.WriteLine(evt);
            }
        }
        else
        {
            Console.WriteLine("-- There are no chosen events. --");
        }
    } else if (navigation == "3")
    {
        Console.WriteLine("-- Thank you for using the ticketmaster! --");
        app = false;
    }
}