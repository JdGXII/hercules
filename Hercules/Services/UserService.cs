using Hercules.DataAccess.DAOs;
using Hercules.Factories;
using Hercules.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hercules.Services
{
    public class UserService
    {
        private DAOFactory _daoFactory;
        private UserDAO _userDao;

        public UserService()
        {
            _daoFactory = new DAOFactory();
            _userDao = (UserDAO)_daoFactory.GetUserDAO();
        } 
        
        public int AddUser(User newUser)
        {
            
            return _userDao.Create(newUser);
            
        }

        public int UpdateUser(User toBeUpdate) {
           

            return _userDao.Update(toBeUpdate);
        }

        public User GetUser(int userId)
        {
            return (User)_userDao.RetrieveOne(userId);
        }

         
    }
}
