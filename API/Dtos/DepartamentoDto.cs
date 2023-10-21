

namespace API.Dtos
{
    public class DepartamentoDto
    {
        public int Id{get;set;}
        public string Nombre { get; set; }
        public int PaisIdFk { get; set; }
        public PaisDto Pais { get; set; }
    }
}