

namespace Dominio.Entities;

public class Pais : BaseEntity
{
    public string Nombre { get; set; }

    //Collections 
    public ICollection<Departamento> Departamentos { get; set; }
}
