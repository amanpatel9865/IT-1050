using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor1
{
     class Student
    {
        private string Name;
        private string Teacher;

        public Student(string name, string teacher)
        {
            this.Name = name;
            this.Teacher = teacher;
        }
        
        public void Speak(string WhatToSay)
        {
            string output = this.Name;

            output += " ";

            output += "who teaches ";

            output += this.Teacher;

            output += " . ";
        }


    }
}
