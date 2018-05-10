using Hercules.DataAccess.DAOs;
using Hercules.Factories;
using Hercules.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hercules.Services
{
    public class CasoService
    {
        private DAOFactory _daoFactory;
        private CasoDAO _casoDao;

        public CasoService()
        {
            _daoFactory = new DAOFactory();
            _casoDao = (CasoDAO)_daoFactory.GetCasoDAO();
        }

        public int AddCaso(Caso toBeCreated)
        {
            return _casoDao.Create(toBeCreated);
        }

        public int UpdateCaso(Caso toBeUpdated)
        {
            return _casoDao.Update(toBeUpdated);
        }

        public Caso GetCaso(int casoId)
        {
            return (Caso)_casoDao.RetrieveOne(casoId);
        }
    }
}
