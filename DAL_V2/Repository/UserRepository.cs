using DAL_V2.Entity;
using DAL_V2.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DAL_V2.Repository
{
    public class UserRepository : BaseRepository<User>,  IUserRepository
    {
             
    }
}