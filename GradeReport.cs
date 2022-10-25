class GradeReport
    {
        internal string grade;
        internal Student student;
        internal Section section;
        public GradeReport(Student studentnumber, Section sectionindentitier, string grade)
        {
            this.grade = grade;

            student = studentnumber;

            section = sectionindentitier;
        }
        public void Output()
        {
            student.Output();
            section.Output();
            Console.WriteLine($"{grade}");
        }
    }