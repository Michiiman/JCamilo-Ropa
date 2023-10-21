

namespace Dominio.Entities;

public class Cliente : BaseEntity
{
    public string Nombre { get; set; }
    public int TipoPersonaIdFk { get; set; }
    public TipoPersona TipoPersona { get; set; }
    public DateOnly FechaRegistro { get; set; }
    public int MunicipioIdFk { get; set; }
    public Municipio Municipio { get; set; }

    //Collections
    public ICollection<Venta> Ventas { get; set; }
    public ICollection<Orden> Ordenes { get; set; }
}
