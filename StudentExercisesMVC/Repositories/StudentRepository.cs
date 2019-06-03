using Microsoft.Extensions.Configuration;
using StudentExercisesMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace StudentExercisesMVC.Repositories
{
    public class StudentRepository
    {

        private static IConfiguration _config;

        public static void SetConfig(IConfiguration configuration)
        {
            _config = configuration;
        }

        public static SqlConnection Connection
        {
            get
            {
                return new SqlConnection(_config.GetConnectionString("DefaultConnection"));
            }
        }

        public static List<Student> GetStudents()
        {
            using (SqlConnection conn = Connection)
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"
                        SELECT
                            s.Id, s.firstName, s.lastName, s.slackHandle, s.cohortId,
                            c.Name AS 'Cohort Name'
                        FROM Student s
                        JOIN Cohort c ON s.CohortId = c.Id
                        ORDER BY s.lastName, s.firstName";
                    SqlDataReader reader = cmd.ExecuteReader();

                    List<Student> students = new List<Student>();
                    while (reader.Read())
                    {
                        Student student = new Student
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("Id")),
                            FirstName = reader.GetString(reader.GetOrdinal("FirstName")),
                            LastName = reader.GetString(reader.GetOrdinal("LastName")),
                            SlackHandle = reader.GetString(reader.GetOrdinal("SlackHandle")),
                            CohortId = reader.GetInt32(reader.GetOrdinal("CohortId")),
                            CurrentCohort = new Cohort
                            {
                                CohortName = reader.GetString(reader.GetOrdinal("Cohort Name"))
                            }
                        };

                        students.Add(student);
                    }

                    reader.Close();

                    return students;
                }
            }

        }

        public static Student GetOneStudent(int id)

    }
