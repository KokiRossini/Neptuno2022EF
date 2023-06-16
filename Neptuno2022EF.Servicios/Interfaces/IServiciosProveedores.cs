using Neptuno2022EF.Entidades.Dtos.Proveedor;
using Neptuno2022EF.Entidades.Entidades;
using System;
using System.Collections.Generic;

namespace Neptuno2022EF.Servicios.Interfaces
{
    public interface IServiciosProveedores
    {
        void Borrar(int id);
        bool EstaRelacionado(Proveedor proveedor);
        bool Existe(Proveedor proveedor);
        void Guardar(Proveedor proveedor);
        Proveedor GetProveedorPorId(int id);
        List<ProveedorListDto> GetProveedores();
        List<ProveedorListDto> GetProveedores(int paisId, int ciudadId);
        List<ProveedorListDto> Filtrar(Func<Proveedor, bool> predicado, int cantidad, int pagina);
        int GetCantidad(Func<Proveedor, bool> predicado);
        int GetCantidad();
        List<ProveedorListDto> GetProveedorPorPagina(int cantidad, int pagina);
        List<ResumenProveedorListDto> GetResumenProveedores();
        List<ProveedorListDto> GetDetalleProveedor(int proveedorId);
    }
}
