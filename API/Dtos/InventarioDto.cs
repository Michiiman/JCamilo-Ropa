using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class InventarioDto
    {
        public int Id{get;set;}
        public string CodInventario { get; set; }
        public int PrendaIdFk { get; set; }
        public PrendaDto Prenda { get; set; }
        public int ValorVtaCop { get; set; }
        public int ValorVtaUsd { get; set; }
    }
}