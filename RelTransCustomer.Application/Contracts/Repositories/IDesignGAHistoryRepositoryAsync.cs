using Dex.Entities;

namespace RelTransCustomer.Application.Contracts.Repositories;

public interface IDesignGAHistoryRepositoryAsync : IGenericRepositoryAsync<DesignGaHistory>
{
    Task<IEnumerable<DesignGaHistory>> GetDesignGaHistoriesAsync(string accNo);
    Task AddDesignGAHistory(DesignGaHistory designGaHistory);
}
