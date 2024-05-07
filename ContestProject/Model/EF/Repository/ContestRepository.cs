using ContestProject.Model.EF.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContestProject.Model.EF.Repository
{
    public class ContestRepository
    {
        private readonly ContestDbContext _dbContext;
        public ContestRepository(ContestDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<Contest>> GetContests() => await _dbContext.Contests.ToListAsync();
       
    }
}
