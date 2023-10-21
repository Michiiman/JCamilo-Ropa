
namespace Dominio.Entities;

public class InventarioTalla : BaseEntity
{
    public int InventarioIdFk { get; set; }
    public Inventario Inventario { get; set; }
    public int TallaIdFk { get; set; }
    public Talla Talla { get; set; }
    public string Cantidad { get; set; }

}
