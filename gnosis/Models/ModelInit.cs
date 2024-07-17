using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Windows.Forms;

namespace gnosis.Models
{
    internal class ModelInit : dbContext
    {
        SqlCommand Command = new SqlCommand();
        public bool ValidarInicio()
        {
            try
            {
                Command.Connection = getConnection();
                string query = "SELECT * FROM tbUser";
                SqlCommand cmd = new SqlCommand(query, Command.Connection);
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
