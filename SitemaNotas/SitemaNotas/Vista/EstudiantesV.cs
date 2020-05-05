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

namespace SitemaNotas.Vista
{
    public partial class EstudiantesV : Form
    {
        public EstudiantesV()
        {
            InitializeComponent();
        }
        Estudiantes ES = new Estudiantes();
        void LimpiarDatos()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtUsuario.Text = "";
            txtContrasena.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            using (sistemaNotasEntities ConE = new sistemaNotasEntities())
            {
                ES.Nombre = txtNombre.Text;
                ES.Apellido = txtApellido.Text;
                ES.UserName = txtUsuario.Text;
                ES.Contrasena = txtContrasena.Text;
                ConE.Estudiantes.Add(ES);
                ConE.SaveChanges();
                
            }
            LimpiarDatos();

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            using (sistemaNotasEntities ConE = new sistemaNotasEntities())
            {
                String Id = dtvEstudiantes.CurrentRow.Cells[0].Value.ToString();
                int Idc = int.Parse(Id);
                ES = ConE.Estudiantes.Where(VerificarID => VerificarID.Id == Idc).First();
                ES.Nombre = txtNombre.Text;
                ES.Apellido = txtApellido.Text;
                ES.UserName = txtUsuario.Text;
                ES.Contrasena = txtContrasena.Text;
                ConE.Entry(ES).State = System.Data.Entity.EntityState.Modified;
                ConE.SaveChanges();
            }
            LimpiarDatos();
        }
    }
}
