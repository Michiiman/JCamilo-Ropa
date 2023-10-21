
namespace Dominio.Entities;

public class Color : BaseEntity
{
    public string Descripcion { get; set; }

    //Collections
    public ICollection<DetalleOrden> DetalleOrdenes{get;set;}
}
 