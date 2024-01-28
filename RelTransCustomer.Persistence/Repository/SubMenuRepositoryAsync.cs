using RelTransCustomer.Application.Contracts.Repositories;
using RelTransCustomer.Domain.Entities;
using RelTransCustomer.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelTransCustomer.Persistence.Repository
{
    public class SubMenuRepositoryAsync : GenericRepositoryAsync<SubMenu>, ISubMenuRepositoryAsync
    {
        public SubMenuRepositoryAsync(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
