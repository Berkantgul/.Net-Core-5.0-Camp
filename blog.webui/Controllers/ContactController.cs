using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blog.business.Concrete;
using blog.data.Concrete;
using blog.entity.Concrete;
using blog.webui.Models;
using Microsoft.AspNetCore.Mvc;

namespace blog.webui.Controllers
{
    public class ContactController : Controller
    {
        ContactManager _contactManager = new ContactManager(new EfCoreContactRepository());


        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(ContactModel model)
        {
            if (ModelState.IsValid)
            {
                var contact = new Contact()
                {
                    UserName = model.UserName,
                    Email = model.Email,
                    ContactSubject = model.ContactSubject,
                    ContactMessage = model.ContactMessage,
                    ContactStatus = true,
                    ContactDate = (DateTime)DateTime.Now
                };
                _contactManager.AddContact(contact);
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}