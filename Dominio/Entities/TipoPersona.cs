
namespace Dominio.Entities;

public class TipoPersona : BaseEntity
{
    public string Nombre { get; set; }

    //collections
    public ICollection<Proveedor> Proveedores { get; set; }
    public ICollection<Cliente> Clientes { get; set; }
}
