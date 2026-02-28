using System.Data;
using System.Data.SqlClient;

namespace Student_Management_System
{
    public class CourseClass
    {
        DBConnect db = new DBConnect();

        // Kurs Ekleme
        public bool insertCourse(string cName, string cCode, string tName)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Courses (CourseName, CourseCode) VALUES (@cn, @cc)", db.GetConnection());
            cmd.Parameters.Add("@cn", SqlDbType.NVarChar).Value = cName;
            cmd.Parameters.Add("@cc", SqlDbType.NVarChar).Value = cCode;

            db.Open();
            try { return cmd.ExecuteNonQuery() == 1; }
            catch { return false; }
            finally { db.Close(); }
        }


        public DataTable getCourse()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Courses", db.GetConnection());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);
            return table;
        }


        public bool updateCourse(int id, string cName, string cCode, string tName)
        {
            SqlCommand cmd = new SqlCommand("UPDATE Courses SET CourseName=@cn, CourseCode=@cc WHERE CourseId=@id", db.GetConnection());
            cmd.Parameters.Add("@cn", SqlDbType.NVarChar).Value = cName;
            cmd.Parameters.Add("@cc", SqlDbType.NVarChar).Value = cCode;
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;

            db.Open();
            try { return cmd.ExecuteNonQuery() == 1; }
            catch { return false; }
            finally { db.Close(); }
        }

  
        public bool deleteCourse(int id)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM Courses WHERE CourseId=@id", db.GetConnection());
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            db.Open();
            try { return cmd.ExecuteNonQuery() == 1; }
            catch { return false; }
            finally { db.Close(); }
        }


        public DataTable searchCourse(string searchdata)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Courses WHERE CourseCode LIKE '%" + searchdata + "%'", db.GetConnection());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);
            return table;
        }
    }
}