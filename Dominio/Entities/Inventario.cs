
namespace Dominio.Entities;

public class Inventario : BaseEntity
{
    public string CodInventario { get; set; }
    public int PrendaIdFk { get; set; }
    public Prenda Prenda { get; set; }
    public int ValorVtaCop { get; set; }
    public int ValorVtaUsd { get; set; }

    //Collections
    public ICollection<InventarioTalla> InventarioTallas { get; set; }
    public ICollection<DetalleVenta> DetalleVentas { get; set; }

}
