using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor1
{
    class Student
    {
        public string Name;
        public string Teacher;
        
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
