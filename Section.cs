class Section
    {
        internal int sectionindentitier;
        internal string semester;
        internal int year;
        internal string instructor;
        internal Course course;
        public Section(int sectionindentitier, Course coursenumber, string semester, int year, string instructor)
        {
            this.sectionindentitier = sectionindentitier;
            this.semester = semester;
            this.year = year;
            this.instructor = instructor;
            course = coursenumber;
        }
        public void Output()
        {
            Console.WriteLine($"{sectionindentitier}");
            course.Output();
        }
    }