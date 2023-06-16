using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neptuno2022EF.Entidades.Dtos
{
    public class CtaCteListDto
    {
        public int ClienteId { get; set; }
        public string Cliente { get; set; }
        public decimal Total { get; set; }
    }
}
