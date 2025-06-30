using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessObject;
namespace DataAccessLayer
{
    
    public class UserDAO
    {

    List<User> users = new List<User>();
        public void InitializeDataSet()
        {
            users.Add(new User() { Name = "Teo", Phone = "0939626055", Email = "teo@gmail.com" });
            users.Add(new User() { Name = "Ty", Phone = "0123456789", Email = "ty@gmail.com" });
            users.Add(new User() { Name = "Bin", Phone = "0987635421", Email = "bin@gmail.com" });
            users.Add(new User() { Name = "Bo", Phone = "0532614987", Email = "bo@gmail.com" });
            users.Add(new User() { Name = "Bẹo", Phone = "0852364179", Email = "beo@gmail.com" });
        }
        public List<User> GetAllUser()
        {
            return users;
        }



    }
}
