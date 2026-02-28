using System;
using System.Data;
using System.Data.SqlClient;

namespace Student_Management_System
{
    public class StudentClass
    {
        DBConnect db = new DBConnect();

        // --- ÖĞRENCİ EKLEME ---
        public bool InsertStudent(string firstName, string lastName, string phone, DateTime birthDate, string email, string gender)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Students (FirstName, LastName, StudentNumber, BirthDate, Email, Gender) VALUES (@fn, @ln, @sn, @bd, @em, @gn)", db.GetConnection());
            cmd.Parameters.Add("@fn", SqlDbType.NVarChar).Value = firstName;
            cmd.Parameters.Add("@ln", SqlDbType.NVarChar).Value = lastName;
            cmd.Parameters.Add("@sn", SqlDbType.NVarChar).Value = phone;
            cmd.Parameters.Add("@bd", SqlDbType.Date).Value = birthDate;
            cmd.Parameters.Add("@em", SqlDbType.NVarChar).Value = email;
            cmd.Parameters.Add("@gn", SqlDbType.NVarChar).Value = gender;

            db.Open();
            try { return cmd.ExecuteNonQuery() == 1; }
            catch { return false; }
            finally { db.Close(); }
        }

        // --- LİSTELEME ---
        public DataTable GetStudentList()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Students", db.GetConnection());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);
            return table;
        }

        // --- GÜNCELLEME ---
        public bool UpdateStudent(int id, string firstName, string lastName, string phone, DateTime birthDate, string email, string gender)
        {
            SqlCommand cmd = new SqlCommand("UPDATE Students SET FirstName=@fn, LastName=@ln, StudentNumber=@sn, BirthDate=@bd, Email=@em, Gender=@gn WHERE StudentId=@id", db.GetConnection());
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@fn", SqlDbType.NVarChar).Value = firstName;
            cmd.Parameters.Add("@ln", SqlDbType.NVarChar).Value = lastName;
            cmd.Parameters.Add("@sn", SqlDbType.NVarChar).Value = phone;
            cmd.Parameters.Add("@bd", SqlDbType.Date).Value = birthDate;
            cmd.Parameters.Add("@em", SqlDbType.NVarChar).Value = email;
            cmd.Parameters.Add("@gn", SqlDbType.NVarChar).Value = gender;

            db.Open();
            try { return cmd.ExecuteNonQuery() == 1; }
            catch { return false; }
            finally { db.Close(); }
        }

        // --- SİLME ---
        public bool DeleteStudent(int id)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM Students WHERE StudentId=@id", db.GetConnection());
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;

            db.Open();
            try { return cmd.ExecuteNonQuery() == 1; }
            catch { return false; }
            finally { db.Close(); }
        }

        // --- ARAMA ---
        public DataTable SearchStudent(string searchData)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Students WHERE CONCAT(FirstName, LastName, StudentNumber) LIKE @search", db.GetConnection());
            cmd.Parameters.Add("@search", SqlDbType.NVarChar).Value = "%" + searchData + "%";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);
            return table;
        }

        // --- DASHBOARD (İSTATİSTİK) FONKSİYONLARI ---


        public string GetTotalStudentsCount()
        {
            return ExecuteCountQuery("SELECT COUNT(*) FROM Students");
        }

        public string GetMaleStudentsCount()
        {
            return ExecuteCountQuery("SELECT COUNT(*) FROM Students WHERE Gender='Male'");
        }

        public string GetFemaleStudentsCount()
        {
            return ExecuteCountQuery("SELECT COUNT(*) FROM Students WHERE Gender='Female'");
        }

        // Yardımcı fonksiyon (Tekrar tekrar kod yazmamak için)
        private string ExecuteCountQuery(string query)
        {
            SqlCommand cmd = new SqlCommand(query, db.GetConnection());
            db.Open();
            // ExecuteScalar tek bir değer (sayı) döndürür
            string count = cmd.ExecuteScalar().ToString();
            db.Close();
            return count;
        }
    }
}