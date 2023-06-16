using Neptuno2022EF.Entidades.Dtos.DetalleVenta;
using Neptuno2022EF.Entidades.Dtos.Proveedor;
using Neptuno2022EF.Windows.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Neptuno2022EF.Windows
{
    public partial class frmResumenProveedor : Form
    {
        public frmResumenProveedor()
        {
            InitializeComponent();
        }
        private List<ResumenProveedorListDto> resumen;

        private void frmResumenProveedor_Load(object sender, EventArgs e)
        {
            FormHelper.MostrarDatosEnGrilla<ResumenProveedorListDto>(dgvDatos, resumen);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        internal void SetResumen(List<ResumenProveedorListDto> resumen)
        {
            this.resumen = resumen;
        }
    }
}
