using NameSorter.Models;

namespace NameSorter.Services
{
    public class NameSorterService
    {
        // <Summary>
        // Sorts a list of names by last name and then by given names
        // </Summary>
        /// <param name="names">List of names (strings) to sort</param>
        /// <returns>Resulting sorted list </returns>
        public static List<string> SortNames(List<string> names)
        {
            return names
                .Select(n => new PersonName(n))
                .OrderBy(n => n.LastName)
                .ThenBy(n => string.Join(" ", n.GivenNames))
                .Select(n => n.ToString())
                .ToList();
        }
    }
}
