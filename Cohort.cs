using System;
using System.Collections.Generic;

namespace StudentExercises
{
    public class Cohort
    {
        public string CohortName { get; set; }

        public List<Student> Students = new List<Student>();
        public void addStudent(Student student)
        {
            Students.Add(student);
        }
        public List<Instructor> Instructors = new List<Instructor>();
        public void addInstructor(Instructor instructor)
        {
            Instructors.Add(instructor);
        }
        //Constructor
        public Cohort(string name)
        {
            CohortName = name;
        }
    }
}