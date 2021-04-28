using ORUSCURSO.Datos;
using ORUSCURSO.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ORUSCURSO.Presentacion.AsistenteInstalacion
{
    public partial class UsuarioPrincipal : Form
    {
        public UsuarioPrincipal()
        {
            InitializeComponent();
        }
        int idusuario;
        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtnombre.Text))
            {
                if (!string.IsNullOrEmpty(TXTCONTRASEÑA.Text))
                {
                    if (TXTCONTRASEÑA.Text == txtconfirmarcontraseña.Text)
                    {
                        insertarUsuarioDefecto();
                            
                    }
                    else
                    {
                        MessageBox.Show("Las contraseñas no coinsiden", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Falta ingresar la Contraseña", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Falta ingresar el Nombre", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void insertarUsuarioDefecto()
        {
            Lusuarios parametros = new Lusuarios();
            Dusuarios funcion = new Dusuarios();
            parametros.Nombre = txtnombre.Text;
            parametros.Login = TXTUSUARIO.Text;
            parametros.Password = TXTCONTRASEÑA.Text;
            MemoryStream ms = new MemoryStream();
            Icono.Image.Save(ms, Icono.Image.RawFormat);
            parametros.Icono = ms.GetBuffer();
            if (funcion.InsertarUsuarios(parametros) == true)
            {
                InsertarcopiasBd();
                Insertar_Modulos();
                ObtenerIdUsuario();
                insertarPermisos();
            }
        }
        private void InsertarcopiasBd()
        {
            DcopiasBd funcion = new DcopiasBd();
            funcion.InsertarCopiasBd();
        }
        private void ObtenerIdUsuario()
        {
            Dusuarios funcion = new Dusuarios();
            funcion.ObtenerIdUsuario(ref idusuario, TXTUSUARIO.Text);
        }
        private void insertarPermisos()
        {
            DataTable dt = new DataTable();
            Dmodulos funcionModulos = new Dmodulos();
            funcionModulos.mostrar_Modulos(ref dt);
            foreach (DataRow row in dt.Rows)
            {
                int idModulo = Convert.ToInt32(row["IdModulo"]);
                Lpermisos parametros = new Lpermisos();
                Dpermisos funcion = new Dpermisos();
                parametros.IdModulo = idModulo;
                parametros.IdUsuario = idusuario;
                funcion.Insertar_Permisos(parametros);
                
            }
            MessageBox.Show("!LISTO! RECUERDA que para Iniciar Sesión tu Usuario es: " + TXTUSUARIO.Text + " y tu Contraseña es: " + TXTCONTRASEÑA.Text, "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Dispose();
            Login frm = new Login();
            frm.ShowDialog();

        }
        private void Insertar_Modulos()
        {
            Lmodulos parametros = new Lmodulos();
            Dmodulos funcion = new Dmodulos();
            var Modulos = new List<string> { "Usuarios", "Respaldos", "Personal", "PrePlanillas" };
            foreach(var Modulo in Modulos)
            {
                parametros.Modulo = Modulo;
               funcion.Insertar_Modulos(parametros);
            }
        }
    }
}
