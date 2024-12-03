
using System;

public class LinkedList
{
    private Node head;

    public LinkedList()
    {
        head = null;
    }

    public void AddStudent(int id, string name, double firstExamScore, double secondExamScore)
    {
        Student student = new Student(id, name, firstExamScore, secondExamScore);
        Node newNode = new Node(student);

        if (head == null)
        {
            head = newNode;
        }
        else
        {
            Node current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode; 
        }
    }

    public void SortList()
    {
        if (head == null || head.Next == null)
            return;  

        Node current = head;
        Node index = null;
        double tempScore;
        string tempGrade;

        while (current != null)
        {
            index = current.Next;
            while (index != null)
            {
                if (current.Data.TotalScore > index.Data.TotalScore)
                {
                    tempScore = current.Data.TotalScore;
                    current.Data.TotalScore = index.Data.TotalScore;
                    index.Data.TotalScore = tempScore;

                    tempGrade = current.Data.Grade;
                    current.Data.Grade = index.Data.Grade;
                    index.Data.Grade = tempGrade;

                    int tempID = current.Data.ID;
                    current.Data.ID = index.Data.ID;
                    index.Data.ID = tempID;

                    string tempName = current.Data.Name;
                    current.Data.Name = index.Data.Name;
                    index.Data.Name = tempName;
                }
                index = index.Next;
            }
            current = current.Next;
        }
    }

    public void DisplayStudents()
    {
        if (head == null)
        {
            Console.WriteLine("No students to display.");
            return;
        }

        Node current = head;
        Console.WriteLine("Student ID	Name		First Exam Score	Second Exam Score	Total Score	Grade");
        while (current != null)
        {
            Console.WriteLine($"{current.Data.ID}		{current.Data.Name}		{current.Data.FirstExamScore}		{current.Data.SecondExamScore}		{current.Data.TotalScore}		{current.Data.Grade}");
            current = current.Next;
        }
    }
}
