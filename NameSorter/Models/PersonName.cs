namespace NameSorter.Models
{
    // Helper class to represent a person's name
    public class PersonName
    {
        public List<string> GivenNames { get; }
        public string LastName { get; }

        public PersonName(string fullName)
        {
            var parts = fullName.Split(' ');
            LastName = parts[^1]; // Last name
            GivenNames = parts[..^1].ToList(); // All except last
        }

        public override string ToString()
        {
            return string.Join(" ", GivenNames.Append(LastName));
        }
    }
}
