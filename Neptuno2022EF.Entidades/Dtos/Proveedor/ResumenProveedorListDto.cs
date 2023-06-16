using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neptuno2022EF.Entidades.Dtos.Proveedor
{
    public class ResumenProveedorListDto
    {
        public int Id { get; set; }
        public string NombreProveedor { get; set; }
        public int CantProductos { get; set; }

    }
}
