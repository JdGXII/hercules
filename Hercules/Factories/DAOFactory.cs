using Hercules.DataAccess.DAOs;
using Hercules.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hercules.Factories
{
    public class DAOFactory
    {
        public ICrudable GetUserDAO()
        {
            return new UserDAO();
        }

        public ICrudable GetCasoDAO()
        {
            return new CasoDAO();
        }

        public ICrudable GetTecnicoDAO()
        {
            return new TecnicoDAO();
        }
    }
}
