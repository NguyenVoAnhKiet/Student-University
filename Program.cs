
using System;
using System.Security.AccessControl;
using System.Security.Cryptography;

namespace DataBase
{
    class Test
    {
        static LinkedList<Student> students = new LinkedList<Student>();
        static LinkedList<Course> courses = new LinkedList<Course>();
        static LinkedList<Section> sections = new LinkedList<Section>();
        static LinkedList<GradeReport> gradereports = new LinkedList<GradeReport>();
        static LinkedList<Prerequisite> prerequisites = new LinkedList<Prerequisite>();
        static void SmithOutput(string studentname)
        {
            foreach (Student student in students)
            {
                if (studentname == student.name)
                {
                    Console.WriteLine(student.name);
                    foreach (GradeReport report in gradereports)
                    {
                        if (student.studentnumber == report.student.studentnumber)
                        {
                            foreach (Section section in sections)
                            {
                                if (report.section.sectionindentitier == section.sectionindentitier)
                                {
                                    foreach (Course course in courses)
                                    {
                                        if (section.course.coursenumber == course.coursenumber)
                                        {
                                            Console.WriteLine(course.coursename);
                                        }
                                    }
                                }
                            }
                            Console.WriteLine(report.grade);
                        }
                    }
                }

            }
        }
        static void CourseOuput(string coursename,int year,string season)
        {
            foreach(Course course in courses)
            {
                if (coursename==course.coursename)
                {
                    foreach(Section section in sections)
                    {
                        if (course.coursenumber==section.course.coursenumber && year==section.year && season==section.semester )
                        {
                            foreach(GradeReport gradereport in gradereports)
                            {
                                if (section.sectionindentitier==gradereport.section.sectionindentitier)
                                {
                                    foreach(Student student in students)
                                    {
                                        if (gradereport.student.name==student.name)
                                        {
                                            Console.WriteLine(student.name);
                                            Console.WriteLine(gradereport.grade);
                                        }
                                    }
                                }                                
                            }
                        }
                    }
                }
            }
        }
        static void PrerequisiteOutput(string coursename)
        {
           foreach(Course course in courses)
           {
            if (coursename==course.coursename)
            {
                foreach(Prerequisite prerequisite in prerequisites)
                {
                    if(course.coursenumber==prerequisite.course.coursenumber)
                    {
                        foreach(Course course1 in courses)
                        {
                            if (prerequisite.prerequisitenumber==course1.coursenumber)
                            {
                                Console.WriteLine(course1.coursename);
                            }
                        }
                    }
                    else 
                        {
                            Console.WriteLine("This Course have no preresiquite or are not exist"); 
                            break;
                        }
                }
            } 
           }
        }
        static int SmithChangeClass(Student  x,int n)
        {
            return x.classstudent=n;
            
        }
        static void Main()
        {
            // ENTER STUDENT============================
            Student smith = new Student("Smith", 17, 1, "CS");
            Student brown = new Student("Brown", 8, 2, "CS");
            students.AddLast(smith);
            students.AddLast(brown);
            //ENTER COURSE ===================================
            Course itcs = new Course("Intro to Computer Science", "CS1310", 4, "CS");
            Course ds = new Course("Data Structures", "CS3320", 4, "CS");
            Course dm = new Course("Discrete Mathematics", "MATH2410", 3, "MATH");
            Course db = new Course("Database", "CS3380", 3, "CS");
            courses.AddLast(itcs);
            courses.AddLast(ds);
            courses.AddLast(dm);
            courses.AddLast(db);
            //ENTER SECTION==============================
            Section s1 = new Section(85, dm, "Fall", 07, "King");
            Section s2 = new Section(92, itcs, "Fall", 07, "Anderson");
            Section s3 = new Section(102, ds, "Spring", 08, "Knuth");
            Section s4 = new Section(112, dm, "Fall", 08, "Chang");
            Section s5 = new Section(119, itcs, "Fall", 08, "Anderson");
            Section s6 = new Section(135, db, "Fall", 08, "Stone  ");
            sections.AddLast(s1);
            sections.AddLast(s2);
            sections.AddLast(s3);
            sections.AddLast(s4);
            sections.AddLast(s5);
            sections.AddLast(s6);
            //ENTER GRADE_REPORT=========================
            GradeReport a = new GradeReport(smith, s4, "B");
            GradeReport b = new GradeReport(smith, s5, "C");
            GradeReport c = new GradeReport(brown, s1, "A");
            GradeReport d = new GradeReport(brown, s2, "A");
            GradeReport e = new GradeReport(brown, s3, "B");
            GradeReport f = new GradeReport(brown, s6, "A");
            gradereports.AddLast(a);
            gradereports.AddLast(b);
            gradereports.AddLast(c);
            gradereports.AddLast(d);
            gradereports.AddLast(e);
            gradereports.AddLast(f);
            //ENTER PREREQUISITE=========================
            Prerequisite x = new Prerequisite(db, "CS3320");
            Prerequisite y = new Prerequisite(db, "MATH2410");
            Prerequisite z = new Prerequisite(ds, "CS1310 ");
            prerequisites.AddLast(x);
            prerequisites.AddLast(y);
            prerequisites.AddLast(z);
            //Xuất danh sách tất cả các khóa học và điểm của ‘Smith’
                //SmithOutput("Brown");
            // Liệt kê tên của những sinh viên đã học học phần khóa học 'Cơ sở dữ liệu' vào mùa thu năm 2008 và điểm tương ứng của các sinh viên đó
                //CourseOuput("Intro to Computer Science",08,"Fall");
            //Liệt kê các điều kiện tiên quyết của khóa học 'Cơ sở dữ liệu'
                //PrerequisiteOutput("Database");
            // Thay đổi lớp của ‘Smith’ bằng 2
                SmithChangeClass(smith,2);
                smith.Output();
        }
    }
}