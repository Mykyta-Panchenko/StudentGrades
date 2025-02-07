using System;

class StudentGrades
{
    const int GRADE_A = 90;
    const int GRADE_B = 80;
    const int GRADE_C = 70;
    
    public void CalculateAverageGrade()
    {
        Console.Write("Enter first grade: ");
        double g1 = Convert.ToDouble(Console.ReadLine());
    
        Console.Write("Enter second grade: ");
        double g2 = Convert.ToDouble(Console.ReadLine());
    
        Console.Write("Enter third grade: ");
        double g3 = Convert.ToDouble(Console.ReadLine());
    
        double avg = (g1 + g2 + g3) / 3;
        Console.WriteLine($"Grade: {GetGrade(avg)}");
    }
    
    private string GetGrade(double avg)
    {
        if (avg >= GRADE_A)
            return "A";
        if (avg >= GRADE_B)
            return "B";
        if (avg >= GRADE_C)
            return "C";
        return "F";
    }
    static void Main()
    {
        StudentGrades grades = new StudentGrades();
        grades.CalculateAverageGrade();
    }
}
