// See https://aka.ms/new-console-template for more information

public class Challenge4
{
    public static void Main(string[] args)
    {
        const int grade = 1;
        bool exit = false;
        int classSize;

         //Setting our array to a dynamic size based on the input given
         Console.WriteLine("Welcome to the NSCC Student Manager! \n\nHow many students would you like to enter information on?");
         classSize = Convert.ToInt32(Console.ReadLine());
         var classGrades = new string[classSize, grade + 1];//we add one to get the right amounts of columns, there is only 1 grade being recorded but there is 2 columns in the array
         
         for (int currentStudent = 0; currentStudent < classSize; currentStudent++)
         {
             Console.WriteLine("Enter name for student "  + (currentStudent + 1));
             classGrades[currentStudent, 0] = Console.ReadLine();
             Console.WriteLine("Enter " + classGrades[currentStudent,0] + "'s grade: ");
             classGrades[currentStudent, grade] = Console.ReadLine();
         }
         
         //Printing student names and their related grades
         Console.WriteLine("Class breakdown:\n");
         for (int currentStudent = 0; currentStudent < classSize; currentStudent++)
         {
             Console.WriteLine("Student: " + classGrades[currentStudent,0] + " Grade: " + classGrades[currentStudent,grade]);
         }

    }
}