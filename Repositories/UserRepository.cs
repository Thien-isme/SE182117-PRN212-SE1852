using BussinessObject;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class UserRepository : IUserRepository
    {
        public List<User> GetAllUser()
        {
            UserDAO userDAO = new UserDAO();
            userDAO.InitializeDataSet();
            return userDAO.GetAllUser();
        }
    }
}
