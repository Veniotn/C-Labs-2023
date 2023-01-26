// See https://aka.ms/new-console-template for more information

using Util;

//Custom exception program.


public class Challenge6
{
    public static void Main(string[] args)
    {
        bool exit = false;
        do
        {
            try
            {
                const int grade = 1;
                int classSize;
                //Setting our array to a dynamic size based on the input given
                Console.WriteLine("Welcome to the NSCC Student Manager! \n\n");
                classSize = Ask.AskInt("How many students would you like to enter information on?");
                var classGrades =
                    new string[classSize,
                        grade + 1]; //we add one to get the right amounts of columns, there is only 1 grade being recorded but there is 2 columns in the array

                for (int currentStudent = 0; currentStudent < classSize; currentStudent++)
                {
                    
                    classGrades[currentStudent, 0] = Ask.AskString("Enter name for student " + (currentStudent + 1));

                    classGrades[currentStudent, grade] = Convert.ToString(Ask.AskInt("Enter " + classGrades[currentStudent, 0] + "'s grade: "));
                }

                //Printing student names and their related grades
                Console.WriteLine("Class breakdown:\n");
                for (int currentStudent = 0; currentStudent < classSize; currentStudent++)
                {
                    Console.WriteLine("Student: " + classGrades[currentStudent, 0] + " Grade: " +
                                      classGrades[currentStudent, grade]);
                }

                exit = true;
            }
            catch (MyCustomException e)
            {
                Console.WriteLine(e.Message);
            }

        } while (exit == false);
    }
}