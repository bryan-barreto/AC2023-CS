using System.IO;

namespace day1
{
    class day1_1
    {
        static void Main(string[] args)
        {
            String file;
            try
            {
                StreamReader sr = new StreamReader("examples/day1-1.txt");
                line = sr.StreamLine();
                Console.WriteLine(line);
            }
            catch(Exception e)
            {

            }
            finally
            {

            }
        }
    }
}
