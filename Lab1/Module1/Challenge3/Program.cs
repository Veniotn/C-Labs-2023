
namespace Challenge3;

public class Challenge3
{
    public static void Main(string[] args)
    {
        

        for (int cycle = 0; cycle < 5; cycle++)
        {
            //setting the default values each cycle
            int currentNum = 1, maxNum = 10;
            bool backwardCount = false;
            
            
            Console.WriteLine("\nCurrent cycle: " + (cycle + 1));//printing the current cycle number
            while (currentNum > 0)
            {
                if (!backwardCount)
                {
                    backwardCount = currentNum == (maxNum - 1); //if the current number is 9 we know the next will be 10
                    Console.WriteLine(currentNum);
                    currentNum++;
                }
                else
                {
                    Console.WriteLine(currentNum);//if backward count is true just reverse count and print the numbers
                    currentNum--;
                }
            }
        }
    }
}