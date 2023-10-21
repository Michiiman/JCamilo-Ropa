
namespace Dominio.Entities;

public class InsumoProveedor
{
    public int InsumoIdFk { get; set; }
    public Insumo Insumo { get; set; }
    public int ProveedorIdFk { get; set; }
    public Proveedor Proveedor { get; set; }

}
