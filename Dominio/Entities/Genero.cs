
namespace Dominio.Entities;

public class Genero : BaseEntity
{
    public string Descripcion { get; set; }

    //Collections
    public ICollection<Prenda> Prendas{get;set;}

}
