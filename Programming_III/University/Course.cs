using System;
namespace University
{
    public class Course
    {
        public string Code;
        public string Name;

        private int Shift; //0: night, 1: day

        public void SetShift(int newShift)
        {
            if (newShift == 0 || newShift == 1)
            {
                Shift = newShift;
            }
            else
            {
                Console.WriteLine("La jornada para la asignatura " + Name + " no puede ser diferente de cero o uno");
            }
        }

        public int GetShift()
        {
            return Shift;
        }
    }
}
