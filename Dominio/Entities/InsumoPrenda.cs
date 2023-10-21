

namespace Dominio.Entities;

public class InsumoPrenda : BaseEntity
{
    public int InsumoIdFk { get; set; }
    public Insumo Insumo { get; set; }
    public int PrendaIdFk { get; set; }
    public Prenda Prenda { get; set; }
    public string Cantidad{get;set;}

}
