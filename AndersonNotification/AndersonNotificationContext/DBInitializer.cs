using AndersonNotificationEntity;
using System.Data.Entity;

namespace AndersonNotificationContext
{
    public class DBInitializer : CreateDatabaseIfNotExists<Context>
    {
        public DBInitializer()
        {
        }
        protected override void Seed(Context context)
        {
            context.Notifications.Add(
                new ENotification
                {
                });
            base.Seed(context);
        }
    }
}