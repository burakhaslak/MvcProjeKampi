using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AdminManager : IAdminService
    {

        IAdminDal _adminDal;

        public AdminManager(IAdminDal adminDal)
        {
            _adminDal = adminDal;
        }
        public void AdminAdd(admin admin)
        {
            _adminDal.Insert(admin);
        }

        public void AdminDelete(admin admin)
        {
            throw new NotImplementedException();
        }

        public void AdminUpdate(admin admin)
        {
            _adminDal.Update(admin);
        }

        public admin GetByID(int id)
        {
            return _adminDal.Get(x => x.AdminID == id);
        }

        public List<admin> GetList()
        {
            return _adminDal.List();
        }
    }
}
