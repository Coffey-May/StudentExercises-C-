using System;
using System.Collections.Generic;

namespace StudentExercises
{
    //
    public class Student
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SlackHandle { get; set; }
        public Cohort Cohort { get; set; }


        public List<Exercise> Exercises = new List<Exercise>();

        public void addExercise(Exercise exercise)
        {
            Exercises.Add(exercise);
        }


        public void Description()
        {
            Console.WriteLine(this.FirstName + " " + this.LastName);
            Console.WriteLine($"Slack Handle: {this.SlackHandle}");
            Console.WriteLine($"Cohort: {this.Cohort.CohortName}");
            foreach (Exercise exercise in this.Exercises)
            {
                Console.WriteLine($"Currently working on {exercise.Name}");
            }
            Console.WriteLine($"-------------------");
        }
        // Constructor
        public Student(string firstName, string lastName, string slackHandle, Cohort cohort)
        {
            FirstName = firstName;
            LastName = lastName;
            SlackHandle = slackHandle;
            Cohort = cohort;
        }

    }
}