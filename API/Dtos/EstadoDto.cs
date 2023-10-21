

namespace API.Dtos
{
    public class EstadoDto
    {
        public int Id{get;set;}
        public string Descripcion { get; set; }
        public int TipoEstadoIdFk { get; set; }
        public TipoEstadoDto TipoEstado { get; set; }
    }
}