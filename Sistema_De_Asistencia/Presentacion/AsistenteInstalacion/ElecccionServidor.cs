using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ORUSCURSO.Presentacion.AsistenteInstalacion
{
    public partial class ElecccionServidor : Form
    {
        public ElecccionServidor()
        {
            InitializeComponent();
        }

        private void BtnPrincipal_Click(object sender, EventArgs e)
        {
            Dispose();
            InstalacionBd frm = new InstalacionBd();
            frm.ShowDialog();
        }

        private void BtnRemoto_Click(object sender, EventArgs e)
        {
            Dispose();
            ConexionRemota frm = new ConexionRemota();
            frm.ShowDialog();
        }

        private void ElecccionServidor_Load(object sender, EventArgs e)
        {

        }
    }
}
