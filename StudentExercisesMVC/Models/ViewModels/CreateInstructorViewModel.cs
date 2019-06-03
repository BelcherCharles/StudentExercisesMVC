﻿using Microsoft.AspNetCore.Mvc.Rendering;
using StudentExercisesMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace StudentExercisesMVC.Models.ViewModels
{
    public class CreateInstructorViewModel
    {
        // This is where our dropdown options will go! SelectListItem is a built in type for dropdown lists
        public List<SelectListItem> Cohorts { get; set; }

        // An individual student. When we render the form (i.e. make a GET request to Students/Create) this will be null. When we submit the form (i.e. make a POST request to Students/Create), this will hold the data from the form.
        public Instructor instructor { get; set; }

        // Connection to the database
        protected string _connectionString;

        protected SqlConnection Connection
        {
            get
            {
                return new SqlConnection(_connectionString);
            }
        }

        // Empty constructor so that we can create a new instance of this view model when we make our POST request (in which case it won't need a connection string)
        public CreateInstructorViewModel() { }

        // This is an example of method overloading! We have one constructor with no parameter and another constructor that's expecting a connection string. We can call either one!
        public CreateInstructorViewModel(string connectionString)
        {
            _connectionString = connectionString;

            // When we create a new instance of this view model, we'll call the internal methods to get all the cohorts from the database
            // Then we'll map over them and convert the list of cohorts to a list of select list items
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