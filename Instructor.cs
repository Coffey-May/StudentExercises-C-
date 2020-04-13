using System;
using System.Collections.Generic;

namespace StudentExercises
{
    public class Instructor
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SlackHandle { get; set; }
        public Cohort Cohort { get; set; }
        public string Specialty { get; set; }

        public void assignExercise(Exercise exercise, Student student)
        {
            student.Exercises.Add(exercise);
        }

        // public List<Pet> Pets = new List<Pet>();
        // public void addPet(Pet pet)
        // {
        //     Pets.Add(pet);
        // }

        // Constructor
        public Instructor(string firstName, string lastName, string slackHandle, Cohort cohort, string specialty)
        {
            FirstName = firstName;
            LastName = lastName;
            SlackHandle = slackHandle;
            Cohort = cohort;
            Specialty = specialty;
        }
    }
}