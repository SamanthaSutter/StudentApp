using System;
using static System.Console;

namespace StudentApp
{
    class StudentApp
    {
        static void Main(string[] args)
        {
            Student aStudent = new Student();
            

            aStudent.StudentNumber = "1111";
            aStudent.StudentFirstName = "Sally";
            aStudent.StudentLastName = "Smith";
            aStudent.StudentMajor = "English";
            aStudent.Score1 = 90;
            aStudent.Score2 = 80;
            aStudent.Score3 = 100;

            WriteLine(aStudent);

            Student nextStudent = new Student("2222", "Barry", "Bob", "French", 80, 75, 34);
            WriteLine(nextStudent);

            Student someStudent = new Student("555", "Jerry", "Barry");
            WriteLine(someStudent);

            Student anotherStudent = new Student("6666", "Ash", "Tray", "Hell");
            WriteLine(anotherStudent);
            
            Questions question = new Questions();
           

            Student s = new Student();
            s.StudentNumber = question.StudentNumber();
            s.StudentFirstName = question.StudentName("First");
            s.StudentLastName = question.StudentName("Last");
            s.StudentMajor = question.StudentMajor();
            s.Score1 = question.Score(1);
            s.Score2 = question.Score(2);
            s.Score3 = question.Score(3);
            WriteLine(s);
            ReadKey();


        }
    }
}
