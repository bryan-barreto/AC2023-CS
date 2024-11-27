using System.IO;

namespace Solutions
{
    class Day2
    {
        public static void part1()
        {
            const int MAXRED = 12;
            const int MAXGREEN = 13;
            const int MAXBLUE = 14;

            int total = 0;

            int errorLine = 0;

            string line;
            try
            {
                // StreamReader input = new StreamReader("examples/day2-1.txt");
                StreamReader input = new StreamReader("problems/day2-1.txt");
                while ((line = input.ReadLine()) != null)
                {
                    string[] splitByColon = line.Split(": ");
                    string gameAsString = splitByColon[0].Remove(0,5);
                    int game = 0;
                    int.TryParse(gameAsString, out game);

                    int red = 0;
                    int green = 0;
                    int blue = 0;


                    string[] splitBySemi = splitByColon[1].Split("; ");
                    foreach (string set in splitBySemi)
                    {
                        
                        string[] splitByComma = set.Split(", ");
                        foreach (string color in splitByComma)
                        {
                            string[] colorToValue = color.Split(" ");
                            int hold = 0;
                            switch (colorToValue[1])
                            {
                                case "red":
                                    int.TryParse(colorToValue[0], out hold);
                                    if (red < hold){
                                        red = hold;
                                    }
                                    break;
                                case "green":
                                    int.TryParse(colorToValue[0], out hold);
                                    if (green < hold){
                                        green = hold;
                                    }
                                    break;
                                case "blue":
                                    int.TryParse(colorToValue[0], out hold);
                                    if (blue < hold){
                                        blue = hold;
                                    }
                                    break;
                                default:
                                    Console.WriteLine($"Error at line {errorLine}");
                                    break;
                            }
                        }
                    }
                    if (red <= MAXRED && green <= MAXGREEN && blue <= MAXBLUE){
                        total += game;
                    }
                }
            }
            catch
            {
                Console.WriteLine("Error");
            }


            Console.WriteLine(total);
        }
    }
}