using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PartTwo
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (StreamReader sr = new StreamReader(@"C:\Users\Stuart\source\repos\AdventOfCode2023\DayOnePartTwo\Input\InputSmall.txt"))
                {
                    string line;
                    int totalValues = 0;
                    int indexFound = 0;
                    string numbers = new[] { ("one", "1"), ("two", "2"), ("three", "3"), ("four", "4"), ("five", "5"), ("six", "6", ("seven", "7"), ("eight", "8"), ("nine", "9") };
                    (double, int) t = (4.5, 3);
                    List<int> numberResult = new List<int>();
                    // Read and display lines from the file until the end of
                    // the file is reached.
                    while ((line = sr.ReadLine()) != null)
                    {
                        foreach (var tuple in numbers)
                        {
                            if (line.Contains(tuple.Item1))
                            {
                                if (indexFound > line.IndexOf(tuple.Item1)) //if the entry of the last insert is less than the current iteration
                                {
                                    indexFound = line.IndexOf(tuple.Item1);
                                    numberResult.Insert(0, tuple.Item2);
                                    //add to the front of the list
                                } else if (indexFound < line.IndexOf(tuple.Item1))
                                {
                                    indexFound = line.IndexOf(tuple.Item1);
                                    numberResult.Add(tuple.Item2);
                                    //if its less then add at the end of the list
                                }
                                else
                                {
                                    indexFound = line.IndexOf(tuple.Item1);
                                    numberResult.Add(tuple.Item2);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                // Let the user know what went wrong.
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }
    }
}
