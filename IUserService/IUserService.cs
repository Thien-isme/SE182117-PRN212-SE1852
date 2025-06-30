using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessObject;
namespace Services
{
    public interface IUserService
    {
        List<User> GetAllUser();
    }
}
