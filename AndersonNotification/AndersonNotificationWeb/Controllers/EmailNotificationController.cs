using AndersonNotificationFunction;
using AndersonNotificationModel;
using System.Net.Mail;
using System.Web.Mvc;

namespace AndersonNotificationWeb.Controllers
{
    public class EmailNotificationController : BaseController
    {
        private IFNotification _iFNotification;
        public EmailNotificationController(IFNotification iFNotification)
        {
            _iFNotification = iFNotification;
        }

        #region Create
        [HttpGet]
        public ActionResult Create()
        {
            return View(new Notification());
        }

        [HttpPost]
        public ActionResult Create(Notification notification)
        {
            var createdNotification = _iFNotification.Create(CredentialId,notification);
            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Credentials = new System.Net.NetworkCredential(notification.Sender, notification.Password);
            
            smtpClient.Send(from: notification.Sender, recipients: notification.Receiver, subject: notification.Subject, body: notification.Body);

            return RedirectToAction("Index");
        }
        #endregion

        #region Read
        [HttpGet]
        public ActionResult Index()
        {
            return View();
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