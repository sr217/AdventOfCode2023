using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Text;

namespace PartTwo
{
    public class Program
    {
        public const int RedCubes = 12;
        public const int GreenCubes = 13;
        public const int BlueCubes = 14;
        static void Main(string[] args)
        {
            int totalGamesPossible = 0;
            try
            {
                using (StreamReader sr = new StreamReader(@"C:\Users\stuar\Source\Repos\AdventOfCode2023\DayOnePartTwo\Input\InputSmall.txt"))
                {
                    string line = "";
                    while ((line = sr.ReadLine()) != null)
                    {
                        int currentRed = 0;
                        int currentBlue = 0;
                        int currentGreen = 0;
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
