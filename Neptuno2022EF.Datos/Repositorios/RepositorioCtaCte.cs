using Microsoft.Win32;
using Neptuno2022EF.Datos.Interfaces;
using Neptuno2022EF.Entidades.Dtos;
using Neptuno2022EF.Entidades.Dtos.Ciudad;
using Neptuno2022EF.Entidades.Dtos.Cliente;
using Neptuno2022EF.Entidades.Entidades;
using NuevaAppComercial2022.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neptuno2022EF.Datos.Repositorios
{
    public class RepositorioCtaCte : IRepositorioCtaCtes
    {
        private readonly NeptunoDbContext _context;

        public RepositorioCtaCte(NeptunoDbContext context)
        {
            _context = context;
        }

        public List<CtaCteListDto> Filtrar(Func<CtaCte, bool> predicado)
        {
            return _context.CtaCtes
                .Include(c => c.Cliente)
                .Where(predicado)
                .GroupBy(c => c.Cliente.Id, c => new { c, c.Cliente })
                .OrderBy(c => c.Key)
                .Select(c => new CtaCteListDto()
                {
                    ClienteId = c.Key,
                    Cliente = c.FirstOrDefault(cd => cd.Cliente.Id == c.Key).Cliente.Nombre,
                    Total = c.Sum(cd => cd.c.Debe - cd.c.Haber)
                })
            .ToList();
        }
        CtaCte cta;
        public CtaCte GetCtaCtePorId(int id)
        {
            try
            {
                ////var lista = _context.CtaCtes.Include(c => c.Cliente)
                ////    .Where(c => c.ClienteId == id);
                //return _context.CtaCtes.Include(c => c.Cliente)
                //    .GroupBy(c => c.Cliente.Id)
                //    .SingleOrDefault(c => c.Key == id);
                return _context.CtaCtes.Include(c=>c.Cliente)
                    .SingleOrDefault(c=>c.ClienteId== id);
            }
            catch (Exception)
            {

                throw;
            }
        }

            //    //try
            //    //{
            //    //    decimal saldoTotal = 0;
            //    //    var lista = _context.CtaCtes.Include(c => c.Cliente).Where(c => c.Cliente.Nombre == nombre);
            //    //    foreach (var c in lista)
            //    //    {
            //    //        saldoTotal += c.Debe;
            //    //        saldoTotal -= c.Haber;

            //    //    }
            //    //    foreach (var c in lista)
            //    //    {
            //    //        cta= new CtaCte
            //    //        {
            //    //            Saldo = saldoTotal,
            //    //            CtaCteId = c.CtaCteId,
            //    //            FechaMovimiento = c.FechaMovimiento,
            //    //            Debe = c.Debe,
            //    //            Haber = c.Haber,
            //    //            Cliente = c.Cliente,
            //    //            ClienteId = c.ClienteId
            //    //        };
            //    //            break;

            //    //    }
            //    //    return cta;
            //    //}



            //    //catch (Exception )
            //    //{

            //    //    throw;
            //    //}
            //}

            //private List<CtaCteListDto> lista;
            public List<CtaCteListDto> GetCtaCtes()
        {
            var listaCtas=_context.CtaCtes
                .Include(c=>c.Cliente)
                .GroupBy(c=>c.Cliente.Id, c=> new { c, c.Cliente})
                .OrderBy(c=>c.Key)
                .Select(c=>new CtaCteListDto() 
                {
                    ClienteId=c.Key,
                    Cliente=c.FirstOrDefault(cd=>cd.Cliente.Id==c.Key).Cliente.Nombre,
                    Total=c.Sum(cd=>cd.c.Debe-cd.c.Haber)
                })
            .ToList();
            return listaCtas;


            //var lista=new List<CtaCteListDto>();
            //foreach (var grupo in listaCtas)
            //{
            //    var registro = new CtaCteListDto
            //    {
            //        Cliente = grupo.Key,
            //        Total = grupo.Sum(x => x.Debe - x.Haber),
            //        ClienteId=grupo.Key,

            //    };
            //    lista.Add(registro);
            //}

        }

        public List<CtaCte> GetCtaCtes(int id)
        {
            try
            {
                return _context.CtaCtes.Include(c=>c.Cliente)
                    .Include(c=>c.Cliente.Pais)
                    .Include(c => c.Cliente.Ciudad)
                    .Where(c=>c.ClienteId== id).OrderBy(c => c.FechaMovimiento).ToList();
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

                //using (var dbContextTransaction=_context.Database.BeginTransaction()) 
                //{
                //    //_context.CtaCtes.Include(c=>c.Cliente).
                //}
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Agregar(CtaCte ctaCte)
        {
            _context.CtaCtes.Add(ctaCte);
        }

        public bool Existe(CtaCte ctaCte)
        {
            try
            {
                if (ctaCte.CtaCteId==0)
                {
                    return _context.CtaCtes.Any(c=>c.ClienteId == ctaCte.ClienteId);
                }
                return _context.CtaCtes.Any(c=>c.ClienteId==ctaCte.ClienteId && c.CtaCteId!=ctaCte.CtaCteId);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
