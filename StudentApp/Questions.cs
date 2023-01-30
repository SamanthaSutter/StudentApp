using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace StudentApp
{
    class Questions
    {
        //first or last name
        public string StudentName(string name)
        {
            string inValue;
            WriteLine("Enter Student's {0} Name: ", name);
            inValue = ReadLine();
            return inValue;
        }

        public string StudentNumber()
        {
            string inValue;
            WriteLine("\n\nEnter in student's number: ");
            inValue = ReadLine();
            return inValue;
        }

        public string StudentMajor()
        {
            string major;
            WriteLine("Enter in student's major: ");
            major = ReadLine();
            return major;
        }

        public double Score(int exam)
        {
            string inValue;
            double score;
            WriteLine("Enter a Value for score {0} ", exam);
            inValue = ReadLine();
            //if not able to convert it it is false
            while (double.TryParse(inValue, out score) == false)
            {
                Write("Please enter a numeric value for score {0}", exam);
                inValue = ReadLine();
            }
            return score;
        }
    }
}
