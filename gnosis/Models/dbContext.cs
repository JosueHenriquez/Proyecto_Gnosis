using gnosis.Models.DTO;
using System.Data.SqlClient;
using System.Drawing.Text;
using System.Windows.Forms;

namespace gnosis.Models
{
    public class dbContext
    {
        public static SqlConnection getConnection()
        {
            try
            {
                string server = "sql8020.site4now.net";
                string database = "db_aac60e_gnosis";
                string userId = "db_aac60e_gnosis_admin";
                string Password = "Gnosis12345";
                SqlConnection conexion = new SqlConnection($"Server = {server}; DataBase = {database}; User Id = {userId}; Password = {Password}");
                conexion.Open();
                return conexion;
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"{ex.Message} Código de error: EC-001 \nNo fue posible conectarse a la base de datos, favor verifique las credenciales o que tenga acceso al sistema.","Error crítico",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }        
}
