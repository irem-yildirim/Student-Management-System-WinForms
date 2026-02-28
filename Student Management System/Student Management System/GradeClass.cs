using System;
using System.Data;
using System.Data.SqlClient;

namespace Student_Management_System
{
    public class GradeClass
    {
        DBConnect db = new DBConnect();

        // Not Ekle
        public bool insertGrade(int sid, int cid, int score, string desc)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Grades (StudentId, CourseId, Score, Description) VALUES (@sid, @cid, @sc, @desc)", db.GetConnection());
            cmd.Parameters.Add("@sid", SqlDbType.Int).Value = sid;
            cmd.Parameters.Add("@cid", SqlDbType.Int).Value = cid;
            cmd.Parameters.Add("@sc", SqlDbType.Int).Value = score;
            cmd.Parameters.Add("@desc", SqlDbType.NVarChar).Value = (object)desc ?? DBNull.Value; // Boş gelirse hata vermesin

            db.Open();
            try { return cmd.ExecuteNonQuery() == 1; }
            catch { return false; }
            finally { db.Close(); }
        }

        // Listele
        public DataTable getList()
        {
            SqlCommand cmd = new SqlCommand(@"SELECT 
                                                g.GradeId, 
                                                s.FirstName, 
                                                s.LastName, 
                                                c.CourseName, 
                                                g.Score,
                                                g.Description
                                              FROM Grades g
                                              INNER JOIN Students s ON g.StudentId = s.StudentId
                                              INNER JOIN Courses c ON g.CourseId = c.CourseId", db.GetConnection());

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);
            return table;
        }

        // Sil
        public bool deleteGrade(int id)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM Grades WHERE GradeId=@id", db.GetConnection());
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            db.Open();
            try { return cmd.ExecuteNonQuery() == 1; }
            catch { return false; }
            finally { db.Close(); }
        }

        public bool updateGrade(int id, int sid, int cid, int score, string desc)
        {
            SqlCommand cmd = new SqlCommand("UPDATE Grades SET StudentId=@sid, CourseId=@cid, Score=@sc, Description=@desc WHERE GradeId=@id", db.GetConnection());
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@sid", SqlDbType.Int).Value = sid;
            cmd.Parameters.Add("@cid", SqlDbType.Int).Value = cid;
            cmd.Parameters.Add("@sc", SqlDbType.Int).Value = score;
            cmd.Parameters.Add("@desc", SqlDbType.NVarChar).Value = (object)desc ?? DBNull.Value;

            db.Open();
            try { return cmd.ExecuteNonQuery() == 1; }
            catch { return false; }
            finally { db.Close(); }
        }
    }
}