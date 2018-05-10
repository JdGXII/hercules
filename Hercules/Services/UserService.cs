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

        public UserService()
        {
            _daoFactory = new DAOFactory();
        } 
        
        public int AddUser(User newUser)
        {
            UserDAO userDao = (UserDAO)_daoFactory.GetCasoDAO();

            userDao.Create(newUser);
            return 0;
        }
 
    }
}
