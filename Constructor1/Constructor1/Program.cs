

namespace Constructor1
{
    class Program
    {
        static void Main(string[] args)
        {
            Instructor Jhon = new Instructor();
            Jhon.Name = "Jhon";
            Jhon.Coursename = "English";

            Instructor Mike = new Instructor();
            Mike.Name = "Mike";
            Mike.Coursename = "Math";

            Student Jane = new Student();
            Jane.Name = "Jane";
            Jane.Teacher = "Jhon";

            Student Joe = new Student();
            Joe.Name = "Joe";
            Joe.Teacher = "Jhon";

            Student Melissa = new Student();
            Melissa.Name = "Melissa";
            Melissa.Teacher = "Mike";

            Student Matt = new Student();
            Matt.Name = "Matt";
            Matt.Teacher = "Mike";


            int JaneGrades = Jhon.SetStudentGrades(45, 50);
            int JoeGrades = Jhon.SetStudentGrades(45, 50);
            int MelissaGrades = Mike.SetStudentGrades(45, 50);
            int MattGrades = Mike.SetStudentGrades(45, 50);


            Instructor.HorizontalDivider();
            Jhon.Speak("Jane is a brilliant lerner and got " + JaneGrades + " grades in exam" );
            Instructor.HorizontalDivider();
            Jhon.Speak("Joe is a brilliant lerner and got " + JoeGrades + " grades in exam");
            Instructor.HorizontalDivider();
            Mike.Speak("Melissa is a brilliant lerner and got " + MelissaGrades + " grades in exam");
            Instructor.HorizontalDivider();
            Mike.Speak("Matt is a brilliant lerner and got " + MattGrades + " grades in exam");
            Instructor.HorizontalDivider();

            System.Console.ReadKey();



        }
    }
}
