    class Course
    {
        internal string coursename;
        internal string coursenumber;
        internal int credithouse;
        internal string department;
        public Course(string coursename, string coursenumber, int credithouse, string department)
        {
            this.coursename = coursename;
            this.coursenumber = coursenumber;
            this.credithouse = credithouse;
            this.department = department;
        }
        public void Output()
        {
            Console.WriteLine($"{coursename}");
        }
    }