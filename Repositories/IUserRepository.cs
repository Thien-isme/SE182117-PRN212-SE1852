using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BussinessObject;
namespace Repositories
{
    public interface IUserRepository
    {
        List<User> GetAllUser();
    }
}
