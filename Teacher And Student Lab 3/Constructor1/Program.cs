

namespace Constructor1
{
    class Program
    {
        static void Main(string[] args)
        {
            Instructor Jhon = new Instructor("John","English");

            Instructor Mike = new Instructor("Mike", "Math");

            Student Jane = new Student("Jane","John");

            Student Joe = new Student("Joe", "John");

            Student Melissa = new Student("Melissa", "Mike");

            Student Matt = new Student("Matt", "Mike");

            


            int JaneGrades = Jhon.SetStudentGrades(45, 50);
            int JoeGrades = Jhon.SetStudentGrades(45, 40);
            int MelissaGrades = Mike.SetStudentGrades(45, 45);
            int MattGrades = Mike.SetStudentGrades(45, 47);


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
