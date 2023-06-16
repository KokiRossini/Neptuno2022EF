using Neptuno2022EF.Entidades.Entidades;
using Neptuno2022EF.Windows.Helpers;
using NuevaAppComercial2022.Entidades.Entidades;
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
    public partial class frmDetalleCtaCte : Form
    {
        private List<CtaCte> listaCtaCte;
        private Cliente cliente1 = new Cliente();
        private decimal saldo=0;
        private decimal debe=0;
        private decimal haber = 0;
        public frmDetalleCtaCte()
        {
            InitializeComponent();
        }

        internal void SetCtaCte(List<CtaCte> listaMovimientosCtaCte)
        {
            this.listaCtaCte = listaMovimientosCtaCte;
        }

        private void frmDetalleCtaCte_Load(object sender, EventArgs e)
        {
            GridHelper.LimpiarGrilla(dgvDatos);
            foreach (var cta in listaCtaCte)
            {
                DataGridViewRow r = GridHelper.ConstruirFila(dgvDatos);
                GridHelper.SetearFila(r, cta);
                GridHelper.AgregarFila(dgvDatos, r);
                debe = debe + cta.Debe;
                haber=haber + cta.Haber;
            }
            
            CargarDatos();

        }

        private void CargarDatos()
        {
            foreach(var datos in listaCtaCte)
            {
                cliente1 = datos.Cliente;
            }
            txtCliente.Text = cliente1.Nombre;
            txtDireccion.Text = cliente1.Direccion;
            txtPais.Text = cliente1.Pais.NombrePais;
            txtLocalidad.Text = cliente1.Ciudad.NombreCiudad;
            txtCP.Text = cliente1.CodPostal;
            txtSaldo.Text = (debe - haber).ToString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult= DialogResult.OK;
        }
    }
}
