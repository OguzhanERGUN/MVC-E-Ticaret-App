using BusinessLayer2.Concreate;
using DataAccessLayer2.EntityFramework;
using EntityLayer2.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Course_Second.Controllers
{
    public class MessagesssController : Controller
    {
        // GET: Messagesss

        MessagesssManager cm = new MessagesssManager(new EFMessagesssDal());

        public ActionResult Inbox()
        {
            var messageList = cm.GetListInbox();
            return View(messageList);
        }
        public ActionResult SendBox()
        {
            var messagelist = cm.GetListSenbox();
            return View(messagelist);
        }
        public ActionResult GetInboxMessagesssDetail(int id)
        {
            var values = cm.GetByID(id);
            return View(values);
        }
        [HttpGet]
        public ActionResult NewMessagesss()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewMessagesss(Messagesss messagesss)
        {
            return View();
        }
    }
}