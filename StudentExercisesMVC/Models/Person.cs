﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentExercisesMVC.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SlackHandle { get; set; }

        public int CohortId { get; set; }

        //public string CohortName { get; set; }

        public Cohort CurrentCohort { get; set; }
    }
}

