using System;
namespace SchoolPractice
{
    public class Student
    {
        private static int nextStudentId = 1;
        public string Name { get; set; }
        public int StudentId { get; set; }
        public int NumberOfCredits { get; set; }
        public double Gpa { get; set; }

        public Student(string name, int studentId,
            int numberOfCredits, double gpa)
        {
            Name = name;
            StudentId = studentId;
            NumberOfCredits = numberOfCredits;
            Gpa = gpa;
        }

        public Student(string name, int studentId)
        : this(name, studentId, 0, 0) { }

        public Student(string name)
        : this(name, nextStudentId)
        {
            nextStudentId++;
        }

        // TODO: Complete the AddGrade method.
        public void AddGrade(int courseCredits, double grade)
        {
            // Update the appropriate properties: NumberOfCredits, Gpa
            double oldQualityScore = Gpa * NumberOfCredits;
            double qualityScore = oldQualityScore + grade * courseCredits;
            NumberOfCredits = NumberOfCredits + courseCredits;
            Gpa = qualityScore / NumberOfCredits;
        }

        //TODO: Complete the GetGradeLevel method here:
        public string GetGradeLevel()
        {
            // Determine the grade level of the student based on NumberOfCredits
            if (this.NumberOfCredits <= 29)
            {
                return "Freshman";
            }
            else if (this.NumberOfCredits > 29 && this.NumberOfCredits <= 59)
            {
                return "Sophmore";
            }
            else if (this.NumberOfCredits > 59 && this.NumberOfCredits <= 89)
            {
                return "Junior";
            }
            else
            {
                return "Senior";
            }
        }

        // TODO: Add your custom 'ToString' method here. Make sure it returns a well-formatted string rather
        //  than just the class fields.
        public override string ToString()
        {
            return $"{GetGradeLevel()} {Name} has obtained {NumberOfCredits} Credits with a GPA of {Gpa}";
        }

        public override bool Equals(object obj)
        {
            return obj is Student student &&
                   StudentId == student.StudentId;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(StudentId);
        }

        // TODO: Add your custom 'Equals' method here. Consider which fields should match in order to call two
        //  Student objects equal.

    }
}