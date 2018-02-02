using AndersonNotificationData;
using AndersonNotificationFunction;
using AndersonNotificationModel;
using System.Net.Mail;
using System.Web.Http;

namespace AndersonNotificationWeb.ApiControllers
{
    public class EmailNotificationApiController : BaseApiController
    {
        private IFEmailNotification _iFEmailNotification;
        private IDEmailNotification _iDEmailNotification;

        public EmailNotificationApiController()
        {
            _iDEmailNotification  = new DEmailNotification();
            _iFEmailNotification  = new FEmailNotification(_iDEmailNotification);
        }

        [HttpPost]
        public IHttpActionResult Get(EmailNotification emailNotification)
        {
            var Password = "SUBJECTIVE TO CHANGE.";
            SmtpClient smtpClient = new SmtpClient();

            var createdNotification = _iFEmailNotification.Create(CredentialId, emailNotification);
            smtpClient.Credentials = new System.Net.NetworkCredential(emailNotification.Sender, Password);
            smtpClient.Send(from: emailNotification.Sender, recipients: emailNotification.Receiver, subject: emailNotification.Subject, body: emailNotification.Body);

            return Ok(emailNotification);
        }
    }
}