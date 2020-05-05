using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SitemaNotas.Model;
using SitemaNotas.Vista;

namespace SitemaNotas
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            using (sistemaNotasEntities db = new sistemaNotasEntities())
            {
                var lista = from usuario in db.Estudiantes
                            where usuario.UserName == txtUsuarioL.Text &&
                            usuario.Contrasena == txtContrasenaL.Text
                            select usuario;
                if (lista.Count() > 0)


                {
                    MessageBox.Show("Bienvenido/a " + txtUsuarioL.Text);

                    frmMenu Men = new frmMenu();
                    Men.Show();
                    Hide();

                }

                else
                {
                    MessageBox.Show("Usuario o Contraseña invalidos, favor de verificar");
                }

            }
        }
    }
}
