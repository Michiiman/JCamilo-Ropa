using Dominio.Entities;
using Dominio.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistencia;

namespace Aplicacion.Repository;
public class InventarioTallaRepository : GenericRepo<InventarioTalla>, IInventarioTalla
{
    private readonly ApiContext _context;

    public InventarioTallaRepository(ApiContext context) : base(context)
    {
        _context = context;
    }
    public override async Task<IEnumerable<InventarioTalla>> GetAllAsync()
    {
        return await _context.InventarioTallas
            .Include(p=>p.Talla)
            .Include(p=>p.Inventario)
            .ToListAsync();
    }

    public override async Task<InventarioTalla> GetByIdAsync(int id)
    {
        return await _context.InventarioTallas
            .Include(p=>p.Talla)
            .Include(p=>p.Inventario)
            .FirstOrDefaultAsync(p => p.Id == id);
    }
    public override async Task<(int totalRegistros, IEnumerable<InventarioTalla> registros)> GetAllAsync(int pageIndez, int pageSize, string search)
    {
        var query = _context.InventarioTallas as IQueryable<InventarioTalla>;

        if (!string.IsNullOrEmpty(search))
        {
            query = query.Where(p => p.Cantidad.ToLower().Contains(search));
        }

        query = query.OrderBy(p => p.Id);
        var totalRegistros = await query.CountAsync();
        var registros = await query
            .Skip((pageIndez - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();

        return (totalRegistros, registros);
    }
}