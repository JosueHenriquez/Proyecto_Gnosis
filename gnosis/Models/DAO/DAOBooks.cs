using gnosis.Models.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gnosis.Models.DAO
{
    internal class DAOBooks : DTOBooks
    {
        //Creando un objeto de tipo conexión
        SqlCommand command = new SqlCommand();

        public DataSet ObtenerProveedores()
        {
			try
			{
				command.Connection = getConnection();
				//Definir instrucción de lo que se quiere hacer
				string query = "SELECT providerID, providerName FROM tbProvider";
				//Creando un objeto de tipo comando donde recibe la instrucción y la conexión
				SqlCommand cmdSelect = new SqlCommand(query, command.Connection);
				cmdSelect.ExecuteNonQuery();
				SqlDataAdapter adp = new SqlDataAdapter(cmdSelect);
				DataSet ds = new DataSet();
				adp.Fill(ds, "tbProvider");
				return ds;
			}
			catch (Exception)
			{
				MessageBox.Show($"Error al obtener los proveedor, verifique su conexión a internet o que el acceso al servidor o base de datos esten activos", "Error de ejecución",MessageBoxButtons.OK, MessageBoxIcon.Error);
				return null;
			}
			finally 
			{
				command.Connection.Close();
			}
        }

        public DataSet ObtenerAutores()
        {
            try
            {
                command.Connection = getConnection();
                //Definir instrucción de lo que se quiere hacer
                string query = "SELECT authorId, authorName FROM tbAuthor";
                //Creando un objeto de tipo comando donde recibe la instrucción y la conexión
                SqlCommand cmdSelect = new SqlCommand(query, command.Connection);
                //Se ejecuta el comando cmdSelect con la instrucción y la conexión
                cmdSelect.ExecuteNonQuery();
                //Se crea un objeto de tipo SqlDataAdapter para facilitar el llenado del dataset
                SqlDataAdapter adp = new SqlDataAdapter(cmdSelect);
                //Se crea un dataset que contendrá los datos encontrados
                DataSet ds = new DataSet();
                //rellenamos el dataset con el objeto SqlDataAdapter
                adp.Fill(ds, "tbAuthor");
                //Se retorna el dataset
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message} Error al obtener los autores, verifique su conexión a internet o que el acceso al servidor o base de datos esten activos", "Error de ejecución", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                command.Connection.Close();
            }
        }

        public DataSet ObtenerAlmacenamiento()
        {
            try
            {
                command.Connection = getConnection();
                //Definir instrucción de lo que se quiere hacer
                string query = "SELECT storageId, storagename FROM ViewStorage";
                //Creando un objeto de tipo comando donde recibe la instrucción y la conexión
                SqlCommand cmdSelect = new SqlCommand(query, command.Connection);
                //Se ejecuta el comando cmdSelect con la instrucción y la conexión
                cmdSelect.ExecuteNonQuery();
                //Se crea un objeto de tipo SqlDataAdapter para facilitar el llenado del dataset
                SqlDataAdapter adp = new SqlDataAdapter(cmdSelect);
                //Se crea un dataset que contendrá los datos encontrados
                DataSet ds = new DataSet();
                //rellenamos el dataset con el objeto SqlDataAdapter
                adp.Fill(ds, "ViewStorage");
                //Se retorna el dataset
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message} Error al obtener los almacenamientos, verifique su conexión a internet o que el acceso al servidor o base de datos esten activos", "Error de ejecución", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                command.Connection.Close();
            }
        }

        public DataSet ObtenerCategorias()
        {
            try
            {
                command.Connection = getConnection();
                //Definir instrucción de lo que se quiere hacer
                string query = "SELECT categoryId, categoryName FROM tbCategory";
                //Creando un objeto de tipo comando donde recibe la instrucción y la conexión
                SqlCommand cmdSelect = new SqlCommand(query, command.Connection);
                //Se ejecuta el comando cmdSelect con la instrucción y la conexión
                cmdSelect.ExecuteNonQuery();
                //Se crea un objeto de tipo SqlDataAdapter para facilitar el llenado del dataset
                SqlDataAdapter adp = new SqlDataAdapter(cmdSelect);
                //Se crea un dataset que contendrá los datos encontrados
                DataSet ds = new DataSet();
                //rellenamos el dataset con el objeto SqlDataAdapter
                adp.Fill(ds, "tbCategory");
                //Se retorna el dataset
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message} Error al obtener las categorias, verifique su conexión a internet o que el acceso al servidor o base de datos esten activos", "Error de ejecución", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                command.Connection.Close();
            }
        }

        public int RegistrarLibros()
        {
            try
            {
                //Establecemos una conexión
                command.Connection = getConnection();
                //Definir que acción se desea realizar
                string queryInsert = "INSERT INTO tbBook VALUES (@param1, @param2, @param3, @param4, @param5, @param6, @param7)";
                SqlCommand cmdInsert = new SqlCommand(queryInsert, command.Connection);
                cmdInsert.Parameters.AddWithValue("param1", NombreLibro);
                cmdInsert.Parameters.AddWithValue("param2", Stock);
                cmdInsert.Parameters.AddWithValue("param3", Disponibilidad);
                cmdInsert.Parameters.AddWithValue("param4", ISBN1);
                cmdInsert.Parameters.AddWithValue("param5", ProveedorId);
                cmdInsert.Parameters.AddWithValue("param6", AutorId);
                cmdInsert.Parameters.AddWithValue("param7", AlmacenamientoId);
                return cmdInsert.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message} No se pudo registrar la información de libro, verifique su conexión a internet o que los servicios esten activos","Error de inserción", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            finally
            {
                command.Connection.Close();
            }
        }

        public DataSet ObtenerLibros()
        {
            try
            {
                command.Connection = getConnection();
                //Definir instrucción de lo que se quiere hacer
                string query = "SELECT * FROM ViewStorageBook";
                //Creando un objeto de tipo comando donde recibe la instrucción y la conexión
                SqlCommand cmdSelect = new SqlCommand(query, command.Connection);
                //Se ejecuta el comando cmdSelect con la instrucción y la conexión
                cmdSelect.ExecuteNonQuery();
                //Se crea un objeto de tipo SqlDataAdapter para facilitar el llenado del dataset
                SqlDataAdapter adp = new SqlDataAdapter(cmdSelect);
                //Se crea un dataset que contendrá los datos encontrados
                DataSet ds = new DataSet();
                //rellenamos el dataset con el objeto SqlDataAdapter
                adp.Fill(ds, "ViewStorageBook");
                //Se retorna el dataset
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message} Error al obtener la nomina de libros, verifique su conexión a internet o que el acceso al servidor o base de datos esten activos", "Error de ejecución", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                command.Connection.Close();
            }
        }

        public int EliminarLibro()
        {
            try
            {
                //Establecemos una conexión
                command.Connection = getConnection();
                //Definir que acción se desea realizar
                string queryDelete = "DELETE tbBook WHERE bookId = @param1";
                SqlCommand cmdDelete = new SqlCommand(queryDelete, command.Connection);
                cmdDelete.Parameters.AddWithValue("param1", IdLibro);
                return cmdDelete.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message} No se pudo eliminar la información de libro, verifique su conexión a internet o que los servicios esten activos", "Error de inserción", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            finally
            {
                command.Connection.Close();
            }
        }

        public int ActualizarLibro()
        {
            try
            {
                //Establecemos una conexión
                command.Connection = getConnection();
                //Definir que acción se desea realizar
                string queryUpdate = "UPDATE tbBook SET bookName = @param1, bookStock = @param2, bookAvailable = @param3, bookCode = @param4, providerId = @param5, authorId = @param6, storageSectionId = @param7 WHERE bookId = @param8";
                SqlCommand cmdUpdate = new SqlCommand(queryUpdate, command.Connection);
                cmdUpdate.Parameters.AddWithValue("param1", NombreLibro);
                cmdUpdate.Parameters.AddWithValue("param2", Stock);
                cmdUpdate.Parameters.AddWithValue("param3", Disponibilidad);
                cmdUpdate.Parameters.AddWithValue("param4", ISBN1);
                cmdUpdate.Parameters.AddWithValue("param5", ProveedorId);
                cmdUpdate.Parameters.AddWithValue("param6", AutorId);
                cmdUpdate.Parameters.AddWithValue("param7", AlmacenamientoId);
                cmdUpdate.Parameters.AddWithValue("param8", IdLibro);
                return cmdUpdate.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message} No se pudo actualizar la información de libro, verifique su conexión a internet o que los servicios esten activos", "Error de inserción", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            finally
            {
                command.Connection.Close();
            }
        }
    }
}
