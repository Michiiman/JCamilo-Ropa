


namespace Dominio.Entities;

public class TipoEstado : BaseEntity
{
    public string Descripcion { get; set; }

    //Collections
    public ICollection<Estado> Estados { get; set; }
}
