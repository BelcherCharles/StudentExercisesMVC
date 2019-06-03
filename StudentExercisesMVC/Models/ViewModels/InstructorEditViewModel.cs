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
    public class InstructorEditViewModel
    {
        public List<SelectListItem> Cohorts { get; set; }
        public Instructor Instructor { get; set; }

        //connection to the database
        protected string _connectionString;

        protected SqlConnection Connection
        {
            get
            {
                return new SqlConnection(_connectionString);
            }
        }
        public InstructorEditViewModel() { }

        public InstructorEditViewModel(string connectionString)
        {
            _connectionString = connectionString;
     

            // When we create a new instance of this view model, we'll call the internal methods to get all the cohorts from the database
            // Then we'll map over them and convert the list of cohorts to a list of select list items

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
