using Qbotech.GymIsLife.Core.Domain.Entities;

namespace Qbotech.GymIsLife.Core.Domain.Interfaces
{
    public interface IUsersRepository
    {
        Task<IEnumerable<Users>> GetAll();
    }
}