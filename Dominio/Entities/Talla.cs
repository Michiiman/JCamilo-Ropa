
namespace Dominio.Entities;

public class Talla : BaseEntity
{
    public string Descripcion { get; set; }

    //Collections
    public ICollection<Inventario> Inventarios{get;set;}
    public ICollection<InventarioTalla> InventarioTallas{get;set;}
    public ICollection<DetalleVenta> DetalleVentas{get;set;}

}
