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
                    var numbers = new[] { ("one", "1"), ("two", "2"), ("three", "3"), ("four", "4"), ("five", "5"), ("six", "6"), ("seven", "7"), ("eight", "8"), ("nine", "9") };
                    //above flaw for iterating through the above array and then comparing is that if two of the same numbers come up in one line then it will miss the second iteration.
                    List<string> numberResult = new List<string>();
                    StringBuilder builder = new StringBuilder();
                    char[] charArr;
                    // Read and display lines from the file until the end of
                    // the file is reached.
                    while ((line = sr.ReadLine()) != null)
                    {
                        charArr = line.ToCharArray();
                        foreach (char element in charArr)
                        {
                            if (Char.IsDigit(element))
                            {
                                numberResult.Add(element.ToString());
                            }
                            else if (Char.IsLetter(element))
                            {
                                builder.Append(element);
                                if (builder.Length >= 3)
                                {
                                    string tempString = builder.ToString();
                                    foreach (var tuple in numbers)
                                    {
                                        if (tempString.Contains(tuple.Item1))
                                        {
                                            numberResult.Add(tuple.Item2);
                                            tempString = "";

                                        }
                                    }
                                }
                            }
                        }
                        foreach (string num in numberResult)
                        {
                            Console.Write(num);
                        }
                        Console.WriteLine();
                        numberResult.Clear();
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
