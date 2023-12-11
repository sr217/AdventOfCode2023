using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Text;

namespace PartTwo
{
    public class Program
    {
        static void Main(string[] args)
        {
            int totalValues = 0;
            Dictionary<string, int> numbers = new Dictionary<string, int>()
            {
                {"one", 1},
                {"two", 2},
                {"three", 3},
                {"four", 4},
                {"five", 5},
                {"six", 6},
                {"seven", 7},
                {"eight", 8},
                {"nine", 9}
            };

            for (int i = 0; i <= 9; i++)
            {
                numbers.Add(i.ToString(), i);
            }
            try
            {
                using (StreamReader sr = new StreamReader(@"C:\Users\stuar\Source\Repos\AdventOfCode2023\DayOnePartTwo\Input\InputSmall.txt"))
                {
                    string line = "";
                    while ((line = sr.ReadLine()) != null)
                    {
                        
                        int index = 0;
                        int firstValue = 0;
                        int lastValue = 0;
                        int firstIndex = line.Length;
                        int lastIndex = -1;

                        foreach (var key in numbers)
                        {
                            if (line.Contains(key.Key))
                            {
                                index = line.IndexOf(key.Key);

                                if (index < firstIndex)
                                {
                                    firstIndex = index;
                                    firstValue = key.Value;

                                }

                                index = line.LastIndexOf(key.Key); //This operation takes care of retrieving a potential duplicate later on in the string

                                if (index > lastIndex)
                                {
                                    lastIndex = index;
                                    lastValue = key.Value;
                                }
                            }
                        }
                        
                        string number = firstValue.ToString() + lastValue.ToString();
                        Console.WriteLine(number);
                        totalValues += Int32.Parse(number);
                        
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
