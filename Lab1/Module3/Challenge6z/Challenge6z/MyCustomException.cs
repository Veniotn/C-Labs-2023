using System;

namespace Util
{
    class MyCustomException : FormatException
    {
        
        public MyCustomException(string message) : base(message)
        {
        
        }
    }


    class Ask
    {
        public static string AskString(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }
        
    
        public static int AskInt(string question)
        {
            bool validNum = false;
            while (!validNum)
            {
                System.Console.WriteLine(question);
                var input = System.Console.ReadLine();
                try
                {
                    return Convert.ToInt32(input);
                }
                catch (Exception)
                {
                    throw new MyCustomException("Numbers only.");
                }
            }
            return 0;
        }
        
        
    }//End of ask
    
    
    
    
}

