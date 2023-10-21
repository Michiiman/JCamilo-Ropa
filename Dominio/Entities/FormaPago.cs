
namespace Dominio.Entities;

public class FormaPago : BaseEntity
{
    public string Descripcion { get; set; }

    //Collections
    public ICollection<Venta> Ventas { get; set; }

}
