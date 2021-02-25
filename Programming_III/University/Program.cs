using System;
using Programming_III.University;

namespace University
{
    class Program
    {
        static void Main(string[] args)
        {
            Faculty faculty = new Faculty();

            Student e1 = new Student();
            e1.Name = "Pepito 1";
            e1.Gender = 0;
            e1.Age = 50;
            faculty.AddStudent(e1);

            Student estudiante2 = new Student();
            estudiante2.Name = "Pepito 2";
            estudiante2.Age = 50;
            faculty.AddStudent(estudiante2);

            Student e3 = new Student();
            e3.Name = "Pepito 3";
            e3.Gender = 1;
            e3.Age = 50;
            faculty.AddStudent(e3);

            Student est1 = new Student();
            est1.Name = "Pepito 4";
            est1.Age = 50;
            faculty.AddStudent(est1);

            Course p1 = new Course();
            p1.Code = "p1";
            p1.Name = "Programación 1";
            p1.SetShift(0);
            faculty.AddCourse(p1);
            

            Course dataStructures1 = new Course();
            dataStructures1.Name = "Data structures 1";
            dataStructures1.Code = "ds1";
            dataStructures1.SetShift(1);
            faculty.AddCourse(dataStructures1);

            Allocation a1 = new Allocation();
            a1.Student = est1;
            a1.Course = dataStructures1;
            a1.Grade = 2.5f;
            faculty.AddAllocation(a1);

            Allocation a2 = new Allocation();
            a2.Student = e3;
            a2.Course = p1;
            a2.Grade = 4f;
            faculty.AddAllocation(a2);

            Allocation a3 = new Allocation();
            a3.Student = e3;
            a3.Course = p1;
            a3.Grade = 2f;
            faculty.AddAllocation(a3);

            Allocation a4 = new Allocation();
            a4.Student = est1;
            a4.Course = p1;
            a4.Grade = 2f;
            faculty.AddAllocation(a4);


            //Question: How many allocations there are at night?,
            int nightCountNewMethod = faculty.CountAllocationAtNight();
            System.Console.WriteLine("Amount of nightly allocations (new way): " + nightCountNewMethod);


        }
    }
}