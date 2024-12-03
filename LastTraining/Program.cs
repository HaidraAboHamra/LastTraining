
using System;

class Program
{
    static void Main()
    {
        LinkedList studentList = new LinkedList();
        
        // Collecting student information from the user
       
        void haidra()
        {
            Console.WriteLine("Enter the number of students:");
            int studentCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine($"Enter details for student {i + 1}:");
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("First Exam Score: ");
                double firstExamScore = double.Parse(Console.ReadLine());
                Console.Write("Second Exam Score: ");
                double secondExamScore = double.Parse(Console.ReadLine());

                studentList.AddStudent(id, name, firstExamScore, secondExamScore);
            }

            Console.WriteLine("Before sorting:");
            studentList.DisplayStudents();

            // Sorting the list by total score
            studentList.SortList();

            Console.WriteLine("After sorting by total score:");
            studentList.DisplayStudents();
        }
        while (true)
        {
            Console.WriteLine("Enter The Program? if yes type 1 if no type 2");
            int result = int.Parse(Console.ReadLine());
            if(result == 1)
            haidra();
            else
                return;

        }
    }
}
