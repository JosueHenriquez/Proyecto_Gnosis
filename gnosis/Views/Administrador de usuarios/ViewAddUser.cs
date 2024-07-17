using System;
using System.Windows.Forms;
using gnosis.Controllers.AdministradorUsuarios;

namespace gnosis.Views.Administrador_de_usuarios
{
    public partial class ViewAddUser : Form
    {
        //Constructor para inserción de datos
        //Cuando el formulario es invocado para una inserción,  este pedira UNICAMENTE la acción que se desea realizar.
        public ViewAddUser(int accion)
        {
            InitializeComponent();
            //Se invoca al controlador de la vista y se le envía el formulario y la acción
            ControllerAdduser objAddUser = new ControllerAdduser(this, accion);
        }

        //Constructor para actualización de datos
        //Cuando el formulario es invocado para una actualización,  este pedira la acción que se desea realizar y todos los datos referentes a la información de la persona.
        public ViewAddUser(int accion, int id, string firstName, string lastName, DateTime birthday, string dni, string address, string email, string phone, string username, string role)
        {
            InitializeComponent();
            //Se invoca al controlador de la vista y se le envía el formulario, la acción y los datos que recibió la vista, osea que la vista al recibir los datos de un controlador externo los reenvia a su propio controlador.
            ControllerAdduser objAddUser = new ControllerAdduser(this, accion, id, firstName, lastName, birthday, dni, address, email, phone, username, role);
        }
    }
}
