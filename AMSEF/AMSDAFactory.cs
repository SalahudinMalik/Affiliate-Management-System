using AMSEF.DataLayer;
using AMSModelView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMSEF
{
    public class AMSDAFactory
    {
        AMSDA dbObj;
        public AMSDAFactory()
        {
            dbObj = new AMSDA();
        }

        public bool insert(UserTable obj)
        {
            return dbObj.insert(obj);
        }
        public List<AMSModel> search(int Rid)
        {
            return dbObj.Search(Rid);
        }
        public List<AMSModel> GetAll()
        {
            return dbObj.getAll();
        }

    }
}
