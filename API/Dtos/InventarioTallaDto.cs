

namespace API.Dtos
{
    public class InventarioTallaDto
    {
        public int Id{get;set;}
        public int InventarioIdFk { get; set; }
        public InventarioDto Inventario { get; set; }
        public int TallaIdFk { get; set; }
        public TallaDto Talla { get; set; }
        public string Cantidad { get; set; }
    }
}