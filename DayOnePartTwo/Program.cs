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
                using (StreamReader sr = new StreamReader(@"C:\Users\stuar\Source\Repos\AdventOfCode2023\DayOnePartTwo\Input\InputSmall.txt"))
                {
                    string line;
                    int totalValues = 0;
                    string stringBuilder = "";
                    var numbers = new[] { ("one", "1"), ("two", "2"), ("three", "3"), ("four", "4"), ("five", "5"), ("six", "6"), ("seven", "7"), ("eight", "8"), ("nine", "9") };
                    int numbersLength = numbers.Length;
                    // Read and display lines from the file until the end of
                    // the file is reached.
                    while ((line = sr.ReadLine()) != null)
                    {
                        foreach(var tuple in numbers)
                        {
                            if (line.Contains(tuple.Item1))
                            {
                                stringBuilder += tuple.Item2;
                            }
                        }

                        string firstNumber = stringBuilder.Substring(0, 1);
                        string lastNumber = stringBuilder.Substring(stringBuilder.Length - 1);
                        string twoDigitString = firstNumber + lastNumber;
                        int numericValue = Int32.Parse(twoDigitString);
                        Console.WriteLine(numericValue);
                        totalValues += numericValue;
                       
                        stringBuilder = "";
                    }
                    Console.WriteLine(totalValues);
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
