using AMSModelView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMSEF.DataLayer
{
    public class AMSDA
    {
        AMSEntities dbContext;

        public AMSDA()
        {
            dbContext = new AMSEntities();
        }
        public bool insert(UserTable obj)
        {
            dbContext.UserTables.Add(obj);
            return (dbContext.SaveChanges() > 0);


        }
        public List<AMSModel> Search(int id)
        {
             /* return (from l in obj.Car_Table
                    where (l.CA_Status == false)
                    select new ViewModel.CarViewModel
                    {
                        CA_ID = l.CA_ID,
                        CA_RegNo = l.CA_RegNo,
                        CA_Color = l.CA_Color,
                        CA_Company = l.CA_Company,
                        CA_Model = l.CA_Model,
                        CA_Status = l.CA_Status
                    }).ToList(); */
           // return dbContext.UserTables.Where(x => x.Referral_ID == id).ToList();
            return (from l in dbContext.UserTables
                    where (l.Referral_ID == id)
                    select new AMSModel
                    {
                        Referral_ID = l.Referral_ID,
                        Name = l.Name,
                        Phone = l.Phone,
                        Address = l.Address,
                        Email = l.Email,
                        Comm_Level = l.Comm_Level
                    }).ToList();
        }
        public List<AMSModel> getAll()
        {
            return (from l in dbContext.UserTables
                    select new AMSModel
                    {
                        Referral_ID = l.Referral_ID,
                        Name = l.Name,
                        Phone = l.Phone,
                        Address = l.Address,
                        Email = l.Email,
                        Comm_Level = l.Comm_Level
                    }).ToList();
        }
    }
}