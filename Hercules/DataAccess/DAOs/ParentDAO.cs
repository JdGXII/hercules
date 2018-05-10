using Hercules.DataAccess.DBContexts;

namespace Hercules.DataAccess.DAOs
{
    public abstract class ParentDAO
    {
        protected HerculesDevelopmentDBContext _developmentDb;

        public ParentDAO()
        {
            _developmentDb = new HerculesDevelopmentDBContext();
        }
    }
}
