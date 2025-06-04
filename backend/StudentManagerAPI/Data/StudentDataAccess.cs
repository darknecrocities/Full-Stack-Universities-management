using System.Data;
using System.Data.SqlClient;
using StudentManagerAPI.Models;

namespace StudentManagerAPI.Data
{
    public class StudentDataAccess
    {
        private readonly string connectionString;

        public StudentDataAccess(IConfiguration config)
        {
            connectionString = config.GetConnectionString("DefaultConnection");
        }

        public List<Student> GetAll()
        {
            List<Student> students = new();
            using SqlConnection conn = new(connectionString);
            SqlCommand cmd = new("SELECT * FROM Students", conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                students.Add(new Student
                {
                    Id = (int)reader["Id"],
                    FullName = reader["FullName"].ToString(),
                    Email = reader["Email"].ToString()
                });
            }
            return students;
        }

        public void Add(Student student)
        {
            using SqlConnection conn = new(connectionString);
            SqlCommand cmd = new("INSERT INTO Students (FullName, Email) VALUES (@FullName, @Email)", conn);
            cmd.Parameters.AddWithValue("@FullName", student.FullName);
            cmd.Parameters.AddWithValue("@Email", student.Email);
            conn.Open();
            cmd.ExecuteNonQuery();
        }

        public void Delete(int id)
        {
            using SqlConnection conn = new(connectionString);
            SqlCommand cmd = new("DELETE FROM Students WHERE Id = @Id", conn);
            cmd.Parameters.AddWithValue("@Id", id);
            conn.Open();
            cmd.ExecuteNonQuery();
        }
    }
}
