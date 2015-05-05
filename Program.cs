using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignement_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[3];
            students[0] = new Student("Arturo Haas", Convert.ToDateTime("27/11/1988"),"TI III A","Nine","adx@hotmail.com", "Garzota 2", "Guayaquil", "Guayas", "Ecuador");
            students[1] = new Student();
            students[2] = new Student();
            Course course = new Course("Programming with C#");
            course.AddStudents(students);
            Teacher[] teachers = new Teacher[3];
            course.AddTeacher(teachers);
            Degree degree = new Degree("Bachelor of Science");
            degree.AddCourse(course);
            UProgram universityProgram = new UProgram("Information Technology", degree.DegreeName, "MIT");
            universityProgram.AddDegree(degree);
            Console.WriteLine("The {0} program contains the {1} degree\nThe {1} degree contains the course {2} \nThe {2} course contains {3} student<s>",
            universityProgram.UniversityProgramName, universityProgram.Degree.DegreeName, universityProgram.Degree.Course.CourseName, Student.StudentCount1());
            Console.WriteLine("{0} is my name", students[0].PersonName);
            
            Console.Read();
        }
    }

    /// <summary>
    /// Class base for person
    /// </summary>
    public class Person
    {
        #region Fields

        string personName, personAdress, personCity, personStateProvince, personCountry;
        DateTime personBirthday;       

        #endregion

        #region Properties

        public string PersonName
        {
            get { return personName; }
            set { personName = value; }
        }
        
        public DateTime PersonBirthday
        {
            get { return personBirthday; }
            set { personBirthday = value; }
        }

        public string PersonAdress
        {
            get { return personAdress; }
            set { personAdress = value; }
        }

        public string PersonCity
        {
            get { return personCity; }
            set { personCity = value; }
        }

        public string PersonStateProvince
        {
            get { return personStateProvince; }
            set { personStateProvince = value; }
        }

        public string PersonCountry
        {
            get { return personCountry; }
            set { personCountry = value; }
        }      

        #endregion
    }

    /// <summary>
    /// Class for student
    /// </summary>
    public class Student : Person
    {
        #region Fields

        string studentCourse, studentNote, studentEmail;
        static int studentCount = 0;

        #endregion

        #region Properties

        public string StudentCourse
        {
            get { return studentCourse; }
            set { studentCourse = value; }
        }

        public string StudentNote
        {
            get { return studentNote; }
            set { studentNote = value; }
        }

        public string StudentEmail
        {
            get { return studentEmail; }
            set { studentEmail = value; }
        }

        public static int StudentCount
        {
            get { return studentCount; }
            set { studentCount = value; }
        }

        #endregion

        #region Constructor

        public Student(string _StudentName = "", DateTime _StudentBirthday = default(DateTime),string _StudentCourse = "", string _StudentNote = "", string _StudentEmail = "", string _StudenAdress = "", string _StudentCity = "", string _StudentStateProvince = "", string _StudentCountry = "")
        {
            this.PersonName = _StudentName;
            this.PersonBirthday = _StudentBirthday;
            this.PersonAdress = _StudenAdress;
            this.PersonCity = _StudentCity;
            this.PersonStateProvince= _StudentStateProvince;
            this.PersonCountry = _StudentCountry;
            this.studentCourse = _StudentEmail;
            this.studentNote = _StudentNote;
            this.studentEmail = _StudentEmail;
            studentCount++;
        }

        #endregion

        #region Methods

        public void TakeTest()
        {
            Console.WriteLine("{0} is taking a Test", PersonName);
        }

        public static int StudentCount1()
        {
            return studentCount;
        }

        #endregion
    }

    /// <summary>
    /// Class for teacher
    /// </summary>
    public class Teacher : Person
    {
        #region Fields

        string teacherCourses, teacherID, teacherPhone;

        #endregion

        #region Properties

        public string TeacherCourses
        {
            get { return teacherCourses; }
            set { teacherCourses = value; }
        }

        public string TeacherID
        {
            get { return teacherID; }
            set { teacherID = value; }
        }

        public string TeacherPhone
        {
            get { return teacherPhone; }
            set { teacherPhone = value; }
        }

        #endregion

        #region Constructor

        public Teacher(string _TeacherName = "", DateTime _TeacherBirthday = default(DateTime),string _TeacherCourses = "", string _TeacherID = "", string _TeacherPhone = "", string _TeacherAdress = "", string _TeacherCity = "", string _TeacherStateProvince = "", string _TeacherCountry = "")
        {
            this.PersonName = _TeacherName;
            this.PersonBirthday = _TeacherBirthday;
            this.PersonAdress = _TeacherAdress;
            this.PersonCity = _TeacherCity;
            this.PersonStateProvince= _TeacherStateProvince;
            this.PersonCountry = _TeacherCountry;
            this.teacherPhone = _TeacherPhone;
            this.teacherID = _TeacherID;
            this.teacherPhone = _TeacherPhone;           
        }

        #endregion

        #region Methods

        public void GradeTest()
        {
            Console.WriteLine("{0} is creating a Test", PersonName);
        }

        #endregion
    }


    /// <summary>
    /// Class for University Program
    /// </summary>
    public class UProgram
    {
        #region Fields

        string universityProgramName, universityDegreeOffered, universityDepartmentHead;
        Degree degree;

        #endregion

        #region Properties

        public string UniversityProgramName
        {
            get { return universityProgramName; }
            set { universityProgramName = value; }
        }

        public string UniversityDegreeOffered
        {
            get { return universityDegreeOffered; }
            set { universityDegreeOffered = value; }
        }

        public string UniversityDepartmentHead
        {
            get { return universityDepartmentHead; }
            set { universityDepartmentHead = value; }
        }

        public Degree Degree
        {
            get { return degree; }
            set { degree = value; }
        }

        #endregion

        #region Constructor

        public UProgram(string _UniversityProgramName, string _UniversityDegreeOffered, string _UniversityDepartmentHead)
        {
            this.universityProgramName = _UniversityProgramName;
            this.universityDegreeOffered = _UniversityDegreeOffered;
            this.universityDepartmentHead = _UniversityDepartmentHead;
        }

        #endregion

        #region Methods

        public void AddDegree(Degree _degree)
        {
            this.degree = _degree;
        }

        #endregion
    }

    /// <summary>
    /// Class for Degree Information
    /// </summary>
    public class Degree
    {
        #region Fields

        string degreeName;
        Course course;

        #endregion

        #region Properties

        public string DegreeName
        {
            get { return degreeName; }
            set { degreeName = value; }
        }

        public Course Course
        {
            get { return course; }
            set { course = value; }
        }

        #endregion

        #region Constructor

        public Degree(string _DegreeName)
        {
            this.degreeName = _DegreeName;
        }

        #endregion

        #region Methods

        public void AddCourse(Course _course)
        {
            this.course = _course;
        }

        #endregion
    }

    /// <summary>
    /// Class for Course Information
    /// </summary>
    public class Course
    {
        #region Fields

        string courseName;
        Student[] student; 
        Teacher[] teacher;
        
        #endregion

        #region Properties

        public string CourseName
        {
            get { return courseName; }
            set { courseName = value; }
        }

        public Student[] Student
        {
            get { return student; }
            set { student = value; }
        }

        public Teacher[] Teacher
        {
            get { return teacher; }
            set { teacher = value; }
        }

        #endregion

        #region Constructor

        public Course(string _CourseName)
        {
            this.courseName = _CourseName;
        }

        #endregion

        #region Methods

        public void AddStudents(Student[] _student)
        {
            this.student =_student;
        }

        public void AddTeacher(Teacher[] _teacher)
        {
            this.teacher = _teacher;
        }

        #endregion

    }
}
