using Hercules.Interfaces;
using Hercules.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hercules.DataAccess.DAOs
{
    public class UserDAO : ParentDAO, ICrudable
    {
        public int Create(object toBeCreated)
        {
            throw new NotImplementedException();
        }

        public int Delete(object toBeDeleted)
        {
            throw new NotImplementedException();
        }

        public ICollection<object> RetrieveAll()
        {
            throw new NotImplementedException();
        }

        public object RetrieveOne(object toBeRetrieved)
        {
            throw new NotImplementedException();
        }

        public int Update(object toBeUpdated)
        {
            throw new NotImplementedException();
        }
    }
}
