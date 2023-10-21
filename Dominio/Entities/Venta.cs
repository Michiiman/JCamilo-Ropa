

namespace Dominio.Entities;

public class Venta : BaseEntity
{
    public DateOnly Fecha { get; set; }
    public int EmpleadoIdFk { get; set; }
    public Empleado Empleado { get; set; }
    public int ClienteIdFk { get; set; }
    public Cliente Cliente { get; set; }
    public int FormaPagoIdFk { get; set; }
    public FormaPago FormaPago { get; set; }

    //collections
    public ICollection<DetalleVenta> DetalleVentas{get;set;}

}
