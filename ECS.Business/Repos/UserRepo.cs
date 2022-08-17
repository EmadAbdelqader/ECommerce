using ECS.DataAccess;
using ECS.DataAccess.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECS.Business
{
    public class UserRepo : IUserRepo
    {
        #region Private Members

        private ApplicationContext _dc;

        #endregion

        #region Ctors..

        public UserRepo()
        {
            _dc = new ApplicationContext();
        }

        #endregion

        #region Get Methods

        public List<User> GetAll()
        {
            // SELECT * FROM Users
            return _dc.Users.ToList();
        }

        public User? GetUser(int userId) // 1, 2 , 5
        {

            return _dc.Users.Find(userId);
        }

        public string GetUserName()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Insert Methods

        public int Save(User user)
        {
            throw new NotImplementedException();
        }

        public int Update(User user)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Delete Methods

        public void Delete(int userId)
        {

        }

        #endregion

    }
}