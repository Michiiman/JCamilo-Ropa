

namespace API.Dtos
{
    public class DetalleOrdenDto
    {
        public int Id{get;set;}
        public string Nombre { get; set; }
        public int CargoIdFk { get; set; }
        public CargoDto Cargo { get; set; }
        public DateOnly FechaIngreso { get; set; }
        public int MunicipioIdFk { get; set; }
        public MunicipioDto Municipio { get; set; }
    }
}