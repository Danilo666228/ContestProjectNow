using ContestProject.Model.EF.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ContestProject.Model.EF.Repository
{
    public class ResultRepository
    {
        private readonly ContestDbContext _dbContext;
        public ResultRepository(ContestDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task AddResult(int userId,int contestId,string result)
        {
            _dbContext.Results.Add(new Result()
            {
                UserId = userId,
                ContestId = contestId,
                ResultContest = result
            });
            await _dbContext.SaveChangesAsync();
        }
        public async Task<List<Result>> GetResultByName(string name)
        {
            return await _dbContext.Results
                .Include(c=> c.User)
                .Include(c=>c.Contest)
                .Where(c=> c.Contest.Name == name)
                .ToListAsync();

        }
        public async Task<List<Result>> GetResults() => await _dbContext.Results.Include(c=> c.User).Include(c=> c.Contest).ToListAsync();
        public async Task Update(string name,string context, string result)
        {
            var user = await _dbContext.Results
                .Include(c=> c.User)
                .Include(c=>c.Contest)
                .FirstOrDefaultAsync(c => c.User.FullName == name && c.Contest.Name == context);
            if(user != null)
            {
                user.ResultContest = result;
                await _dbContext.SaveChangesAsync();
            }

        }
    }
}
