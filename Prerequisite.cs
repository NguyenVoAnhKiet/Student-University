 class Prerequisite
    {
        internal string prerequisitenumber;
        internal Course course;
        public Prerequisite(Course coursenumber, string prerequisitenumber)
        {
            this.prerequisitenumber = prerequisitenumber;
            course = coursenumber;
        }
    }