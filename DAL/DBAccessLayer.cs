using Microsoft.Data.SqlClient;
using System.Data;

namespace IT481_Unit_2_Assignment.DAL
{
    class DBAccessLayer
    {
        //Methods
        public DataTable Get_Customers(string connString)
        {
            SqlCommand command = new SqlCommand();
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            command.Connection = conn;
            command.CommandText = "SELECT * FROM Customers";
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();

            return dt;
        }
        public void Save_Customers(DataTable dt, string connString)
        {
            SqlCommand command = new SqlCommand();
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            command.Connection = conn;
            command.CommandText = "SELECT * FROM Customers";

            SqlDataAdapter da = new SqlDataAdapter(command);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);

            da.UpdateCommand = cb.GetUpdateCommand();
            da.Update(dt);
        }
    }
}
