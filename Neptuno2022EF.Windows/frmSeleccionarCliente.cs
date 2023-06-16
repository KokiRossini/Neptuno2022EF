using Neptuno2022EF.Entidades.Dtos.Cliente;
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
    public partial class frmSeleccionarCliente : Form
    {
        public frmSeleccionarCliente()
        {
            InitializeComponent();
        }
        private ClienteListDto cliente;

        internal ClienteListDto GetCliente()
        {
            return cliente;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();

            if (cboClientes.SelectedIndex == 0)
            {
                valido = false;
                errorProvider1.SetError(cboClientes, "Debe seleccionar un cliente");
            }
            return valido;
        }

        private void frmSeleccionarCliente_Load(object sender, EventArgs e)
        {
            CombosHelper.CargarComboClientes(ref cboClientes);
        }

        private void cboClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboClientes.SelectedIndex > 0)
            {
                cliente = (ClienteListDto)cboClientes.SelectedItem;
            }
            else
            {
                cliente = null;
            }
        }
    }
}
