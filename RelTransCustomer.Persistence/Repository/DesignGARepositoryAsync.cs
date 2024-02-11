using Dex.Entities;
using Microsoft.EntityFrameworkCore;
using RelTransCustomer.Application.Contracts.Repositories;
using RelTransCustomer.Persistence.Contexts;

namespace RelTransCustomer.Persistence.Repository;

public class DesignGARepositoryAsync : GenericRepositoryAsync<DesignGa>, IDesignGARepositoryAsync
{
    private readonly DbSet<DesignGa> _designGa;
    public DesignGARepositoryAsync(DexDbContext dbContext) : base(dbContext)
    {
        _designGa = dbContext.Set<DesignGa>();
    }

    public async Task<DesignGa> Get(int id)
    {
         return await _designGa.FirstOrDefaultAsync(x => x.Recid == id);
    }

    public async Task<IEnumerable<DesignGa>> GetAll(string accNo)
    {
        return await _designGa.Where(x => x.AccNo == accNo).ToListAsync();
    }

    public async Task<DesignGa> Update(DesignGa entity)
    {
         await UpdateAsync(entity);
        return entity;
    }
}
