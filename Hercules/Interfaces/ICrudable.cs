using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hercules.Interfaces
{
    public interface ICrudable
    {
        int Create(Object toBeCreated);

        int Delete(Object toBeDeleted);

        int Update(Object toBeUpdated);

        Object RetrieveOne(Object toBeRetrieved);

        ICollection<Object> RetrieveAll(); 

    }
}
