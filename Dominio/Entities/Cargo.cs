

namespace Dominio.Entities;

public class Cargo : BaseEntity
{
    public string Descripcion { get; set; }
    public int SueldoBase { get; set; }

    //Collections
    public ICollection<Empleado> Empleados{get;set;}
}
