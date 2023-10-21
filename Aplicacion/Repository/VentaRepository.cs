using Dominio.Entities;
using Dominio.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistencia;

namespace Aplicacion.Repository;
public class VentaRepository : GenericRepo<Venta>, IVenta
{
    private readonly ApiContext _context;

    public VentaRepository(ApiContext context) : base(context)
    {
        _context = context;
    }
    public override async Task<IEnumerable<Venta>> GetAllAsync()
    {
        return await _context.Ventas
        .Include(p=>p.Empleado)
        .Include(p=>p.Cliente)
        .Include(p=>p.FormaPago)
            .ToListAsync();
    }

    public override async Task<Venta> GetByIdAsync(int id)
    {
        return await _context.Ventas
        .Include(p=>p.Empleado)
        .Include(p=>p.Cliente)
        .Include(p=>p.FormaPago)
        .FirstOrDefaultAsync(p => p.Id == id);
    }

}