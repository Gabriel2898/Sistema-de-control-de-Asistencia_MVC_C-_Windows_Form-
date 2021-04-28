using ORUSCURSO.Datos;
using ORUSCURSO.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ORUSCURSO.Presentacion
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }
        public int Idusuario;
        public string LoginV;
        string Base_De_datos = "ORUS369";
        string Servidor = @".\SQLEXPRESS";
        string ruta;
        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            panelBienvenida.Dock = DockStyle.Fill;
            validarPermisos();
            lblLogin.Text = LoginV;
        }
        private void validarPermisos()
        {
            DataTable dt = new DataTable();
            Dpermisos funcion = new Dpermisos();
            Lpermisos parametros = new Lpermisos();
            parametros.IdUsuario = Idusuario;
            funcion.mostrar_Permisos(ref dt, parametros);
            btnConsultas.Enabled = false;
            btnPersonal.Enabled = false;
            btnRegistro.Enabled = false;
            btnUsuarios.Enabled = false;

            btnRestaurar.Enabled = false;
            btnRespaldos.Enabled = false;
            
            foreach (DataRow rowPermisos in dt.Rows)
            {
                string Modulo = Convert.ToString(rowPermisos["Modulo"]);
                if(Modulo== "PrePlanillas")
                {
                    btnConsultas.Enabled = true;
                }
                if (Modulo == "Usuarios")
                {
                    btnUsuarios.Enabled = true;
                    btnRegistro.Enabled = true;
                }
                if (Modulo == "Personal")
                {
                    btnPersonal.Enabled = true;
                }
                if (Modulo == "Respaldos")
                {
                    btnRespaldos.Enabled = true;
                    btnRestaurar.Enabled = true;
                }



            }
        }
        private void btnConsultas_Click(object sender, EventArgs e)
        {
            PanelPadre.Controls.Clear();
            Preplanilla control = new Preplanilla();
            control.Dock = DockStyle.Fill;
            PanelPadre.Controls.Add(control);

        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            PanelPadre.Controls.Clear();
            Personal control = new Personal();
            control.Dock = DockStyle.Fill;
            PanelPadre.Controls.Add(control);
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            PanelPadre.Controls.Clear();
            CtlUsuarios control = new CtlUsuarios();
            control.Dock = DockStyle.Fill;
            PanelPadre.Controls.Add(control);
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            Dispose();
            TomarAsistencias frm = new TomarAsistencias();
            frm.ShowDialog();
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            RestaurarBdExpress();
        }
        private void RestaurarBdExpress()
        {
            dlg.InitialDirectory = "";
            dlg.Filter = "Backup " + Base_De_datos + "|*.bak";
            dlg.FilterIndex = 2;
            dlg.Title = "Cargador de Backup";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                ruta = Path.GetFullPath(dlg.FileName);
                DialogResult pregunta = MessageBox.Show("Usted está a punto de restaurar la base de datos," + "asegurese de que el archivo .bak sea reciente, de" + "lo contrario podría perder información y no podrá" + "recuperarla, ¿desea continuar?", "Restauración de base de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (pregunta == DialogResult.Yes)
                {

                    SqlConnection cnn = new SqlConnection("Server=" + Servidor + ";database=master; integrated security=yes");
                    try
                    {
                    cnn.Open();
                    string Proceso= "EXEC msdb.dbo.sp_delete_database_backuphistory @database_name = N'" + Base_De_datos + "' USE [master] ALTER DATABASE [" + Base_De_datos + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE DROP DATABASE [" + Base_De_datos + "] RESTORE DATABASE " + Base_De_datos + " FROM DISK = N'" + ruta + "' WITH FILE = 1, NOUNLOAD, REPLACE, STATS = 10";
                    SqlCommand BorraRestaura = new SqlCommand(Proceso, cnn);
                    BorraRestaura.ExecuteNonQuery();
                    MessageBox.Show("La base de datos ha sido restaurada satisfactoriamente! Vuelve a Iniciar El Aplicativo", "Restauración de base de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Dispose();
                    }
                    catch (Exception)
                    {

                        RestaurarNoExpress();
                    }
                    finally
                    {
                        if (cnn.State == ConnectionState.Open)
                        {
                            cnn.Close();
                        }

                    }

                }
            }

        }
        private void RestaurarNoExpress()
        {
            Servidor = ".";
            SqlConnection cnn = new SqlConnection("Server=" + Servidor + ";database=master; integrated security=yes");
            try
            {
                cnn.Open();
                string Proceso = "EXEC msdb.dbo.sp_delete_database_backuphistory @database_name = N'" + Base_De_datos + "' USE [master] ALTER DATABASE [" + Base_De_datos + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE DROP DATABASE [" + Base_De_datos + "] RESTORE DATABASE " + Base_De_datos + " FROM DISK = N'" + ruta + "' WITH FILE = 1, NOUNLOAD, REPLACE, STATS = 10";
                SqlCommand BorraRestaura = new SqlCommand(Proceso, cnn);
                BorraRestaura.ExecuteNonQuery();
                MessageBox.Show("La base de datos ha sido restaurada satisfactoriamente! Vuelve a Iniciar El Aplicativo", "Restauración de base de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Dispose();


            }
            catch (Exception)
            {

            }
            finally
            {
                if (cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }

            }
        }
        private void btnRespaldos_Click(object sender, EventArgs e)
        {
            PanelPadre.Controls.Clear();
            CopiasBd control = new CopiasBd();
            control.Dock = DockStyle.Fill;
            PanelPadre.Controls.Add(control);
        }
    }
}
