class Student
{
    internal string name;
    internal int studentnumber;
    internal int classstudent;
    internal string major;
    public Student(string name, int studentnumber, int classstudent, string major)
    {
        this.name = name;
        this.studentnumber = studentnumber;
        this.classstudent = classstudent;
        this.major = major;
    }
    public void Output()
    {
        Console.WriteLine($"{name}\t{studentnumber}\t{classstudent}\t{major}");
    }
}