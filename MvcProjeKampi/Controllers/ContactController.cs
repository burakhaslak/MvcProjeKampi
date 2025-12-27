using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact

        ContactManager cm = new ContactManager(new EfContactDal());

        Context c = new Context();

        ContactValidator cv = new ContactValidator();
        public ActionResult Index()
        {
            var contactValues = cm.GetList();
            return View(contactValues);
        }

        public ActionResult GetContactDetails(int id)
        {
            var contactValues= cm.GetByID(id);
            return View(contactValues);
        }

        public PartialViewResult ContactGelenKutusu()
        {
            return PartialView();
        }

        public PartialViewResult MessageListMenu()
        {
            return PartialView();
        }
    }
}