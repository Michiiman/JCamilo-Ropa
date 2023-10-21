
namespace Dominio.Entities;

public class Departamento : BaseEntity
{
    public string Nombre { get; set; }
    public int PaisIdFk { get; set; }
    public Pais Pais { get; set; }

    //Collections
    public ICollection<Municipio> Municipios { get; set; }
    
}
 