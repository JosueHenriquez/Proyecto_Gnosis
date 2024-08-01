using gnosis.Controllers.Helper;
using gnosis.Models.DTO;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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
                string query = "SELECT * FROM ViewLogin WHERE username = @username AND password = @password AND userStatus = @status";
                SqlCommand cmd = new SqlCommand(query, Command.Connection);
                cmd.Parameters.AddWithValue("username", Username);
                cmd.Parameters.AddWithValue("password", Password);
                cmd.Parameters.AddWithValue("status", true);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    SessionVar.Username = rd.GetString(0);
                    SessionVar.Password = rd.GetString(1);
                    SessionVar.RoleId = rd.GetInt32(3);
                    SessionVar.Access = rd.GetString(4);
                    SessionVar.FullName = rd.GetString(5);
                }
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

        public int ValidarPrimerUsoSistema()
        {
            try
            {
                Command.Connection = getConnection();
                string query = "SELECT COUNT(*) FROM ViewLogin";
                SqlCommand cmd = new SqlCommand(query, Command.Connection);
                int totalUsuarios = (int)cmd.ExecuteScalar();
                return totalUsuarios;
            }
            catch (SqlException sqlex)
            {
                MessageBox.Show(sqlex.Message);
                return -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return -1;
            }
            finally
            {
                getConnection().Close();
            }
        }
    }
}
