using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IAdminService
    {
        List<admin> GetList();

        void AdminAdd(admin admin);

        admin GetByID(int id);

        void AdminDelete(admin admin);

        void AdminUpdate(admin admin);

    }
}
