using ORUSCURSO.Datos;
using ORUSCURSO.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ORUSCURSO.Presentacion
{
    public partial class TomarAsistencias : Form
    {
        public TomarAsistencias()
        {
            InitializeComponent();
        }
        string Identificacion;
        int IdPersonal;
        int Contador;
        DateTime fechaReg;
        private void TomarAsistencias_Load(object sender, EventArgs e)
        {

        }

        private void timerHora_Tick(object sender, EventArgs e)
        {
            lblhora2.Text = DateTime.Now.ToString("hh:mm:ss");
            lblfecha.Text = DateTime.Now.ToShortDateString ();
        }

        private void txtIdentificacion_TextChanged(object sender, EventArgs e)
        {
            BuscarPersonalIdent();
            if(Identificacion ==txtIdentificacion.Text)
            {
                buscarAsistenciasId();
                if(Contador==0)
                {
                    DialogResult resultado = MessageBox.Show("¿Agregar una Observacion?", "Observaciones", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if(resultado ==DialogResult.OK)
                    {
                        panelObservacion.Visible = true;
                        panelObservacion.Location = new Point(Panel1.Location.X, Panel1.Location.Y);
                        panelObservacion.Size = new Size(Panel1.Width, Panel1.Height);
                        panelObservacion.BringToFront();
                        txtObservacion.Clear();
                        txtObservacion.Focus();
                        
                    }
                    else
                    {
                        InsertarAsistencias();
                    }
                }
                else
                {
                    ConfirmarSalida();
                }

            }
        }
        private void ConfirmarSalida()
        {
            Lasistencias parametros = new Lasistencias();
            Dasistencias funcion = new Dasistencias();
            parametros.Id_personal = IdPersonal;
            parametros.Fecha_salida = DateTime.Now;
            parametros.Horas = Bases.DateDiff(Bases.DateInterval.Hour, fechaReg, DateTime.Now);
            if(funcion.ConfirmarSalida(parametros)==true)
            {
                txtaviso.Text = "SALIDA REGISTRADA";
                txtIdentificacion.Clear();
                txtIdentificacion.Focus();
            }

        }
        private void InsertarAsistencias()
        {
            if(string.IsNullOrEmpty(txtObservacion.Text))
            {
                txtObservacion.Text = "-";
            }
            Lasistencias parametros = new Lasistencias();
            Dasistencias funcion = new Dasistencias();
            parametros.Id_personal = IdPersonal;
            parametros.Fecha_entrada = DateTime.Now;
            parametros.Fecha_salida = DateTime.Now;
            parametros.Estado = "ENTRADA";
            parametros.Horas = 0;
            parametros.Observacion = txtObservacion.Text;
          if(funcion.InsertarAsistencias(parametros)==true)
            {
                txtaviso.Text = "ENTRADA REGISTRADA";
                txtIdentificacion.Clear();
                txtIdentificacion.Focus();
                panelObservacion.Visible = false;
            }

        }
        private void buscarAsistenciasId()
        {
            DataTable dt = new DataTable();
            Dasistencias funcion = new Dasistencias();
            funcion.buscarAsistenciasId(ref dt, IdPersonal);
            Contador = dt.Rows.Count;
            if(Contador >0)
            {
                fechaReg = Convert.ToDateTime(dt.Rows[0]["Fecha_entrada"]);
               
            }
        }
        private void BuscarPersonalIdent()
        {
            DataTable dt = new DataTable();
            Dpersonal funcion = new Dpersonal();
            funcion.BuscarPersonalIdentidad(ref dt, txtIdentificacion.Text);
            if(dt.Rows.Count >0)
            {
                Identificacion = dt.Rows[0]["Identificacion"].ToString();
                IdPersonal =Convert.ToInt32( dt.Rows[0]["Id_personal"]);
                txtNombre.Text = dt.Rows[0]["Nombres"].ToString();
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            InsertarAsistencias();
        }

        private void BtnIniciarSesion_Click(object sender, EventArgs e)
        {
            Dispose();
            Login frm = new Login();
            frm.ShowDialog();
        }
    }
}
