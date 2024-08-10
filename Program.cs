// Read a list of integers from the console
Console.WriteLine("Enter numbers separated by space:");
var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

// Remove duplicates using a HashSet and then convert back to a list
var uniqueNumbers = new HashSet<int>(numbers).ToList();

// Sort the list in descending order
uniqueNumbers.Sort((a, b) => b.CompareTo(a));

// Print the sorted list
Console.WriteLine("Sorted list in descending order without duplicates:");
uniqueNumbers.ForEach(Console.WriteLine);