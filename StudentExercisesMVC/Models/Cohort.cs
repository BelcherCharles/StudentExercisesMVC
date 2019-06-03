using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentExercisesMVC.Models
{
    public class Cohort
    {
        public int CohortId { get; set; }
        public string CohortName { get; set; }
        public List<Student> Students = new List<Student>();
        public List<Instructor> Instructors = new List<Instructor>();
    }
}
