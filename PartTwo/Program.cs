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
                using (StreamReader sr = new StreamReader(@"C:\Users\Stuart\source\repos\AdventOfCode2023\DayOne\PartTwo\Input\Input.txt"))
                {
                    string line;
                    int totalValues = 0;
                    var builder = new StringBuilder();
                    char[] charArr;
                    // Read and display lines from the file until the end of
                    // the file is reached.
                    while ((line = sr.ReadLine()) != null)
                    {
                        charArr = line.ToCharArray();
                        foreach (char ch in charArr)
                        {
                            if (Char.IsDigit(ch))
                            {
                                builder.Append(ch);
                            }
                        }
                        string number = builder.ToString();
                        builder.Clear();
                        char firstNumber = number[0];
                        char secondNumber = number[number.Length - 1];
                        string number2 = firstNumber.ToString() + secondNumber.ToString();
                        int actualNumber = Int32.Parse(number2);
                        //Console.WriteLine(actualNumber);
                        number = string.Empty;
                        totalValues += actualNumber;
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
