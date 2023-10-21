
namespace Dominio.Entities;

public class Orden : BaseEntity
{
    public DateOnly Fecha { get; set; }
    public int EmpleadoIdFk { get; set; }
    public Empleado Empleado { get; set; }
    public int ClienteIdFk { get; set; }
    public Cliente Cliente { get; set; }
    public int EstadoIdFk { get; set; }
    public Estado Estado { get; set; }

    //Collections
    public ICollection<DetalleOrden> DetalleOrdenes { get; set; }

}
