
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Classroom_supplies.Model;
using ClassSupplies.Data;
using Microsoft.EntityFrameworkCore;

public class ClassroomSupplyService
{
    private readonly ClassSuppliesContext _context;

    public ClassroomSupplyService(ClassSuppliesContext context)
    {
        _context = context;
    }

    public async Task<List<ClassroomSupply>> GetSuppliesAsync()
    {
        return await _context.ClassroomSupplies.ToListAsync();
    }

    public async Task<ClassroomSupply> GetSupplyAsync(int Id)
    {
        return await _context.ClassroomSupplies.FirstOrDefaultAsync(s => s.Id == Id);
    }

    public async Task CreateSupplyAsync(ClassroomSupply supply)
    {
        _context.ClassroomSupplies.Add(supply);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateSupplyAsync(ClassroomSupply supply)
    {
        _context.ClassroomSupplies.Update(supply);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteSupplyAsync(int Id)
    {
        var supply = await GetSupplyAsync(Id);
        if (supply != null)
        {
            _context.ClassroomSupplies.Remove(supply);
            await _context.SaveChangesAsync();
        }
    }
}
