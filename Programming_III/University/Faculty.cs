using System;
using University;

namespace Programming_III.University
{
    public class Faculty
    {
        Student[] Students = new Student[5];
        int studentsCount = 0;

        Course[] Courses = new Course[2];
        int coursesCount = 0;

        Allocation[] Allocations = new Allocation[5*2];
        int allocationsCount = 0;

        public void AddStudent(Student newStudent)
        {
            Students[studentsCount] = newStudent;
            studentsCount++;
        }

        public void AddCourse(Course newCourse)
        {
            Courses[coursesCount] = newCourse;
            coursesCount++;
        }

        public void AddAllocation(Allocation newAllocation)
        {
            Allocations[allocationsCount] = newAllocation;
            allocationsCount++;
        }

        public int CountAllocationAtNight()
        {
            int count = 0;

            for (int i=0; i < allocationsCount; i++)
            {
                if(Allocations[i].Course.GetShift() == 0)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
