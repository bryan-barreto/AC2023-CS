using System.IO;

namespace Solutions
{
    public static class Day1
    {
        public static void part1()
        {
            string line;
            int value1 = 0;
            int value2 = 0;
            int combined = 0;
            int total = 0;
            try
            {
                // StreamReader sr = new StreamReader("examples/day1-1.txt");
                StreamReader sr = new StreamReader("problems/day1-1.txt");
                while ((line = sr.ReadLine()) != null)
                {
                    for (int x = 0; x <= line.Length; x++)
                    {
                        if (int.TryParse(line[x].ToString(), out value1))
                        {
                            break;
                        }
                    }

                    for (int x = line.Length-1; x > 0; x--)
                    {
                        if (int.TryParse(line[x].ToString(), out value2))
                        {
                            break;
                        }
                    }
                    int.TryParse($"{value1}{value2}", out combined);
                    total += combined;
                }
                Console.WriteLine($"{total}");
            }  
            catch(Exception e)
            {
                Console.WriteLine("Not readable");
            }
            finally
            {
                
            }
        }
    }
}
