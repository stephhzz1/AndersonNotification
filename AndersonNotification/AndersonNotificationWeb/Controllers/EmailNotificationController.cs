using AndersonNotificationFunction;
using AndersonNotificationModel;
using System;
using System.Net.Mail;
using System.Web.Mvc;

namespace AndersonNotificationWeb.Controllers
{
    public class EmailNotificationController : BaseController
    {
        private IFEmailNotification _iFEmailNotification;
        public EmailNotificationController(IFEmailNotification iFEmailNotification)
        {
            _iFEmailNotification = iFEmailNotification;
        }

        #region Create
        [HttpGet]
        public ActionResult Create()
        {
            return View(new EmailNotification());
        }

        [HttpPost]
        public ActionResult Create(EmailNotification notification, string Sender, string Password)
        {
            SmtpClient smtpClient = new SmtpClient();

            try
            {
                var createdNotification = _iFEmailNotification.Create(CredentialId, notification);
                smtpClient.Credentials = new System.Net.NetworkCredential(Sender, Password);
                smtpClient.Send(from: notification.Sender, recipients: notification.Receiver, subject: notification.Subject, body: notification.Body);
                if (ModelState.IsValid)
                {
                    TempData["message"] = "Email has been sent, successfully!";
                }
                return RedirectToAction("Create");
            }
            catch (Exception)
            {
                if (ModelState.IsValid)
                {
                    TempData["message"] = "Opps! Something went wrong. Please, try again.";
                }
                return RedirectToAction("Create");
            }
        }

        #endregion

        #region Read
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Read()
        {
            return Json(_iFEmailNotification.Read("Name"));
        }
        #endregion

        #region Update
        #endregion

        #region Delete
        #endregion

        #region Other Function
        #endregion
    }
}