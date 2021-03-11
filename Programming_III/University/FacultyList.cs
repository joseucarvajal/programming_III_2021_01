using System;
using System.Collections.Generic;
using University;

namespace Programming_III.University
{
    public class FacultyList
    {
        List<Student> Students = new List<Student>();
        List<Course> Courses = new List<Course>();
        List<Allocation> Allocations = new List<Allocation>();

        public void AddStudent(Student newStudent)
        {
            Students.Add(newStudent);
        }

        public void AddCourse(Course newCourse)
        {
            Courses.Add(newCourse);
        }

        public void AddAllocation(Allocation newAllocation)
        {
            Allocations.Add(newAllocation);
        }

        public int CountAllocationAtNight()
        {
            int count = 0;

            for (int i=0; i < Allocations.Count; i++)
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
