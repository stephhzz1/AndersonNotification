using AndersonNotificationFunction;
using AndersonNotificationModel;
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
            FEmailNotification fe = new FEmailNotification();
            fe.Send(CredentialId,notification);

            return RedirectToAction("Index");
           

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