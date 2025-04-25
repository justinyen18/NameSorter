using NameSorter.Services;

public class Program
{
    static void Main(string[] args)
    {
        // Check if the correct number of arguments is provided
        if (args.Length != 1)
        {
            Console.WriteLine("Usage: name-sorter <file path>");
            return;
        }

        string inputFile = args[0];

        // Check if the input file exists
        if (!File.Exists(inputFile))
        {
            Console.WriteLine($"File not found: {inputFile}");
            return;
        }

        // Read the file and sort the names
        var fullNames = File.ReadAllLines(inputFile).ToList();
        var sortedNames = NameSorterService.SortNames(fullNames).Select(p => p.ToString()).ToList();
        
        sortedNames.ForEach(n => Console.WriteLine(n));
        File.WriteAllLines("sorted-names-list.txt", sortedNames);
    }
}

