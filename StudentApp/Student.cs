using System;
using System.Collections.Generic;
using System.Text;

namespace StudentApp
{
    class Student
    {
        private string studentNumber;
        private string studentFirstName;
        private string studentLastName;
        private string studentMajor;
        private double score1;
        private double score2;
        private double score3;
        private const double TOTALSCORES = 3;

        public Student()
        { }
        public Student(string studentNumber)
        {
           this.studentNumber = studentNumber;
        }

        public Student(string studentNumber, string studentFirstName,
            string studentLastName)
        {
            this.studentNumber = studentNumber;
            this.studentFirstName = studentFirstName;
            this.studentLastName = studentLastName;
        }

        public Student(string studentNumber, string studentFirstName,
            string studentLastName, string studentMajor)
        {
            this.studentNumber = studentNumber;
            this.studentFirstName = studentFirstName;
            this.studentLastName = studentLastName;
            this.studentMajor = studentMajor;

        }

        public Student(string studentNumber, string studentFirstName,
            string studentLastName, string studentMajor, double score1,
            double score2, double score3)
        {
            this.studentNumber = studentNumber;
            this.studentFirstName = studentFirstName;
            this.studentLastName = studentLastName;
            this.studentMajor = studentMajor;
            this.score1 = score1;
            this.score2 = score2;
            this.score3 = score3;
        }

        public double CalculateAverage()
        {
            return (score1 + score2 + score3) / TOTALSCORES;
        }

        public string StudentNumber
        {
            get { return studentNumber;  }
            set { studentNumber = value; }
        }

        public string StudentFirstName
        {
            get { return studentFirstName; }
            set { studentFirstName = value; }
        }

        public string StudentLastName
        {
            get { return studentLastName; }
            set { studentLastName = value; }
        }

        public string StudentMajor
        {
            get { return studentMajor; }
            set { studentMajor = value; }
        }

        public double Score1
        {
            get { return score1;  }
            set { score1 = value; }
        }

        public double Score2
        {
            get { return score2; }
            set { score2 = value; }
        }

        public double Score3
        {
            get { return score3; }
            set { score3 = value; }
        }

        public string FullName
        {
            get { return studentFirstName + " " + studentLastName; }
        }

        public override string ToString()
        {
            return "\n\nName:\t" + FullName + "\nMajor:\t" + studentMajor +
                "\nExam Score 1:\t" + score1 + "\nExam Score 2:\t" + score2 +
                "\nExam Score 3:\t" + score3 + "\nScore Average:\t" + CalculateAverage();

        }
    }

}
