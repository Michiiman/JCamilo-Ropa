

namespace API.Dtos
{
    public class InsumoDto
    {
        public int Id{get;set;}
        public string Nombre { get; set; }
        public int ValorUnitario { get; set; }
        public int StockMin { get; set; }
        public int StockMax { get; set; }
    }
}