using Microsoft.EntityFrameworkCore;
using ParkXplore.Core.Entities;
using ParkXplore.Core.Interfaces;
using ParkXplore.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkXplore.Infrastructure.Repositories {
    public class UserRepository : Repository<User>, IUserRepository {
        public UserRepository(AppDbContext context) : base(context) { }

        public async Task<User?> GetByEmailAsync(string email) {
            return await _context.Users.FirstOrDefaultAsync(u => u.Email == email);
        }
    }
}
