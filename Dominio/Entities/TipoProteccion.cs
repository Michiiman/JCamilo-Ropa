
namespace Dominio.Entities;

public class TipoProteccion : BaseEntity
{
    public string Descripcion { get; set; }

    //Collections
    public ICollection<Prenda> Prendas { get; set; }

}
