using ContestProject.Model.EF.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContestProject.Model.EF.Repository
{
    public class RoleRepository
    {
        private readonly ContestDbContext _dbContext;
        public RoleRepository(ContestDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<Role>> GetRoles() => await _dbContext.Roles.Where(c=> c.Name != "Организатор").ToListAsync();
        
    }
}
