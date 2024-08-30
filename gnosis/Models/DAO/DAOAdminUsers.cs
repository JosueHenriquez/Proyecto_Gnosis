using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gnosis.Models.DTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Net;
using System.Xml.Linq;
using System.Windows.Forms;
using gnosis.Controllers.Helper;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace gnosis.Models.DAO
{
    class DAOAdminUsers : DTOAdminUsers
    {
        readonly SqlCommand Command = new SqlCommand();
        public DataSet LlenarCombo()
        {
            try
            {
                //Se crea una conexión para garantizar que efectivamente haya conexión a la base.
                Command.Connection = getConnection();
                //**
                //Se crea el query que indica la acción que el sistema desea realizar con la base de datos
                //En caso sea una consulta parametrizada se deberá respetar la sintaxis sobre como colocar parametros en la instrucción sql (REVISAR LOS DEMÁS MANTENIMIENTOS PARA VER COMO SE CREAN PARAMETROS Y SE LES DA VALORES).
                string query = "SELECT * FROM tbRole";
                //Se crea un comando de tipo sql al cual se le pasa el query y la conexión, esto para que el sistema sepa que hacer y donde hacerlo.
                SqlCommand cmd = new SqlCommand(query, Command.Connection);
                //ExecuteNonQuery indicará cuantos filas fueron afectadas, es decir, cuantas filas de datos se ingresaron o encontraron, por lo general cuando es una consulta su valor puede ser 1 o mayor a 1.
                cmd.ExecuteNonQuery();
                //Se crea un objeto SqlDataAdapter para poder llenar el DataSet que posteriormente utilizaremos, además recibe el comando sql
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                //Se crea un DataSet que será el objeto de retorno del método
                DataSet ds = new DataSet();
                //Rellenamos el DataSet con los datos encontrados con el SqlDataAdapter, además, indicamos de donde provienen los datos
                adp.Fill(ds, "tbRole");
                //Retornamos el objeto DataSet
                return ds;
            }
            catch (Exception)
            {
                //Se retorna null si durate la ejecución del try ocurrió algún error
                return null;
            }finally 
            {
                //Independientemente se haga o no el proceso cerramos la conexión
                getConnection().Close();
            }
        }

        /// <summary>
        /// Registrar usuario corresponde al primer mantenimiento del CRUD
        /// Inserción de datos a la base de datos
        /// </summary>
        /// <returns></returns>
        public int RegistrarUsuario()
        {
            try
            {
                //Se crea una conexión para garantizar que efectivamente haya conexión a la base.
                Command.Connection = getConnection();
                //**
                //Se crea el query que indica la acción que el sistema desea realizar con la base de datos
                //el query posee parametros para evitar algún tipo de ataque como SQL Injection
                string query2 = "INSERT INTO tbUser VALUES (@username, @password, @userStatus, @userAttempts, @roleId, @session, @idBussines, @pin)";
                //Se crea un comando de tipo sql al cual se le pasa el query y la conexión, esto para que el sistema sepa que hacer y donde hacerlo.
                SqlCommand cmd2 = new SqlCommand(query2, Command.Connection);
                //Se le da un valor a los parametros contenidos en el query, es importante mencionar que lo que esta entre comillas es el nombre del parametro y lo que esta después de la coma es el valor que se le asignará al parametro, estos valores vienen del DTO respectivo.
                cmd2.Parameters.AddWithValue("username", User);
                cmd2.Parameters.AddWithValue("password", Password);
                cmd2.Parameters.AddWithValue("userStatus", UserStatus);
                cmd2.Parameters.AddWithValue("userAttempts", UserAttempts);
                cmd2.Parameters.AddWithValue("roleId", Role);
                cmd2.Parameters.AddWithValue("session", 0);
                cmd2.Parameters.AddWithValue("IdBussines", 1);
                cmd2.Parameters.AddWithValue("pin", "null");
                //Se ejecuta el comando ya con todos los valores de sus parametros.
                //ExecuteNonQuery indicará cuantos filas fueron afectadas, es decir, cuantas filas de datos se ingresaron, por lo general devolvera 1 porque se hace una inserción a la vez.
                int respuesta = cmd2.ExecuteNonQuery();
                //Se evalúa el valor de la variable respuesta que contiene el numero de filas afectadas
                if (respuesta == 1)
                {
                    //Si el valor de respuesta es 1, se procede a la inserción de los datos de la persona, como se puede observar en el diagrama de base de datos, primero es el usuario y despues la persona.
                    string query = "INSERT INTO tbPerson (personFirstname, personLastname, personBirth, personDni, personAddress, personEmail, personPhone, username) VALUES (@param1, @param2, @param3, @param4, @param5, @param6, @param7, @param8)";
                    //Se crea un comando de tipo sql al cual se le pasa el query y la conexión, esto para que el sistema sepa que hacer y donde hacerlo.
                    SqlCommand cmd = new SqlCommand(query, Command.Connection);
                    //Se le da un valor a los parametros contenidos en el query, es importante mencionar que lo que esta entre comillas es el nombre del parametro y lo que esta después de la coma es el valor que se le asignará al parametro, estos valores vienen del DTO
                    cmd.Parameters.AddWithValue("param1", FirstName);
                    cmd.Parameters.AddWithValue("param2", LastName);
                    cmd.Parameters.AddWithValue("param3", Birthday);
                    cmd.Parameters.AddWithValue("param4", Dni);
                    cmd.Parameters.AddWithValue("param5", PersonAddress);
                    cmd.Parameters.AddWithValue("param6", PersonEmail);
                    cmd.Parameters.AddWithValue("param7", PersonPhone);
                    cmd.Parameters.AddWithValue("param8", User);
                    //cmd.Parameters.AddWithValue("param9", "null");
                    //Se ejecuta el comando ya con todos los valores de sus parametros.
                    //ExecuteNonQuery indicará cuantos filas fueron afectadas, es decir, cuantas filas de datos se ingresaron, por lo general devolvera 1 porque se hace una inserción a la vez.
                    respuesta = cmd.ExecuteNonQuery();
                    //Se retorna el valor de respuesta, que si su valor es 1 indica que los valores fueron ingresados.
                    return respuesta;
                }
                else
                {
                    RollBack();
                    return 0;
                }
            }
            catch (Exception)
            {
                RollBack();
                //Se retorna -1 en caso que en el segmento del try haya ocurrido algún error.
                return -1;
            }
            finally
            {
                //Independientemente se haga o no el proceso cerramos la conexión
                Command.Connection.Close();
            }
        }

        public void RollBack()
        {
            //Eliminar el usuario ingresado
            string query = "DELETE FROM tbUser WHERE username = @username";
            SqlCommand cmddel = new SqlCommand(query, Command.Connection);
            cmddel.Parameters.AddWithValue("username", User);
            int retorno = cmddel.ExecuteNonQuery();
        }
        
        /// <summary>
        /// Obtener personas corresponde al segundo mantenimiento del CRUD
        /// Consultar datos a la base de datos
        /// </summary>
        /// <returns></returns>
        public DataSet ObtenerPersonas()
        {
            try
            {
                //Accedemos a la conexión que ya se tiene
                Command.Connection = getConnection();
                //Instrucción que se hará hacia la base de datos
                string query = "SELECT * FROM viewPerson WHERE userStatus = @valor";
                //Comando sql en el cual se pasa la instrucción y la conexión
                SqlCommand cmd = new SqlCommand(query, Command.Connection);
                //Asignando valor al parametro
                cmd.Parameters.AddWithValue("valor", true);
                //Se ejecuta el comando y con ExecuteNonQuery se verifica su retorno
                //ExecuteNonQuery devuelve un valor entero.
                cmd.ExecuteNonQuery();
                //Se utiliza un adaptador sql para rellenar el dataset
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                //Se crea un objeto Dataset que es donde se devolverán los resultados
                DataSet ds = new DataSet();
                //Rellenamos con el Adaptador el DataSet diciendole de que tabla provienen los datos
                adp.Fill(ds, "viewPerson");
                //Devolvemos el Dataset
                return ds;
            }
            catch (Exception)
            {
                //Retornamos null si existiera algún error durante la ejecución
                return null;
            }
            finally
            {
                //Independientemente se haga o no el proceso cerramos la conexión
                getConnection().Close();
            }
        }

        public DataSet ObtenerPersonasInactivas()
        {
            try
            {
                //Accedemos a la conexión que ya se tiene
                Command.Connection = getConnection();
                //Instrucción que se hará hacia la base de datos
                string query = "SELECT * FROM viewPerson WHERE userStatus = @valor";
                //Comando sql en el cual se pasa la instrucción y la conexión
                SqlCommand cmd = new SqlCommand(query, Command.Connection);
                //Asignando valor al parametro
                cmd.Parameters.AddWithValue("valor", false);
                //Se ejecuta el comando y con ExecuteNonQuery se verifica su retorno
                //ExecuteNonQuery devuelve un valor entero.
                cmd.ExecuteNonQuery();
                //Se utiliza un adaptador sql para rellenar el dataset
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                //Se crea un objeto Dataset que es donde se devolverán los resultados
                DataSet ds = new DataSet();
                //Rellenamos con el Adaptador el DataSet diciendole de que tabla provienen los datos
                adp.Fill(ds, "viewPerson");
                //Devolvemos el Dataset
                return ds;
            }
            catch (Exception)
            {
                //Retornamos null si existiera algún error durante la ejecución
                return null;
            }
            finally
            {
                //Independientemente se haga o no el proceso cerramos la conexión
                getConnection().Close();
            }
        }

        /// <summary>
        /// Actualizar usuario corresponde al tercer mantenimiento del CRUD
        /// Actualización de datos
        /// </summary>
        /// <returns></returns>
        public int ActualizarUsuario()
        {
            try
            {
                //Se crea una conexión para garantizar que efectivamente haya conexión a la base.
                Command.Connection = getConnection();
                //**
                //Se crea el query que indica la acción que el sistema desea realizar con la base de datos
                //el query posee parametros para evitar algún tipo de ataque como SQL Injection
                string query = "UPDATE tbPerson SET " +
                                "personFirstname = @param1, " +
                                "personLastname = @param2, " +
                                "personBirth = @param3, " +
                                "personDni = @param4," +
                                "personAddress = @param5," +
                                "personEmail = @param6, " +
                                "personPhone = @param7 " +
                                "WHERE personId = @param8";
                //Se crea un comando de tipo sql al cual se le pasa el query y la conexión, esto para que el sistema sepa que hacer y donde hacerlo.
                SqlCommand cmd = new SqlCommand(query, Command.Connection);
                //Se le da un valor a los parametros contenidos en el query, es importante mencionar que lo que esta entre comillas es el nombre del parametro y lo que esta después de la coma es el valor que se le asignará al parametro, estos valores vienen del DTO respectivo.
                cmd.Parameters.AddWithValue("param1", FirstName);
                cmd.Parameters.AddWithValue("param2", LastName);
                cmd.Parameters.AddWithValue("param3", Birthday);
                cmd.Parameters.AddWithValue("param4", Dni);
                cmd.Parameters.AddWithValue("param5", PersonAddress);
                cmd.Parameters.AddWithValue("param6", PersonEmail);
                cmd.Parameters.AddWithValue("param7", PersonPhone);
                cmd.Parameters.AddWithValue("param8", PersonId);
                //Se ejecuta el comando ya con todos los valores de sus parametros.
                //ExecuteNonQuery indicará cuantos filas fueron afectadas, es decir, cuantas filas de datos se ingresaron, por lo general devolvera 1 porque se hace una actualización a la vez.
                int respuesta = cmd.ExecuteNonQuery();
                //Se evalúa el valor de la variable respuesta que contiene el numero de filas afectadas
                if (respuesta == 1)
                {
                    //Si el valor de respuesta es 1 se procede a realizar la actualización del usuario
                    //**
                    //Se crea el query que indica la acción que el sistema desea realizar con la base de datos
                    //el query posee parametros para evitar algún tipo de ataque como SQL Injection
                    string query2 = "UPDATE tbUser SET " +
                                    "roleId = @param9 " +
                                    "WHERE username = @param10";
                    //Se crea un comando de tipo sql al cual se le pasa el query y la conexión, esto para que el sistema sepa que hacer y donde hacerlo.
                    SqlCommand cmd2 = new SqlCommand(query2, getConnection());
                    //Se le da un valor a los parametros contenidos en el query, es importante mencionar que lo que esta entre comillas es el nombre del parametro y lo que esta después de la coma es el valor que se le asignará al parametro, estos valores vienen del DTO respectivo.
                    cmd2.Parameters.AddWithValue("param9", Role);
                    cmd2.Parameters.AddWithValue("param10", User);
                    //Se ejecuta el comando ya con todos los valores de sus parametros.
                    //ExecuteNonQuery indicará cuantos filas fueron afectadas, es decir, cuantas filas de datos se ingresaron, por lo general devolvera 1 porque se hace una inserción a la vez.
                    respuesta = cmd2.ExecuteNonQuery();
                    respuesta = 2;
                }
                return respuesta;
            }
            catch (Exception)
            {
                //Se retorna -1 en caso que en el segmento del try haya ocurrido algún error.
                return -1;
            }
            finally
            {
                //Independientemente se haga o no el proceso cerramos la conexión
                getConnection().Close();
            }
        }

        /// <summary>
        /// Eliminar usuario corresponde al cuarto mantenimiento del CRUD
        /// Eliminación de datos de la base de datos
        /// </summary>
        /// <returns></returns>
        public int EliminarUsuario()
        {
            try
            {
                //Se crea una conexión para garantizar que efectivamente haya conexión a la base.
                Command.Connection = getConnection();
                //**
                //Se crea el query que indica la acción que el sistema desea realizar con la base de datos
                //el query posee parametros para evitar algún tipo de ataque como SQL Injection
                string query = "DELETE tbPerson WHERE personId = @param1";
                //Se crea un comando de tipo sql al cual se le pasa el query y la conexión, esto para que el sistema sepa que hacer y donde hacerlo.
                SqlCommand cmd = new SqlCommand(query, Command.Connection);
                //Se le da un valor a los parametros contenidos en el query, es importante mencionar que lo que esta entre comillas es el nombre del parametro y lo que esta después de la coma es el valor que se le asignará al parametro, estos valores vienen del DTO respectivo.
                cmd.Parameters.AddWithValue("param1", PersonId);
                //Se ejecuta el comando ya con todos los valores de sus parametros.
                //ExecuteNonQuery indicará cuantos filas fueron afectadas, es decir, cuantas filas de datos se ingresaron, por lo general devolvera 1 porque se hace una eliminación a la vez.
                int respuesta = cmd.ExecuteNonQuery();
                //Si la ejecución del comando no ha generado errores se procederá a retornar el valor de la variable respuesta que por lo general almacenará un 1 ya que solo se hace una acción a la vez.
                if (respuesta == 1)
                {
                    string queryupdate = "UPDATE tbUser SET userStatus = @status WHERE username = @username";
                    SqlCommand cmdupdate = new SqlCommand(queryupdate, Command.Connection);
                    cmdupdate.Parameters.AddWithValue("status", false);
                    cmdupdate.Parameters.AddWithValue("username", User);
                    respuesta += cmdupdate.ExecuteNonQuery();
                }
                return respuesta;
            }
            catch (Exception)
            {
                //Se retorna -1 en caso que en el segmento del try haya ocurrido algún error.
                return -1;
            }
            finally
            {
                //Independientemente se haga o no el proceso cerramos la conexión
                getConnection().Close();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public DataSet BuscarPersonas(string valor)
        {
            try
            {
                //Accedemos a la conexión que ya se tiene
                Command.Connection = getConnection();
                //Instrucción que se hará hacia la base de datos
                string query = $"SELECT * FROM viewPerson WHERE Nombres LIKE '%{valor}%' OR Documento LIKE '%{valor}%' OR Usuario LIKE '%{valor}%' OR [Rol de acceso] LIKE '%{valor}%'";
                //Comando sql en el cual se pasa la instrucción y la conexión
                SqlCommand cmd = new SqlCommand(query, Command.Connection);
                //Se ejecuta el comando y con ExecuteNonQuery se verifica su retorno
                //ExecuteNonQuery devuelve un valor entero.
                cmd.ExecuteNonQuery();
                //Se utiliza un adaptador sql para rellenar el dataset
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                //Se crea un objeto Dataset que es donde se devolverán los resultados
                DataSet ds = new DataSet();
                //Rellenamos con el Adaptador el DataSet diciendole de que tabla provienen los datos
                adp.Fill(ds, "viewPerson");
                //Devolvemos el Dataset
                return ds;
            }
            catch (Exception)
            {
                //Retornamos null si existiera algún error durante la ejecución
                return null;
            }
            finally
            {
                //Independientemente se haga o no el proceso cerramos la conexión
                getConnection().Close();
            }
        }

        public bool VerificarPINSeguridad()
        {
            try
            {
                Command.Connection = getConnection();
                string query = "SELECT * FROM tbUser WHERE username = @username AND pinRestartPassword = @pin AND userStatus = @status";
                SqlCommand cmd = new SqlCommand(query, Command.Connection);
                cmd.Parameters.AddWithValue("username", User);
                cmd.Parameters.AddWithValue("pin", Pin);
                cmd.Parameters.AddWithValue("status", true);
                SqlDataReader rd = cmd.ExecuteReader();
                return rd.HasRows;
            }
            catch (SqlException)
            {
                MessageBox.Show("No se pudo almacenar el PIN, vuelva a intentarlo. EC-005");
                return false;
            }
        }


        public bool RegistrarPIN()
        {
            try
            {
                Command.Connection = getConnection();
                string queryupdate = "UPDATE tbUser SET pinRestartPassword = @valor1 WHERE username = @username";
                SqlCommand cmdupdate = new SqlCommand(queryupdate, Command.Connection);
                cmdupdate.Parameters.AddWithValue("valor1", Pin);
                cmdupdate.Parameters.AddWithValue("username", User);
                return cmdupdate.ExecuteNonQuery() > 0 ? true : false;
            }
            catch (SqlException)
            {
                return false;
            }
        }

        public bool RestablecerContrasena()
        {
            try
            {
                Command.Connection = getConnection();
                string queryupdate = "UPDATE tbUser SET password = @valor1, pinRestartPassword = @valor2 WHERE username = @username";
                SqlCommand cmdupdate = new SqlCommand(queryupdate, Command.Connection);
                cmdupdate.Parameters.AddWithValue("valor1", Password);
                cmdupdate.Parameters.AddWithValue("valor2", string.Empty);
                cmdupdate.Parameters.AddWithValue("username", User);
                return cmdupdate.ExecuteNonQuery() > 0 ? true : false;
            }
            catch (SqlException)
            {
                return false;
            }
        }
    }
}
