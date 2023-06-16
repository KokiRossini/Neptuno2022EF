using Neptuno2022EF.Entidades.Dtos;
using Neptuno2022EF.Entidades.Entidades;
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
    public partial class frmCtaCtePago : Form
    {
        public frmCtaCtePago()
        {
            InitializeComponent();
        }
        private CtaCteListDto ctaCteDto;
        private CtaCte cta;
        //private Cliente cliente;
        private decimal valorPagado=0;
        internal void SetCtaCteListDto(CtaCteListDto ctaCteDto)
        {
            this.ctaCteDto = ctaCteDto;
        }

        private void frmCtaCtePago_Load(object sender, EventArgs e)
        {
            txtMontoAPagar.Text= ctaCteDto.Total.ToString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (ctaCteDto.Total==decimal.Parse(txtCantPagando.Text))
                {
                    cta = new CtaCte()
                    {
                        ClienteId = ctaCteDto.ClienteId,
                        Haber = decimal.Parse(txtCantPagando.Text),
                        Debe =0,
                        Saldo = 0,
                        FechaMovimiento=DateTime.Now,
                        Movimiento="Efectivo"
                        
                    };
                    //valorPagado = decimal.Parse(txtCantPagando.Text);

                }
                else
                {
                    cta = new CtaCte()
                    {
                        ClienteId = ctaCteDto.ClienteId,
                        Haber = decimal.Parse(txtCantPagando.Text),
                        Debe = 0,
                        Saldo = ctaCteDto.Total - decimal.Parse(txtCantPagando.Text),
                        FechaMovimiento = DateTime.Now,
                        Movimiento = "Efectivo"

                    };

                }
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            var valido = true;
            errorProvider1.Clear();
            if (!double.TryParse(txtCantPagando.Text, out double c))
            {
                valido = false;
                errorProvider1.SetError(txtCantPagando, "valor incorrecto");
            }
            else if (double.Parse(txtCantPagando.Text)<=0)
            {
                valido=false;
                errorProvider1.SetError(txtCantPagando, "la cantidad debe ser mayor a 0");
            }
            else if ((double.Parse(txtCantPagando.Text)> (double.Parse(txtMontoAPagar.Text))))
            {
                valido = false;
                errorProvider1.SetError(txtCantPagando, "la cantidad es mayor al total a pagar");

            }
            return valido;
        }

        //internal void SetCliente(Cliente cliente)
        //{
        //    this.cliente = cliente;
        //}

        internal decimal GetValorPagado()
        {
            return valorPagado;
        }

        internal void SetCtaCte(CtaCte ctaCte)
        {
            //this.ctaCte = ctaCte;
        }

        internal CtaCte GetCtaAGuardar()
        {
            return cta;
        }
    }
}
