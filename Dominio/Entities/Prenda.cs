

namespace Dominio.Entities;

public class Prenda : BaseEntity
{
    public string Nombre { get; set; }
    public int ValorUnitCop { get; set; }
    public int ValorUnitUsd { get; set; }
    public int EstadoIdFk { get; set; }
    public Estado Estado { get; set; }
    public int TipoProteccionIdFk { get; set; }
    public TipoProteccion TipoProteccion { get; set; }
    public int GeneroIdFk { get; set; }
    public Genero Genero { get; set; }

    //Collections
    public ICollection<DetalleOrden> DetalleOrdenes { get; set; }
    public ICollection<Inventario> Inventarios { get; set; }
    public ICollection<InsumoPrenda> InsumoPrendas { get; set; }


}
