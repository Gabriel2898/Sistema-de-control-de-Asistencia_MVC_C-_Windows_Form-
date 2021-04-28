using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ORUSCURSO.Datos;
using ORUSCURSO.Logica;
using System.IO;

namespace ORUSCURSO.Presentacion
{
    public partial class CtlUsuarios : UserControl
    {
        public CtlUsuarios()
        {
            InitializeComponent();
        }
        int Idusuario;
        string login;
        string estado;
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Limpiar();
            habilitarPaneles();
            MostrarModulos();
        }
        private void Limpiar()
        {
            txtnombre.Clear();
            txtcontraseña.Clear();
            txtusuario.Clear();
            txtusuario.Enabled = true;
            datalistadoModulos.Enabled = true;
        }
        private void habilitarPaneles()
        {
            panelRegistro.Visible = true;
            lblanuncioIcono.Visible = true;
            panelIcono.Visible = false;
            panelRegistro.Dock = DockStyle.Fill;
            panelRegistro.BringToFront();
            btnguardar.Visible = true;
            btnActualizar.Visible = false;
        }
        private void MostrarModulos()
        {
            Dmodulos funcion = new Dmodulos();
            DataTable dt = new DataTable();
            funcion.mostrar_Modulos(ref dt);
            datalistadoModulos.DataSource = dt;
            datalistadoModulos.Columns[1].Visible = false;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtnombre.Text))
            {
                if (!string.IsNullOrEmpty(txtusuario.Text))
                {
                    if (!string.IsNullOrEmpty(txtcontraseña.Text))
                    {
                        if (lblanuncioIcono.Visible == false)
                        {
                            insertarUsuarios();
                        }
                        else
                        {
                            MessageBox.Show("Seleccione un Icono");
                           
                        }

                    }
                    else
                    {
                        MessageBox.Show("Ingrese la contraseña");
                       

                    }
                }
                else
                {
                    MessageBox.Show("Ingrese el Usuario");
                   

                }
            }
            else
            {
               
                MessageBox.Show("Ingrese el Nombre");
            }

        }
        private void insertarUsuarios()
        {
            Lusuarios parametros = new Lusuarios();
            Dusuarios funcion = new Dusuarios();
            parametros.Nombre = txtnombre.Text;
            parametros.Login = txtusuario.Text;
            parametros.Password = txtcontraseña.Text;
            MemoryStream ms = new MemoryStream();
            Icono.Image.Save(ms, Icono.Image.RawFormat);
            parametros.Icono = ms.GetBuffer();
            if(funcion.InsertarUsuarios(parametros)==true)
            {
                ObtenerIdUsuario();
                InsertarPermisos();
            }

        }
        private void InsertarPermisos()
        {
            foreach (DataGridViewRow row in datalistadoModulos.Rows)
            {
                int IdModulo = Convert.ToInt32(row.Cells["IdModulo"].Value);
                bool marcado =Convert.ToBoolean ( row.Cells["Marcar"].Value);
                if(marcado==true)
                {
                    Lpermisos parametros = new Lpermisos();
                    Dpermisos funcion = new Dpermisos();
                    parametros.IdModulo = IdModulo;
                    parametros.IdUsuario = Idusuario;
                    funcion.Insertar_Permisos(parametros);
                    
                }
            }
              MostrarUsuarios();
              panelRegistro.Visible = false;
        }
        private void MostrarUsuarios()
        {
            DataTable dt = new DataTable();
            Dusuarios funcion = new Dusuarios();
            funcion.mostrar_Usuarios(ref dt);
            datalistadoUsuarios.DataSource = dt;
            DiseñarDtvUsuarios();


        }
        private void DiseñarDtvUsuarios()
        {
            Bases.DiseñoDtv(ref datalistadoUsuarios);
            Bases.DiseñoDtvEliminar(ref datalistadoUsuarios);
            datalistadoUsuarios.Columns[2].Visible = false;
            datalistadoUsuarios.Columns[5].Visible = false;
            datalistadoUsuarios.Columns[6].Visible = false;
        }
        private void ObtenerIdUsuario()
        {
            Dusuarios funcion = new Dusuarios();
            funcion.ObtenerIdUsuario(ref Idusuario, txtusuario.Text);

        }

        private void lblanuncioIcono_Click(object sender, EventArgs e)
        {
            MostrarPanelIcono();
        }
        private void MostrarPanelIcono()
        {
            panelIcono.Visible = true;
            panelIcono.Dock = DockStyle.Fill;
            panelIcono.BringToFront();
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Icono.Image = pictureBox3.Image;
            ocultarPanelIconos();

        }
        private void ocultarPanelIconos()
        {
            panelIcono.Visible = false;
            lblanuncioIcono.Visible = false;
            Icono.Visible = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Icono.Image = pictureBox4.Image;
            ocultarPanelIconos();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Icono.Image = pictureBox5.Image;
            ocultarPanelIconos();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Icono.Image = pictureBox6.Image;
            ocultarPanelIconos();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Icono.Image = pictureBox7.Image;
            ocultarPanelIconos();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Icono.Image = pictureBox8.Image;
            ocultarPanelIconos();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Icono.Image = pictureBox9.Image;
            ocultarPanelIconos();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Icono.Image = pictureBox10.Image;
            ocultarPanelIconos();
        }

        private void AgregarIconoPC_Click(object sender, EventArgs e)
        {
            dlg.InitialDirectory = "";
            dlg.Filter = "Imagenes|*.jpg;*.png";
            dlg.FilterIndex = 2;
            dlg.Title = "Cargador de imagenes";
            if(dlg.ShowDialog()==DialogResult.OK )
            {
                Icono.BackgroundImage = null;
                Icono.Image = new Bitmap(dlg.FileName);
                ocultarPanelIconos();
            }
        }

        private void Icono_Click(object sender, EventArgs e)
        {
            MostrarPanelIcono();
        }

        private void CtlUsuarios_Load(object sender, EventArgs e)
        {
            MostrarUsuarios();
        }

        private void txtcontraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsDigit  (e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl (e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            panelRegistro.Visible = false;
        }

        private void btnVolverIcono_Click(object sender, EventArgs e)
        {
            ocultarPanelIconos();
        }

        private void datalistadoUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex ==datalistadoUsuarios.Columns["Editar"].Index)
            {
                obtenerEstado();
                if (estado == "ELIMINADO")
                {
                    DialogResult resultado = MessageBox.Show("Este Usuario se Elimino. ¿Desea Volver a Habilitarlo?", "Restauracion de registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if(resultado==DialogResult.OK)
                    {
                        RestaurarUsuario();
                    }
                }
                else
                {
                      ObtenerDatos();
                }
                
            }
            if (e.ColumnIndex == datalistadoUsuarios.Columns["Eliminar"].Index)
            {
                DialogResult resultado = MessageBox.Show("¿Realmente desea eliminar este Registro?", "Eliminando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (resultado == DialogResult.OK)
                {
                capturarIdUsuario();
                EliminarUsuarios();
                }
                    
            }
        }
        private void RestaurarUsuario()
        {
            capturarIdUsuario();
            Lusuarios parametros = new Lusuarios();
            Dusuarios funcion = new Dusuarios();
            parametros.IdUsuario = Idusuario;
            if(funcion.restaurar_usuario(parametros)==true)
            {
                MostrarUsuarios();
            }
        }
        private void EliminarUsuarios()
        {
            Lusuarios parametros = new Lusuarios();
            Dusuarios funcion = new Dusuarios();
            parametros.IdUsuario = Idusuario;
            parametros.Login = login;
            if(funcion.eliminar_Usuarios(parametros )==true)
            {
                MostrarUsuarios();
            }
        }
        private void obtenerEstado()
        {
            estado = datalistadoUsuarios.SelectedCells[7].Value.ToString();
        }
        private void ObtenerDatos()
        {
            capturarIdUsuario();
            txtnombre.Text = datalistadoUsuarios.SelectedCells[3].Value.ToString();
            txtusuario.Text = datalistadoUsuarios.SelectedCells[4].Value.ToString();
            if(txtusuario.Text=="admin")
            {
                txtusuario.Enabled = false;
                datalistadoModulos.Enabled = false;
            }
            else
            {
                txtusuario.Enabled = true;
                datalistadoModulos.Enabled = true;
            }
            txtcontraseña.Text = datalistadoUsuarios.SelectedCells[5].Value.ToString();
            
            Icono.BackgroundImage = null;
            byte[] b = (byte[])(datalistadoUsuarios.SelectedCells[6].Value);
            MemoryStream ms = new MemoryStream(b);
            Icono.Image = Image.FromStream(ms);
            panelRegistro.Visible = true;
            panelRegistro.Dock = DockStyle.Fill;
            lblanuncioIcono.Visible = false;
            btnActualizar.Visible = true;
            btnguardar.Visible = false;
            MostrarModulos();
            mostrarPermisos();
        }
        private void mostrarPermisos()
        {
            DataTable dt = new DataTable();
            Dpermisos funcion = new Dpermisos();
            Lpermisos parametros = new Lpermisos();
            parametros.IdUsuario = Idusuario;
            funcion.mostrar_Permisos(ref dt, parametros);
            foreach (DataRow rowPermisos in dt.Rows)
            {
                int idmoduloPermisos =Convert.ToInt32 (rowPermisos["IdModulo"]);
                foreach (DataGridViewRow rowModulos in datalistadoModulos.Rows)
                {
                    int Idmodulo =Convert.ToInt32(rowModulos.Cells["IdModulo"].Value);
                    if (idmoduloPermisos == Idmodulo)
                    {
                        rowModulos.Cells[0].Value = true;
                    }
                }
            }
        }
        private void capturarIdUsuario()
        {
            Idusuario =Convert.ToInt32( datalistadoUsuarios.SelectedCells[2].Value);
            login = datalistadoUsuarios.SelectedCells[4].Value.ToString();
           

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtnombre.Text))
            {
                if (!string.IsNullOrEmpty(txtusuario.Text))
                {
                    if (!string.IsNullOrEmpty(txtcontraseña.Text))
                    {
                        if (lblanuncioIcono.Visible == false)
                        {
                            editarUsuarios();
                        }
                        else
                        {
                            MessageBox.Show("Seleccione un Icono");

                        }

                    }
                    else
                    {
                        MessageBox.Show("Ingrese la contraseña");


                    }
                }
                else
                {
                    MessageBox.Show("Ingrese el Usuario");


                }
            }
            else
            {

                MessageBox.Show("Ingrese el Nombre");
            }
        }
        private void editarUsuarios()
        {
            Lusuarios parametros = new Lusuarios();
            Dusuarios funcion = new Dusuarios();
            parametros.IdUsuario = Idusuario;
            parametros.Nombre = txtnombre.Text;
            parametros.Login = txtusuario.Text;
            parametros.Password = txtcontraseña.Text;
            MemoryStream ms = new MemoryStream();
            Icono.Image.Save(ms, Icono.Image.RawFormat);
            parametros.Icono = ms.GetBuffer();
            if(funcion .editar_Usuarios(parametros)==true)
            {
                eliminarPermisos();
                InsertarPermisos();
            }
        }
        private void eliminarPermisos()
        {
            Lpermisos parametros = new Lpermisos();
            Dpermisos funcion = new Dpermisos();
            parametros.IdUsuario = Idusuario;
            funcion.Eliminar_Permisos(parametros);

        }

        private void txtbuscador_TextChanged(object sender, EventArgs e)
        {
            BuscarUsuarios();
        }
        private void BuscarUsuarios()
        {
            DataTable dt = new DataTable();
            Dusuarios funcion = new Dusuarios();
            funcion.buscar_Usuarios(ref dt, txtbuscador.Text);
            datalistadoUsuarios.DataSource = dt;
            DiseñarDtvUsuarios();
        }
    }
}
