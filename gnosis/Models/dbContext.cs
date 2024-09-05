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
                //MessageBox.Show($"{DTOdbContext.Server}, {DTOdbContext.Database}, {DTOdbContext.User}, {DTOdbContext.Password}");
                SqlConnection conexion = new SqlConnection($"Server = {DTOdbContext.Server}; DataBase = {DTOdbContext.Database}; User Id = {DTOdbContext.User}; Password = {DTOdbContext.Password}");
                conexion.Open();
                return conexion;
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"{ex.Message} Código de error: EC-001 \nNo fue posible conectarse a la base de datos, favor verifique las credenciales o que tenga acceso al sistema.", "Error crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }        
}
