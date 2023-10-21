using Dominio.Entities;
using Dominio.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistencia;

namespace Aplicacion.Repository;
public class OrdenRepository : GenericRepo<Orden>, IOrden
{
    private readonly ApiContext _context;

    public OrdenRepository(ApiContext context) : base(context)
    {
        _context = context;
    }
    public override async Task<IEnumerable<Orden>> GetAllAsync()
    {
        return await _context.Ordenes
        .Include(p=>p.Empleado)
        .Include(p=>p.Cliente)
        .Include(p=>p.Estado)
        .ToListAsync();
    }

    public override async Task<Orden> GetByIdAsync(int id)
    {
        return await _context.Ordenes
        .Include(p=>p.Empleado)
        .Include(p=>p.Cliente)
        .Include(p=>p.Estado)
        .FirstOrDefaultAsync(p => p.Id == id);
    }

}