namespace HW_Mod9Part3
{
    internal class Tass7
    {
        public static void Task7()
        {
            StudentGrade[] grades = {
            new StudentGrade { Subject = "Math", Grade = 90 },
            new StudentGrade { Subject = "Physics", Grade = 80 },
            new StudentGrade { Subject = "Chemistry", Grade = 85 }
        };

            int maxGrade = int.MinValue;
            string maxSubject = string.Empty;
            double totalGrade = 0;

            foreach (var grade in grades)
            {
                if (grade.Grade > maxGrade)
                {
                    maxGrade = grade.Grade;
                    maxSubject = grade.Subject;
                }
                totalGrade += grade.Grade;
            }

            double averageGrade = totalGrade / grades.Length;

            Console.WriteLine($"Highest grade in {maxSubject}: {maxGrade}");
            Console.WriteLine($"Average grade: {averageGrade}");
        }
    }
}
