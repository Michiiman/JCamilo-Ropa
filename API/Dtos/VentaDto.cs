

namespace API.Dtos
{
    public class VentaDto
    {
        public int Id { get; set; }
        public DateOnly Fecha { get; set; }
        public int EmpleadoIdFk { get; set; }
        public EmpleadoDto Empleado { get; set; }
        public int ClienteIdFk { get; set; }
        public ClienteDto Cliente { get; set; }
        public int FormaPagoIdFk { get; set; }
        public FormaPagoDto FormaPago { get; set; }
    }
}