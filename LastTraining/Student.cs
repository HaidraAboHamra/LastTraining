
using System;

public class Student
{
    public int ID { get; set; }
    public string Name { get; set; }
    public double FirstExamScore { get; set; }
    public double SecondExamScore { get; set; }
    public double TotalScore { get; set; }
    public string Grade { get; set; }

    public Student(int id, string name, double firstExamScore, double secondExamScore)
    {
        ID = id;
        Name = name;
        FirstExamScore = firstExamScore;
        SecondExamScore = secondExamScore;
        CalculateGrade();
    }

    public void CalculateGrade()
    {
        TotalScore = (FirstExamScore + SecondExamScore) / 2;

        if (TotalScore < 50)
            Grade = "Fail";
        else if (TotalScore >= 50 && TotalScore < 60)
            Grade = "Good";
        else if (TotalScore >= 60 && TotalScore < 80)
            Grade = "Very Good";
        else
            Grade = "Excellent!";
    }
}
