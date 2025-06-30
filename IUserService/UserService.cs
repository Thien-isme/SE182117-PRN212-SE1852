using BussinessObject;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository iuserRepository;

        public UserService()
        {
            iuserRepository = new UserRepository();
        }

        public List<User> GetAllUser()
        {
            return iuserRepository.GetAllUser();
            

        }
    }
}
