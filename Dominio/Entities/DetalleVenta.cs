

namespace Dominio.Entities;

public class DetalleVenta : BaseEntity
{
    public int VentaIdFk { get; set; }
    public Venta Venta { get; set; }
    public int InventarioIdFk { get; set; }
    public Inventario Inventario { get; set; }
    public int TallaIdFk { get; set; }
    public Talla Talla { get; set; }
    public string Cantidad { get; set; }
    public int ValorUnitario { get; set; }
}
 