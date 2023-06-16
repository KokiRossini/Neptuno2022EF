using Neptuno2022EF.Entidades.Dtos.DetalleVenta;
using Neptuno2022EF.Entidades.Entidades;
using Neptuno2022EF.Windows.Helpers;
using System;
using System.Collections;
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
    public partial class frmDetalleProveedor : Form
    {
        public frmDetalleProveedor()
        {
            InitializeComponent();
        }
        private Proveedor proveedor;
        internal void SetProveedor(Proveedor proveedor)
        {
            this.proveedor = proveedor;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmDetalleProveedor_Load(object sender, EventArgs e)
        {
            GridHelper.LimpiarGrilla(dgvDatos);
            DataGridViewRow r = GridHelper.ConstruirFila(dgvDatos);
            GridHelper.SetearFila(r, proveedor);
            GridHelper.AgregarFila(dgvDatos, r);

        }
    }
}
