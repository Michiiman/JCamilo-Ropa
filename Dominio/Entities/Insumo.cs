
namespace Dominio.Entities;

public class Insumo : BaseEntity
{
    public string Nombre { get; set; }
    public int ValorUnitario { get; set; }
    public int StockMin { get; set; }
    public int StockMax { get; set; }

    //Collections
    public ICollection<InsumoPrenda> InsumoPrendas { get; set; }
    public ICollection<InsumoProveedor> InsumoProveedores { get; set; }
    public ICollection<Proveedor> Proveedores { get; set; }

}
