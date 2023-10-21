
namespace Dominio.Entities;

public class Empleado : BaseEntity
{
    public string Nombre { get; set; }
    public int CargoIdFk { get; set; }
    public Cargo Cargo { get; set; }
    public DateOnly FechaIngreso { get; set; }
    public int MunicipioIdFk { get; set; }
    public Municipio Municipio { get; set; }

    //Collections

    public ICollection<Venta> Ventas { get; set; }
    public ICollection<Orden> Ordenes { get; set; }
}
 