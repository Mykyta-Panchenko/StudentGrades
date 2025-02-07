using System;

class StudentGrades
{
    public void CalculateAverageGrade()
    {
        Console.Write("Enter student name: ");
        string name = Console.ReadLine();

        Console.Write("Enter first grade: ");
        double g1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter second grade: ");
        double g2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter third grade: ");
        double g3 = Convert.ToDouble(Console.ReadLine());

        double avg = (g1 + g2 + g3) / 3;

        if (avg >= 90)
            Console.WriteLine("Grade: A");
        else if (avg >= 80)
            Console.WriteLine("Grade: B");
        else if (avg >= 70)
            Console.WriteLine("Grade: C");
        else
            Console.WriteLine("Grade: F");
    }

    static void Main()
    {
        StudentGrades grades = new StudentGrades();
        grades.CalculateAverageGrade();
    }
}
