using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentExercisesMVC.Models
{
    public class Exercise
    {
        public int ExerciseId { get; set; }
        public string ExerciseName { get; set; }
        public string Language { get; set; }
        public List<Student> AssignedStudents { get; set; } = new List<Student>();
    }
}

