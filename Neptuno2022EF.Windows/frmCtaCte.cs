using Microsoft.Win32;
using Neptuno2022EF.Entidades.Dtos;
using Neptuno2022EF.Entidades.Dtos.Cliente;
using Neptuno2022EF.Entidades.Entidades;
using Neptuno2022EF.Servicios.Interfaces;
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
    public partial class frmCtaCte : Form
    {
        private readonly IServiciosCtaCtes _servicio;
        private readonly IServiciosClientes _serviciosClientes;

        private List<CtaCteListDto> lista;
        Func<CtaCte, bool> predicado;
        private bool filtroOn = false;

        public frmCtaCte(IServiciosCtaCtes servicio, IServiciosClientes serviciosClientes)
        {
            InitializeComponent();
            _servicio = servicio;
            _serviciosClientes = serviciosClientes;
        }

        private void frmCtaCte_Load(object sender, EventArgs e)
        {
            RecargarGrilla();
        }

        private void RecargarGrilla()
        {
            if (filtroOn)
            {
                lista = _servicio.Filtrar(predicado);
            }
            else
            {
                lista = _servicio.GetCtaCtes();

            }
            MostrarDatosEnGrilla();

            //try
            //{
            //    lista = _servicio.GetCtaCtes();
            //    MostrarDatosEnGrilla();
            //}
            //catch (Exception)
            //{

            //    throw;
            //}
        }

        private void MostrarDatosEnGrilla()
        {
            GridHelper.LimpiarGrilla(dgvDatos);
            foreach (CtaCteListDto ctaCte in lista)
            {
                DataGridViewRow r = GridHelper.ConstruirFila(dgvDatos);
                GridHelper.SetearFila(r, ctaCte);
                GridHelper.AgregarFila(dgvDatos, r);
            }
        }

        private void tsbPagar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                return;
            }
            try
            {
                var r = dgvDatos.SelectedRows[0];
                var IdDto = (CtaCteListDto)r.Tag;
                //Cliente cliente = _serviciosClientes.GetClientePorId(IdDto.ClienteId);
                //CtaCte ctaCte = _servicio.GetCtaCtePorId(IdDto.ClienteId);
                frmCtaCtePago frm = new frmCtaCtePago() { Text = "Realizar Pago" };

                //frm.SetCliente(cliente);
                frm.SetCtaCteListDto(IdDto);
                //frm.SetCtaCte(ctaCte);
                DialogResult dr = frm.ShowDialog(this);
                      
                if (dr == DialogResult.Cancel) { return; }
                try
                {
                    CtaCte cta = frm.GetCtaAGuardar();
                    _servicio.Agregar(cta);
                    //_servicio.Pagar(,valorPagago);
                    RecargarGrilla();

                }
                catch (Exception)
                {

                    throw;
                }

            }
            catch (Exception)
            {

                throw;
            }

        }

        private void tsbCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsbResumen_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count > 0)
            {
                frmDetalleCtaCte frm = new frmDetalleCtaCte();
                frm.Text = "Detalle de Cta. Cte";
                DataGridViewRow r = dgvDatos.CurrentRow;
                var ctaCteDto = (CtaCteListDto)r.Tag;
                //var ctaCte = _servicio.GetCtaCtePorId(ctaCteDto.ClienteId);
                List<CtaCte> listaMovimientosCtaCte = _servicio.GetCtaCtes(ctaCteDto.ClienteId);
                frm.SetCtaCte(listaMovimientosCtaCte);
                DialogResult dr = frm.ShowDialog(this);
            }
        }

        private void tsbFiltrar_Click(object sender, EventArgs e)
        {
            frmSeleccionarCliente frm = new frmSeleccionarCliente() { Text = "Seleccionar..." };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) { return; }
            try
            {
                var clienteSeleccionado = frm.GetCliente();
                predicado = c => c.Cliente.Nombre == clienteSeleccionado.NombreCliente;
                //lista = _servicio.Filtrar(predicado);
                //lista = _servicio.GetCiudades(paisSeleccionado.PaisId);
                //MostrarDatosEnGrilla();
                filtroOn = true;
                RecargarGrilla();
                tsbFiltrar.BackColor = Color.Orange;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void tsbActualizar_Click(object sender, EventArgs e)
        {
            filtroOn = false;
            RecargarGrilla();
            tsbFiltrar.BackColor = Color.White;
        }
    }
}
