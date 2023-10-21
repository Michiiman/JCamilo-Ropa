

namespace API.Dtos
{
    public class InsumoPrendaDto
    {   
        public int Id{get;set;}
        public int InsumoIdFk { get; set; }
        public InsumoDto Insumo { get; set; }
        public int PrendaIdFk { get; set; }
        public PrendaDto Prenda { get; set; }
        public string Cantidad { get; set; }
    }
}