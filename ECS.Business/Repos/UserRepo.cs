using ECS.DataAccess;
using ECS.DataAccess.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECS.Business
{
    /// <summary>
    /// Users repository
    /// </summary>
    public class UserRepo : IUserRepo
    {
        #region Private Members

        private ApplicationContext _dc;

        #endregion

        #region Public Properties

        /// <summary>
        /// Username of user entity
        /// </summary>
        public string Username { get; set; }

        #endregion

        #region Ctors..

        /// <summary>
        /// 
        /// </summary>
        public UserRepo()
        {
            _dc = new ApplicationContext();
        }

        #endregion

        #region Get Methods

        /// <summary>
        /// Get all users
        /// </summary>
        /// <returns>List of users  <see cref="List{User}"/></returns>
        public List<User> GetAll()
        {
            // SELECT * FROM Users
            return _dc.Users.ToList();
        }

        /// <summary>
        /// Get user by its Id
        /// </summary>
        /// <param name="userId">User Id</param>
        /// <returns>User entity</returns>
        public User? GetUser(int userId) // 1, 2 , 5
        {

            return _dc.Users.Find(userId);
        }

        public List<FullNameVM> GetFullNames()
        {
            var Query =
                from u in _dc.Users
                select new FullNameVM()
                {
                    Id = u.Id,
                    FullName = u.FirstName + " " + u.LastName
                };

            return Query.ToList();
        }

        #endregion

        #region Insert Methods

        public int Save(User user)
        {
            _dc.Users.Add(user);
            _dc.SaveChanges();

            return user.Id;
        }

        public int Update(User user)
        {
            _dc.Users.Update(user);
            _dc.SaveChanges();

            return user.Id;
        }

        #endregion

        #region Delete Methods

        public void Delete(User user)
        {
            _dc.Users.Remove(user);
            _dc.SaveChanges();
        }

        public void Delete(int userId)
        {
            var delUser = _dc.Users.Find(userId);

            if (delUser != null)
            {
                _dc.Users.Remove(delUser);
                _dc.SaveChanges();
            }
        }
        #endregion

    }
}