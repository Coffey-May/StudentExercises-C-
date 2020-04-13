using System;
using System.Collections.Generic;
using System.Linq;


namespace StudentExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercise MartinsAquarium = new Exercise("Martin's Aquarium", "HTML");
            Exercise Glassdale = new Exercise("Glassdale", "Javascript");
            Exercise KandyKorner = new Exercise("Kandy Korner", "Javascript");
            Exercise Nutshell = new Exercise("Nutshell", "React.js");


            List<Exercise> exercises = new List<Exercise>();
            exercises.Add(MartinsAquarium);
            exercises.Add(Glassdale);
            exercises.Add(KandyKorner);
            exercises.Add(Nutshell);


            Cohort Cohort36 = new Cohort("Cohort 36");
            Cohort Cohort37 = new Cohort("Cohort 37");
            Cohort Cohort38 = new Cohort("Cohort 38");
            Cohort Cohort39 = new Cohort("Cohort 39");

            List<Cohort> cohorts = new List<Cohort>();

            cohorts.Add(Cohort36);
            cohorts.Add(Cohort37);


            Student JohnGilliam = new Student("John", "Gilliam", "John Gilliam", Cohort37);
            Cohort37.addStudent(JohnGilliam);
            Student HoldenParker = new Student("Holden", "Parker", "Holden Parker", Cohort37);
            Cohort37.addStudent(HoldenParker);
            Student WillyMetcalf = new Student("Willy", "Metcalf", "Willy Metcalf", Cohort37);
            Cohort37.addStudent(WillyMetcalf);
            Student JansenVanDerSpuy = new Student("Jansen", "van der Spuy", "Jansen van der Spuy", Cohort37);
            Cohort37.addStudent(JansenVanDerSpuy);
            Student SpencerTruett = new Student("Spencer", "Truett", "Spencer Truett", Cohort37);
            Cohort37.addStudent(SpencerTruett);
            Student JohnLong = new Student("John", "Long", "John Long", Cohort36);
            Cohort36.addStudent(JohnLong);
            Student CoffeyMay = new Student("Coffey", "May", "CM", Cohort37);
            Cohort37.addStudent(CoffeyMay);

            List<Student> students = new List<Student>();
            students.Add(JohnGilliam);
            students.Add(HoldenParker);
            students.Add(WillyMetcalf);
            students.Add(JansenVanDerSpuy);
            students.Add(SpencerTruett);
            students.Add(JohnLong);
            students.Add(CoffeyMay);



            Instructor SteveBrownlee = new Instructor("Steve", "Brownlee", "coach", Cohort37, "Dad Jokes");
            Instructor MoSilvera = new Instructor("Mo", "Silvera", "Mo", Cohort37, "Everything");
            Instructor LeahHoefling = new Instructor("Leah", "Hoefling", "Leah", Cohort37, "Awesomeness");
            Instructor AdamSheaffer = new Instructor("Adam", "Sheaffer", "adamsheaf", Cohort37, "stuff");
            Instructor RoseWisotzky = new Instructor("Rose", "Wisotzky", "Rose Wisotzky", Cohort37, "stuff");
            Instructor BrendaLong = new Instructor("Brenda", "Long", "bjlong", Cohort37, "stuff");

            List<Instructor> instructors = new List<Instructor>();
            instructors.Add(SteveBrownlee);


            SteveBrownlee.assignExercise(Nutshell, SpencerTruett);
            SteveBrownlee.assignExercise(KandyKorner, JohnLong);
            SteveBrownlee.assignExercise(MartinsAquarium, HoldenParker);
            SteveBrownlee.assignExercise(Glassdale, JansenVanDerSpuy);
            SteveBrownlee.assignExercise(Glassdale, WillyMetcalf);
            SteveBrownlee.assignExercise(Nutshell, WillyMetcalf);


            foreach (Student student in Cohort37.Students)
            {
                student.Description();
            }

            foreach (Student student in Cohort36.Students)
            {
                student.Description();
            }

            var JavascriptExercises = exercises.Where(ex => (ex.Language == "Javascript"));

            foreach (var e in JavascriptExercises)
            {
                Console.WriteLine($"{e.Name}-- > exercises_in_javascript");
            }

            var StudentsInCohort = students.Where(st => (st.Cohort == Cohort37));

            foreach (var s in StudentsInCohort)
            {
                Console.WriteLine($"{s.FirstName} --> cohort 37 students by first name");
            }

            var InstructorsInCohort = instructors.Where(ins => (ins.Cohort == Cohort37));

            foreach (var ins in InstructorsInCohort)
            {
                Console.WriteLine($"{ins.FirstName} --> instructors by first name");
            }

            var StudentsLastNames = students.OrderBy(stu => stu.LastName);

            foreach (var stu in StudentsLastNames)
            {
                Console.WriteLine($"{stu.LastName} --> students by last name");
            }


            var StudentsWithoutExercises = students.Where(stu => stu.Exercises.Count == 0);

            foreach (var stu in StudentsWithoutExercises)
            {
                Console.WriteLine($"{stu.FirstName} -->last name");
            }

            var StudentsWithMostExercises = students.Where(stu => stu.Exercises.Count > 1);

            foreach (var stu in StudentsWithMostExercises)
            {
                Console.WriteLine($"{stu.FirstName} --> student with most exercises");
            }

            var CohortCount = cohorts.Count();
            Console.WriteLine(CohortCount);
            Console.WriteLine("cohort count");









        }
    }
}



