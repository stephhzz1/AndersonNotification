using AndersonNotificationFunction;
using AndersonNotificationModel;
using System;
using System.Web.Helpers;
using System.Web.Mvc;

namespace AndersonNotificationWeb.Controllers
{
    public class NotificationController : Controller
    {
        private IFNotification _iFNotification;
        public NotificationController(IFNotification iFNotification)
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
            var createdNotification = _iFNotification.Create(notification);

            return RedirectToAction("Index");
        }
        #endregion

        [HttpGet]
        public ActionResult Notification()
        {

            return View();
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}