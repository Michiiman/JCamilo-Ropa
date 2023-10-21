

namespace API.Dtos
{
    public class DetalleVentaDto
    {
        public int Id{get;set;}
        public int VentaIdFk { get; set; }
        public VentaDto Venta { get; set; }
        public int InventarioIdFk { get; set; }
        public InventarioDto Inventario { get; set; }
        public int TallaIdFk { get; set; }
        public TallaDto Talla { get; set; }
        public string Cantidad { get; set; }
        public int ValorUnitario { get; set; }
    }
}