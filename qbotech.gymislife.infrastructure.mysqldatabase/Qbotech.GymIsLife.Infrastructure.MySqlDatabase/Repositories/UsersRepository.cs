using Microsoft.EntityFrameworkCore;
using Qbotech.GymIsLife.Core.Domain.Entities;
using Qbotech.GymIsLife.Core.Domain.Interfaces;
using Qbotech.GymIsLife.Infrastructure.MySqlDatabase.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qbotech.GymIsLife.Infrastructure.MySqlDatabase.Repositories
{
    public class UsersRepository : IUsersRepository
    {
        private readonly GILDatabaseContext _gILDatabaseContext;

        public UsersRepository(GILDatabaseContext gILDatabaseContext)
        {
            _gILDatabaseContext = gILDatabaseContext;
        }

        public async Task<IEnumerable<Users>> GetAll()
        {
            return await _gILDatabaseContext.Users.ToListAsync();

        }
    }
}
