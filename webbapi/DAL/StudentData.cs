namespace DAL;
using Model;
using System.Data;
using MySql.Data.MySqlClient;

public class StudentData
{
    public static string conString = @"server=localhost; port=3306; user=root; password=welcome@123; database=college";

    public static List<Student> GetAllStudents()
    {
        List<Student> allNotes = new List<Student>();
        MySqlConnection con = new MySqlConnection(conString);

        try{
            string querry = "select * from student ";
            DataSet ds = new DataSet();
            MySqlCommand cmd = new MySqlCommand(querry,con);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(ds);

            DataTable dt = ds.Tables[0];
            DataRowCollection rows = dt.Rows;
            foreach (DataRow row in rows)
            {
               Student student = new Student
               {
                id=int.Parse(row["id"].ToString()),
                name=row["name"].ToString(),
                course=row["course"].ToString()
               };
               allNotes.Add(student);
            }
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
        return allNotes;
    }

    public static void InsertStudent(Student student)
    {
        MySqlConnection con = new MySqlConnection(conString);

        try{
            con.Open();
            string query = $"insert into student(name,course) values ('{student.name}','{student.course}')";
            MySqlCommand command = new MySqlCommand(query,con);
            command.ExecuteNonQuery();
            con.Close();

        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public static void DeleteStudentById(int id)
    {
        MySqlConnection con = new MySqlConnection(conString);

        try
        {
            con.Open();
            string query = "delete from student where id =" +id;
            MySqlCommand command = new MySqlCommand(query, con);
            command.ExecuteNonQuery();
            con.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            con.Close();
        }
    }
}