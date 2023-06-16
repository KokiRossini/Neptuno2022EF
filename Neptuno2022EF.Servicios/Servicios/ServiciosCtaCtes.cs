using Neptuno2022EF.Datos;
using Neptuno2022EF.Datos.Interfaces;
using Neptuno2022EF.Entidades.Dtos;
using Neptuno2022EF.Entidades.Entidades;
using Neptuno2022EF.Servicios.Interfaces;
using NuevaAppComercial2022.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Neptuno2022EF.Servicios.Servicios
{
    public class ServiciosCtaCtes : IServiciosCtaCtes
    {
        private readonly IRepositorioCtaCtes _repositorio;
        private IUnitOfWork _unitOfWork;

        public ServiciosCtaCtes(IRepositorioCtaCtes repositorio, IUnitOfWork unitOfWork)
        {
            _repositorio = repositorio;
            _unitOfWork = unitOfWork;
        }

        public List<CtaCteListDto> Filtrar(Func<Ciudad, bool> predicado)
        {
            throw new NotImplementedException();
        }

        public List<CtaCteListDto> Filtrar(Func<CtaCte, bool> predicado)
        {
            try
            {
                return _repositorio.Filtrar(predicado);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<CtaCte> GetCtaCtes(int id)
        {
            try
            {
                return _repositorio.GetCtaCtes(id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public CtaCte GetCtaCtePorId(int id)
        {
            try
            {
                return _repositorio.GetCtaCtePorId(id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<CtaCteListDto> GetCtaCtes()
        {
            try
            {
                return _repositorio.GetCtaCtes();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Pagar(Cliente cliente, decimal cantPagando)
        {
            try
            {
                using (var transaction = new TransactionScope())
                {
                    var ctaCteAGuardar = new CtaCte()
                    {

                    };
                }
                _repositorio.Pagar(cliente, cantPagando);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Agregar(CtaCte ctaCte)
        {
            try
            {
                using (var transaction=new TransactionScope())
                {
                    var ctaCteAGuardar = new CtaCte()
                    {
                        ClienteId = ctaCte.ClienteId,
                        FechaMovimiento = ctaCte.FechaMovimiento,
                        Movimiento = ctaCte.Movimiento,
                        Debe = ctaCte.Debe,
                        Haber = ctaCte.Haber,
                        Saldo = ctaCte.Saldo,
                    };
                    _repositorio.Agregar(ctaCteAGuardar);
                    _unitOfWork.SaveChanges();
                    transaction.Complete();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Existe(CtaCte ctaCorriente)
        {
            try
            {
                return _repositorio.Existe(ctaCorriente);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
