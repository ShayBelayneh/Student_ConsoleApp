using System;
using System.Collections.Generic;
using System.IO;
using DocumentFormat.OpenXml.Bibliography;

namespace Grades.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Ex8();
            AmountOfStudents();

            //תרגיל 1
            List<int> grades = new List<int>();

        }


        //תרגיל 3

        static void AmountOfStudents()
        {
            Console.WriteLine("what is his name");
            string Name = Console.ReadLine();

            Console.WriteLine("how much students you want to keep");
            int Amount = int.Parse(Console.ReadLine());

            //תרגיל 4

            List<Teacher> GradesList = new List<Teacher>();

            for (int i = 0; i < Amount; i++)
            {


                Console.WriteLine("student name?");
                string studentName = Console.ReadLine();

                Console.WriteLine("student Id");
                int studentId = int.Parse(Console.ReadLine());


                Console.WriteLine("his first grades");
                int firstGrade = int.Parse(Console.ReadLine());

                Console.WriteLine("his second grade");
                int secondGrade = int.Parse(Console.ReadLine());

                Console.WriteLine("his third grade");
                int thirdGrade = int.Parse(Console.ReadLine());

                int[] grades = new int[3] { firstGrade, secondGrade, thirdGrade };

                Teacher student = new Teacher(Name, studentName, studentId, grades);

                GradesList.Add(student);


            }

            Console.WriteLine(GradesList[0].studentName);


        }

        //}

        //שאלה 6 

        //static void Ex6()
        //{

        //    FileStream fs = new FileStream($@"C:\textFile\Name.txt", FileMode.CreateNew);
        //    using (StreamWriter writer = new StreamWriter(fs)) ;
        //    {
        //        //writer.WriteLine(GradesList[0].studentName);

        //    }

        //}

        //שאלה 7

        //int counter = 0;
        //string resoult = $"id: {counter}  Teacher Name: {allDetaile.TeacherName} Student Name: {allDetaile.StudentName} Student Id:0-{allDetaile.StudentId},";
        //sw.WriteLine(resoult);

        //}


        // שאלה 8

        static void Ex8()
        {

            Console.WriteLine("Add a student");
            int num = int.Parse(Console.ReadLine());

            switch (num)
            {
                case 1:
                    Console.WriteLine("what your name?");
                    string teacherName = Console.ReadLine();
                    Console.WriteLine("How many students would you like to keep?");
                    int teachersStudents = int.Parse(Console.ReadLine());
                    AmountOfStudents();
                    break;
                case 2:
                    Console.WriteLine("delete student");
                    break;
                case 3:
                    Console.WriteLine("see all");
                    break;


            }

        }

    }
}
//    //שאלה 9



//

//10 שאלה



//Console.WriteLine("whats your name?");



//





















































