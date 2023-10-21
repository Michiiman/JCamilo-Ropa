

namespace API.Dtos
{
    public class ClienteDto
    {
        public int Id{get;set;}
        public string Nombre { get; set; }
        public int TipoPersonaIdFk { get; set; }
        public TipoPersonaDto TipoPersona { get; set; }
        public DateOnly FechaRegistro { get; set; }
        public int MunicipioIdFk { get; set; }
        public MunicipioDto Municipio { get; set; }

    }
}