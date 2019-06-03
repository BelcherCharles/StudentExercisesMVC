using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentExercisesMVC.Models
{
    public class Instructor : Person
    {
        public void AssignExercise(Exercise exerciseToAssign, Student studentToAssign)
        {
            studentToAssign.StudentExs.Add(exerciseToAssign);

            Console.WriteLine($"{FirstName} just assigned {exerciseToAssign.ExerciseName} to {studentToAssign.FirstName}.");
        }
    }
}
