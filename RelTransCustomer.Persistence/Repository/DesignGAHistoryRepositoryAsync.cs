using Dex.Entities;
using Microsoft.EntityFrameworkCore;
using RelTransCustomer.Application.Contracts.Repositories;
using RelTransCustomer.Persistence.Contexts;

namespace RelTransCustomer.Persistence.Repository;

public class DesignGAHistoryRepositoryAsync : GenericRepositoryAsync<DesignGaHistory>, IDesignGAHistoryRepositoryAsync
{
    private readonly DbSet<DesignGaHistory> _designGa;
    private readonly DexDbContext _dbContext;
    public DesignGAHistoryRepositoryAsync(DexDbContext dbContext) : base(dbContext)
    {
        _designGa = dbContext.Set<DesignGaHistory>();
        _dbContext = dbContext;
    }

    public async Task AddDesignGAHistory(DesignGaHistory designGaHistory)
    {
        await AddAsync(designGaHistory);
    }

    public async Task<IEnumerable<DesignGaHistory>> GetDesignGaHistoriesAsync(string accNo)
    {
        var query = from history in _dbContext.DesignGaHistory
                    where _dbContext.DesignGa.Any(ga => ga.AccNo == accNo && ga.Recid == history.GaId)
                    select new DesignGaHistory
                    {
                       Recid = history.Recid,
                       GaId = history.GaId,
                       EventDate = history.EventDate,
                       EventType = history.EventType,
                       Notes = history.Notes,
                       Sender = history.Sender,
                       Recipient = history.Recipient,
                       Copied = history.Copied,
                       Message = history.Message
                    };

        return await query.ToListAsync();
    }
}
