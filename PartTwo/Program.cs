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
                using (StreamReader sr = new StreamReader(@"~/Input/InputSmall.txt"))
                {
                    string line;
                    int totalValues = 0;
                    var builder = new StringBuilder();
                    var numbers = new[] { ("one", "1"), ("two" , "2"), ("three", "3"), ("four","4"), ("five","5"), ("six", "6"), ("seven", "7"), ("eight", "8"), ("nine", "9") };

                    // Read and display lines from the file until the end of
                    // the file is reached.
                    while ((line = sr.ReadLine()) != null)
                    {
                        for (int i = 0, i < numbers.Length; i++)
                        {
                            if (line.Contains(numbers[i].Item1))
                            {
                                builder.Append(numbers[i].Item2);
                            }
                        }
                        string firstAndLast = builder[0] + builder[builder.Length-1]
                        int numericValue = Int32.Parse(firstAndLast);
                        totalValues += numericValue;
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
