

namespace API.Dtos
{
    public class ProveedorDto
    {
        public int Id{get;set;}
        public int NitProveedor { get; set; }
        public string Nombre { get; set; }
        public int TipoPersonaIdFk { get; set; }
        public TipoPersonaDto TipoPersona { get; set; }
        public int MunicipioIdFk { get; set; }
        public MunicipioDto Municipio { get; set; }
    }
}