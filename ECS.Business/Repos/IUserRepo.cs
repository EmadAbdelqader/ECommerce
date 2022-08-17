using ECS.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECS.Business
{
    public interface IUserRepo
    {
        User? GetUser(int userId);

        List<User> GetAll();

        string GetUserName();

        int Save(User user);

        int Update(User user);

        void Delete(int userId);
    }
}
