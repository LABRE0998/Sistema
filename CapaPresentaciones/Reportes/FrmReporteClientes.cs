using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentaciones.Reportes
{
    public partial class FrmReporteClientes : Form
    {
        private string _Texto;

        public string Texto
        {
            get { return _Texto; }
            set { _Texto = value; }
        }

        public FrmReporteClientes()
        {
            InitializeComponent();
        }

        private void FrmReporteClientes_Load(object sender, EventArgs e)
        {
            try
            {
                this.spbuscar_cliente_apellidosTableAdapter.Fill(this.dsPrincipal.spbuscar_cliente_apellidos, Texto);

                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                this.reportViewer1.RefreshReport();
            }
        }
    }
}
