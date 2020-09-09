using System;

namespace StudentUML_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Student myStudent = new Student();
            Console.WriteLine(myStudent);
            myStudent.FirstName = "Adam";
            myStudent.LastName = "ACkerman";
            myStudent.IsOnProbation = true;
            myStudent.SoonerID = 5;


            Console.WriteLine(myStudent);
        }
    }
}
