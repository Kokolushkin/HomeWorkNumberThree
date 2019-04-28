using System;
using System.Threading.Tasks;

namespace  HomeWorkNumberThree.Services.Interfaces
{
    public interface IUserInfoService
    {
        Task<User> GetById(Guid id);
    }
}