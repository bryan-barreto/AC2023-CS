using System.IO;

namespace day1
{
    class day1_1
    {
        static void Main(string[] args)
        {
            string line;
            int value1 = 0;
            int value2 = 0;
            int combined = 0;
            int total = 0;
            try
            {
                // StreamReader sr = new StreamReader("day1-1-example.txt");
                StreamReader sr = new StreamReader("day1-1-problem.txt");
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
