using DesignPatterns.Examples.Implementation;
using DesignPatterns.Examples.Interface;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, IPatternExample> examples = new()
        {
            {"Factory", new FactoryExample()},
            {"Decorator", new DecoratorExample()},
            {"Builder", new BuilderExample()},
            {"Prototype", new PrototypeExample()},
            {"Bridge", new BridgeExample() },
            {"Adapter", new AdapterExample()}
        };

        while (true)
        {
            Console.WriteLine("\nAvailable Design Patterns:");
            foreach (var pattern in examples.Keys)
            {
                Console.WriteLine($"- {pattern}");
            }
            Console.WriteLine("Enter 'exit' to quit");

            Console.Write("\nChoose a pattern to demonstrate: ");
            string? choice = Console.ReadLine();

            if (choice?.ToLower() == "exit")
                break;

            if (examples.TryGetValue(choice ?? "", out var example))
            {
                example.Demonstrate();
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }
}