using Neptuno2022EF.Datos.Interfaces;
using Neptuno2022EF.Entidades.Dtos.Ciudad;
using Neptuno2022EF.Entidades.Dtos.Proveedor;
using Neptuno2022EF.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Neptuno2022EF.Datos.Repositorios
{
    public class RepositorioProveedores:IRepositorioProveedores
    {
        private readonly NeptunoDbContext _context;

        public RepositorioProveedores(NeptunoDbContext context)
        {
            _context = context;
        }

        public void Agregar(Proveedor proveedor)
        {
            try
            {
                _context.Proveedores.Add(proveedor);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Borrar(int id)
        {
            try
            {
                var proveedorInDb = GetProveedorPorId(id);
                if (proveedorInDb == null)
                {
                    throw new Exception("Registro borrado por otro usuario");
                }
                _context.Entry(proveedorInDb).State = EntityState.Deleted;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Editar(Proveedor proveedor)
        {
            try
            {
                var proveedorInDb = GetProveedorPorId(proveedor.Id);
                if (proveedorInDb == null)
                {
                    throw new Exception("Registro borrado por otro usuario");
                }
                _context.Entry(proveedor).State = EntityState.Modified;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool EstaRelacionado(Proveedor proveedor)
        {
            try
            {
                return _context.Productos.Any(p => p.ProveedorId == proveedor.Id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Existe(Proveedor proveedor)
        {
            try
            {
                if (proveedor.Id == 0)
                {
                    return _context.Proveedores.Any(c => c.Nombre == proveedor.Nombre);
                }
                return _context.Proveedores.Any(c => c.Nombre == proveedor.Nombre && c.Id != proveedor.Id);

            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<ProveedorListDto> Filtrar(Func<Proveedor, bool> predicado, int cantidad)
        {
            return _context.Proveedores.Include(c => c.Pais)
                .Include(c => c.Ciudad)
                .Where(predicado)
                .Select(c => new ProveedorListDto
                {
                    ProveedorId = c.Id,
                    NombreProveedor = c.Nombre,
                    Pais = c.Pais.NombrePais,
                    Ciudad = c.Ciudad.NombreCiudad
                }).ToList();
        }

        public Proveedor GetProveedorPorId(int id)
        {
            try
            {
                return _context.Proveedores.Include(c => c.Pais)
                    .Include(c => c.Ciudad)
                    .SingleOrDefault(c => c.Id == id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<ProveedorListDto> GetProveedores()
        {
            return _context.Proveedores.Include(c => c.Pais)
                .Include(c => c.Ciudad).Select(c => new ProveedorListDto
                {
                    ProveedorId = c.Id,
                    NombreProveedor = c.Nombre,
                    Pais = c.Pais.NombrePais,
                    Ciudad = c.Ciudad.NombreCiudad
                }).ToList();
        }

        public List<ProveedorListDto> GetProveedores(int paisId, int ciudadId)
        {
            try
            {
                return _context.Proveedores.Include(c => c.Pais)
                    .Include(c => c.Ciudad)
                    .Where(c => c.PaisId == paisId && c.CiudadId == ciudadId)
                    .Select(c => new ProveedorListDto
                    {
                        ProveedorId = c.Id,
                        NombreProveedor = c.Nombre,
                        Pais = c.Pais.NombrePais,
                        Ciudad = c.Ciudad.NombreCiudad
                    }).ToList();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int GetCantidad(Func<Proveedor, bool> predicado)
        {
            return _context.Proveedores.Count(predicado);
        }

        public int GetCantidad()
        {
            return _context.Proveedores.Count();
        }

        public List<ProveedorListDto> Filtrar(Func<Proveedor, bool> predicado, int cantidad, int pagina)
        {
            return _context.Proveedores.Include(p => p.Pais).Include(p => p.Ciudad)
                .Where(predicado)
                .OrderBy(p => p.Nombre)
                .Skip(cantidad * (pagina - 1))
                .Take(cantidad)
                .Select(c => new ProveedorListDto
                {
                    ProveedorId = c.Id,
                    NombreProveedor = c.Nombre,
                    Pais = c.Pais.NombrePais,
                    Ciudad = c.Ciudad.NombreCiudad
                }).ToList();
        }

        public List<ProveedorListDto> GetProveedorPorPagina(int cantidad, int pagina)
        {
            return _context.Proveedores.Include(p => p.Pais).Include(p => p.Ciudad)
                .OrderBy(p => p.Nombre)
                .Skip(cantidad * (pagina - 1))
                .Take(cantidad)
                .Select(c => new ProveedorListDto
                {
                    ProveedorId = c.Id,
                    NombreProveedor = c.Nombre,
                    Pais = c.Pais.NombrePais,
                    Ciudad = c.Ciudad.NombreCiudad
                }).ToList();
        }

        public List<ResumenProveedorListDto> GetResumenProveedores()
        {
            var listaProd=_context.Productos
                .Include(p=>p.Proveedor)
                .GroupBy(c=>c.Proveedor.Nombre)
                .ToList();
            var listaResumen = new List<ResumenProveedorListDto>();
            foreach (var grupo in listaProd)
            {
                var registro = new ResumenProveedorListDto
                {
                    NombreProveedor = grupo.Key,
                    CantProductos = grupo.Sum(x => x.Stock)
                };
                listaResumen.Add(registro);
            }
            return listaResumen;
        }
    }
}
