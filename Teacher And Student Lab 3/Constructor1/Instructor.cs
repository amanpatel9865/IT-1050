

namespace Constructor1
{
    class Instructor
    {
       private string Name;
        private string Coursename;
        

        public Instructor(string name, string coursename
        {
            this.Name = name;
            this.Coursename = coursename;
        }

        public static void HorizontalDivider()

        {

            System.Console.WriteLine(" ================================================================================");

        }



        public int SetStudentGrades(int firstnumber,int secondnumber)
        {
            return firstnumber + secondnumber;

        }
        public void Speak(string WhatToSay)
        {
            string output = this.Name;

            output += " ";

            output += "who teaches ";

            output += this.Coursename;

            output += " says ";

            output += WhatToSay;

            output += " . ";

            System.Console.WriteLine(output);
        }
    }

}
