using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;
using StudentExercisesMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace StudentExercisesMVC.Models.ViewModels
{
    public class StudentEditViewModel
    {
        public List<SelectListItem> allExercises { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> Cohorts { get; set; }
        public Student Student { get; set; }
        public List<int> AssignedExercises { get; set; }

        //connection to the database
        protected string _connectionString;

        protected SqlConnection Connection
        {
            get
            {
                return new SqlConnection(_connectionString);
            }
        }
        public StudentEditViewModel() { }

        public StudentEditViewModel(string connectionString)
        {
            _connectionString = connectionString;

            //student = StudentRepository.GetOneStudent(studentId);

            // Get the exercises that are currently assigned to this student
            // The student model already has a list for this! 
            Student.StudentExs = GetAssignedExercisesByStudent(studentId);

            allExercises = ExerciseRepository.GetAllExercises()
               .Select(singleExercise => new SelectListItem()
               {
                   Text = singleExercise.Name,
                   Value = singleExercise.id.ToString(),
                   Selected = Student.StudentExs.Find(assignedExercise => assignedExercise.id == singleExercise.id) != null

               })
               .ToList();

            //Query the database to get all cohorts
            Cohorts = GetAllCohorts()
                .Select(cohort => new SelectListItem()
                {
                    Text = cohort.CohortName,
                    Value = cohort.CohortId.ToString()

                })
                .ToList();

            // Add an option with instructions for how to use the dropdown
            Cohorts.Insert(0, new SelectListItem
            {
                Text = "Choose a cohort",
                Value = "0"
            });

        }

        // Internal method -- connects to DB, gets all cohorts, returns list of cohorts
        protected List<Cohort> GetAllCohorts()
        {
            using (SqlConnection conn = Connection)
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT CohortId, CohortName FROM Cohort";
                    SqlDataReader reader = cmd.ExecuteReader();

                    List<Cohort> cohorts = new List<Cohort>();
                    while (reader.Read())
                    {
                        cohorts.Add(new Cohort
                        {
                            CohortId = reader.GetInt32(reader.GetOrdinal("CohortId")),
                            CohortName = reader.GetString(reader.GetOrdinal("CohortName")),
                        });
                    }

                    reader.Close();

                    return cohorts;
                }
            }
        }
    }
}
