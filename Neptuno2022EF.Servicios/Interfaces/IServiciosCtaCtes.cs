using Neptuno2022EF.Entidades.Dtos;
using Neptuno2022EF.Entidades.Dtos.Ciudad;
using Neptuno2022EF.Entidades.Entidades;
using NuevaAppComercial2022.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neptuno2022EF.Servicios.Interfaces
{
    public interface IServiciosCtaCtes
    {
        List<CtaCteListDto> GetCtaCtes();
        void Pagar(Cliente cliente, decimal cantPagando);
        CtaCte GetCtaCtePorId(int ctaCteId);
        List<CtaCte> GetCtaCtes(int clienteId);
        List<CtaCteListDto> Filtrar(Func<CtaCte, bool> predicado);
        void Agregar(CtaCte ctaCte);
        bool Existe(CtaCte ctaCorriente);
    }
}
