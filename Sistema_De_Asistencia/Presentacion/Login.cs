using ORUSCURSO.Datos;
using ORUSCURSO.Logica;
using ORUSCURSO.Presentacion.AsistenteInstalacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ORUSCURSO.Presentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        string Usuario;
        int Idusuario;
        int Contador;
        string Indicador;
        private void Login_Load(object sender, EventArgs e)
        {
            validar_conexion();
        }
        private void validar_conexion()
        {
            VerificarConexion();
            if (Indicador == "Correcto")
            {
                MostrarUsuarios();
                if(Contador==0)
                {
                    Dispose();
                    UsuarioPrincipal frm = new UsuarioPrincipal();
                    frm.ShowDialog();
                }
                else
                {
                    DibujarUsuarios();
                }
              
            }
            else
            {
                Dispose();
                ElecccionServidor frm = new ElecccionServidor();
                frm.ShowDialog();
            }
        }
        private void MostrarUsuarios()
        {
            DataTable dt = new DataTable();
            Dusuarios funcion = new Dusuarios();
            funcion.mostrar_Usuarios(ref dt);
            Contador = dt.Rows.Count;
        }

        private void VerificarConexion()
        {
            Dusuarios funcion = new Dusuarios();
            funcion.VerificarUsuarios(ref Indicador);
        }
        private void DibujarUsuarios()
        {
            try
            {

                PanelUsuarios.Visible = true;
                PanelUsuarios.Dock = DockStyle.Fill;
                PanelUsuarios.BringToFront();
                DataTable dt = new DataTable();
                Dusuarios funcion = new Dusuarios();
                funcion.mostrar_Usuarios(ref dt);
                foreach (DataRow rdr in dt.Rows)
                {
                    Label b = new Label();
                    Panel p1 = new Panel();
                    PictureBox I1 = new PictureBox();
                    b.Text = rdr["Login"].ToString();
                    b.Name = rdr["idUsuario"].ToString();
                    b.Size = new Size(175, 25);
                    b.Font = new Font("Microsoft Sans Serif", 13);
                    b.BackColor = Color.Transparent;
                    b.ForeColor = Color.White;
                    b.Dock = DockStyle.Bottom;
                    b.TextAlign = ContentAlignment.MiddleCenter;
                    b.Cursor = Cursors.Hand;

                    p1.Size = new Size(155, 167);
                    p1.BorderStyle = BorderStyle.None;
                    p1.BackColor = Color.FromArgb(20, 20, 20);

                    I1.Size = new Size(175, 132);
                    I1.Dock = DockStyle.Top;
                    I1.BackgroundImage = null;
                    byte[] bi = (Byte[])rdr["Icono"];
                    MemoryStream ms = new MemoryStream(bi);
                    I1.Image = Image.FromStream(ms);
                    I1.SizeMode = PictureBoxSizeMode.Zoom;
                    I1.Tag = rdr["Login"].ToString();
                    I1.Cursor = Cursors.Hand;

                    p1.Controls.Add(b);
                    p1.Controls.Add(I1);
                    b.BringToFront();

                    flowLayoutPanel1.Controls.Add(p1);

                 
                    I1.Click += miEventoImagen;
                }
            }
            catch (Exception)
            {

              
            }
        }

        private void miEventoImagen(object sender, EventArgs e)
        {
            Usuario = Convert.ToString(((PictureBox)sender).Tag);
            Icono.Image = ((PictureBox)sender).Image;
            MostrarPanelPass();
        }

       
        private void MostrarPanelPass()
        {
            PanelIngreso_de_contraseña.Visible = true;
            PanelIngreso_de_contraseña.Location = new Point((Width -PanelIngreso_de_contraseña.Width)/2, (Height - PanelIngreso_de_contraseña.Height)/2);
            PanelUsuarios.Visible = false;
        }

        private void txtcontraseña_TextChanged(object sender, EventArgs e)
        {
            validarUsuarios();
        }
        private void validarUsuarios()
        {
            Lusuarios parametros = new Lusuarios();
            Dusuarios funcion = new Dusuarios();
            parametros.Password = txtcontraseña.Text;
            parametros.Login = Usuario;
            funcion.validarUsuario(parametros, ref Idusuario);
            if(Idusuario >0)
            {
                Dispose();
                MenuPrincipal frm = new MenuPrincipal();
                frm.Idusuario = Idusuario;
                frm.LoginV = Usuario;
                frm.Icono.Image = Icono.Image;
                frm.ShowDialog();
            }
        }

        private void btn_insertar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Contraseña erronea", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtcontraseña.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtcontraseña.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtcontraseña.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtcontraseña.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtcontraseña.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtcontraseña.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtcontraseña.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtcontraseña.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtcontraseña.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtcontraseña.Text += "0";
        }

        private void btnborrartodo_Click(object sender, EventArgs e)
        {
            txtcontraseña.Clear();
        }

        private void btnborrarderecha_Click(object sender, EventArgs e)
        {
            int contador;
            contador = txtcontraseña.Text.Count();
            if(contador>0)
            {

                txtcontraseña.Text = txtcontraseña.Text.Substring(0, txtcontraseña.Text.Count() - 1);
            }
        }
    }
}
