using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentExercisesMVC.Models
{
    public class Student : Person
    {
        public List<Exercise> StudentExs { get; set; } = new List<Exercise>();

        public Exercise GetExerciseById(int id)
        {
            return StudentExs[id];
        }
    }
}
