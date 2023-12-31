

namespace API.Dtos
{
    public class PrendaDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int ValorUnitCop { get; set; }
        public int ValorUnitUsd { get; set; }
        public int EstadoIdFk { get; set; }
        public EstadoDto Estado { get; set; }
        public int TipoProteccionIdFk { get; set; }
        public TipoProteccionDto TipoProteccion { get; set; }
        public int GeneroIdFk { get; set; }
        public GeneroDto Genero { get; set; }
    }
}