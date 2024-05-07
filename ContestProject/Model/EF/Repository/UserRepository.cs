using ContestProject.Model.EF.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContestProject.Model.EF.Repository
{
    public class UserRepository
    {
        private readonly ContestDbContext _dbContext;
        public UserRepository(ContestDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<User> GetUser(string email, string password) => await _dbContext.Users.Include(c => c.Role).FirstOrDefaultAsync(c => c.Email == email && c.Password == password);
        public async Task AddUser(string email, string password, string gender, string fullname, string phone, int role)
        {
            _dbContext.Users.Add(new User()
            {
                Email = email,
                Password = password,
                Gender = gender,
                FullName = fullname,
                Phome = phone,
                RoleId = role
            });
            await _dbContext.SaveChangesAsync();
        }
        public async Task<bool> ExistUser(string email)
        {
            return await _dbContext.Users.AnyAsync(c => c.Email == email);
        }
        public async Task<List<User>> GetUsers() => await _dbContext.Users.ToListAsync();
        public async Task<List<User>> GetUserNoOrg() => await _dbContext.Users.Where(c => c.Role.Name != "Организатор").ToListAsync();
    }
}
