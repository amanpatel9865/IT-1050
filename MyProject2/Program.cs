using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Part1
            System.Console.Write("First Name : ");
            string FirstName = System.Console.ReadLine();

            System.Console.Write("Middle Name : ");
            string MiddleName = System.Console.ReadLine();

            System.Console.Write("Last Name : ");
            string LastName = System.Console.ReadLine();

            string fullname = FirstName + " " + MiddleName + " " + LastName;
            System.Console.WriteLine(fullname);

            System.Threading.Thread.Sleep(4000);



            #endregion
            #region Part2
            double multiplier = 2.54;
            double inches = 12;

            System.Console.Write("Height In Feet : ");
            int heightFeet = int.Parse(System.Console.ReadLine());

            System.Console.Write("Extra Inches : ");
            double heightinches = double.Parse(System.Console.ReadLine());

            double totalheight = 0;

            totalheight += inches * heightFeet * multiplier;
            totalheight += multiplier * heightinches;
            System.Console.WriteLine(totalheight);

            System.Threading.Thread.Sleep(4000);



            #endregion

            System.Console.Write("How old are you?");
            int age = int.Parse(System.Console.ReadLine());

            System.Console.Write("Are you a citizen of abc?");
            bool iscitizen = bool.Parse(System.Console.ReadLine());

            bool canvote = age > 17 && iscitizen;
            System.Console.WriteLine(canvote);

            System.Threading.Thread.Sleep(4000);
            System.Console.WriteLine(fullname + MiddleName + LastName + "height" + "is" + totalheight + "and" + "you" + "vote" + canvote);






        }
    }
}
