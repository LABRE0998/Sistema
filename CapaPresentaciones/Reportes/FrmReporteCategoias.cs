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
    public partial class FrmReporteCategoias : Form
    {
        private string _Texto;

        public string Texto
        {
            get { return _Texto; }
            set { _Texto = value; }
        }
        public FrmReporteCategoias()
        {
            InitializeComponent();
        }

        private void FrmReporteCategoias_Load(object sender, EventArgs e)
        {
            try
            {
                this.spbuscar_categoriaTableAdapter.Fill(this.dsPrincipal.spbuscar_categoria, Texto);

                this.reportViewer1.RefreshReport();
            }
            catch
            {
                this.reportViewer1.RefreshReport();
            }
        }
    }
}
