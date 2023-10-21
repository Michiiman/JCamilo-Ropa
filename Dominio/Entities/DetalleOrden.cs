
namespace Dominio.Entities;

public class DetalleOrden : BaseEntity
{
    public int OrdenIdFk { get; set; }
    public Orden Orden { get; set; }
    public int PrendaIdFk { get; set; }
    public Prenda Prenda { get; set; }
    public string CantidadProducir { get; set; }
    public int ColorIdFk { get; set; }
    public Color Color { get; set; }
    public string CantidadProducida { get; set; }
    public int EstadoIdFk { get; set; }
    public Estado Estado { get; set; }

}
 