using gnosis.Models.DTO;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace gnosis.Models.DAO
{
    public class DAOLogin : DTOLogin
    {
        SqlCommand Command = new SqlCommand();
        public bool ValidarLogin()
        {
            try
            {
                Command.Connection = getConnection();
                string query = "SELECT * FROM tbUser WHERE username = @username AND password = @password AND userStatus = @status";
                SqlCommand cmd = new SqlCommand(query, Command.Connection);
                cmd.Parameters.AddWithValue("username", Username);
                cmd.Parameters.AddWithValue("password", Password);
                cmd.Parameters.AddWithValue("status", true);
                SqlDataReader rd = cmd.ExecuteReader();
                return rd.HasRows;
            }
            catch (SqlException sqlex)
            {
                MessageBox.Show(sqlex.Message);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                getConnection().Close();
            }
        }
    }
}
