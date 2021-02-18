using System;

namespace University
{
    class Program
    {
        static void Main(string[] args)
        {
            Student e1 = new Student();
            e1.Name = "Pepito 1";
            e1.Gender = 0;
            e1.Age = 50;

            Student estudiante2 = new Student();
            estudiante2.Name = "Pepito 2";
            estudiante2.Age = 50;

            Student e3 = new Student();
            e3.Name = "Pepito 3";
            e3.Gender = 1;
            e3.Age = 50;

            Student est1 = new Student();
            est1.Name = "Pepito 4";
            est1.Age = 50;

            Course p1 = new Course();
            p1.Code = "p1";
            p1.Name = "Programación 1";
            p1.SetShift(0);

            Course dataStructures1 = new Course();
            dataStructures1.Name = "Data structures 1";
            dataStructures1.Code = "ds1";
            dataStructures1.SetShift(1); // 0:night

            Allocation a1 = new Allocation();
            a1.Student = est1;
            a1.Course = dataStructures1;
            a1.Grade = 2.5f;

            Allocation a2 = new Allocation();
            a2.Student = e3;
            a2.Course = p1;
            a2.Grade = 4f;

            Allocation a3 = new Allocation();
            a3.Student = e3;
            a3.Course = p1;
            a3.Grade = 2f;

            //Pregunta: cuántas asignaciones nocturnas hay?
            int nightCount = 0;
            if (a1.Course.GetShift() == 0)
            {
                nightCount++;
            }
            if (a2.Course.GetShift() == 0)
            {
                nightCount++;
            }
            if (a3.Course.GetShift() == 0)
            {
                nightCount++;
            }

            System.Console.WriteLine("Cantidad asignaciones nocturnas: " + nightCount);

        }
    }
}