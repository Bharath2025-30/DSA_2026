using DSAProblems.BitManipulation;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter topic (e.g., BitManipulation):");
        string topic = "BitManipulation";

        Console.WriteLine("Enter program number:");
        int programNo = int.Parse(Console.ReadLine() ?? "1");

        switch (topic)
        {
            case "BitManipulation":
                BitManipulationRunner.Run(programNo);
                break;

            default:
                Console.WriteLine("Unknown topic");
                break;
        }
    }
}
