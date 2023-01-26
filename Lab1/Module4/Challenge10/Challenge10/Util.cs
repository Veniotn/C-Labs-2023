//event handling challenge


namespace Util;


    public class Console
    {
        public static string Ask(string question)
        {
            System.Console.WriteLine(question);
            return System.Console.ReadLine();
        }

        public static int AskInt(string question)
        {
            bool validNum = false;
            while (!validNum)
            {
                System.Console.WriteLine(question);
                var input = System.Console.ReadLine();
                if (int.TryParse(input, out int value))
                {
                    return Convert.ToInt32(input);
                }
                else
                {
                    System.Console.WriteLine("Invalid input.");
                }
            }

            return 0;
        }


        public static int AskIntWithRange(string question, int lowerRange, int higherRange)
        {
            bool validNum = false;
            while (!validNum)
            {
                System.Console.WriteLine(question);
                var input = System.Console.ReadLine();
                int num;
                if (int.TryParse(input, out int value))
                {
                    num = Convert.ToInt32(input);
                    if (num >= lowerRange && num <= higherRange)
                    {
                        return num;
                    }

                    System.Console.WriteLine("Sorry, only numbers between {0}-{1}", lowerRange, higherRange);
                }
                else
                {
                    System.Console.WriteLine("Invalid input.");
                }
            }

            return 0;
        }
    }