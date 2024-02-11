using Dex.Entities;

namespace RelTransCustomer.Application.Contracts.Repositories;

public interface IDesignGARepositoryAsync : IGenericRepositoryAsync<DesignGa>
{
    Task<IEnumerable<DesignGa>> GetAll(string accNo);
    Task<DesignGa> Get(int id);
    Task<DesignGa> Update(DesignGa entity);
}
