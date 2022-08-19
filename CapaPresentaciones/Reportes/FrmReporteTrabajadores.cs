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
    public partial class FrmReporteTrabajadores : Form
    {
        private String _Texto;

        public String Texto
        {
            get { return _Texto; }
            set { _Texto = value; }
        }

        public FrmReporteTrabajadores()
        {
            InitializeComponent();
        }

        private void FrmReporteTrabajadores_Load(object sender, EventArgs e)
        {
            try
            {
                this.spmostrar_trabajadorTableAdapter.Fill(this.dsPrincipal.spmostrar_trabajador, Texto);
                this.reportViewer1.RefreshReport();
            }

            catch
            {
                this.reportViewer1.RefreshReport();
            }
        
        }
    }
}
