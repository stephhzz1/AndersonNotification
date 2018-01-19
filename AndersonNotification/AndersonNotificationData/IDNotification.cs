using AndersonNotificationEntity;
using BaseData;
using System.Collections.Generic;

namespace AndersonNotificationData
{
    public interface IDNotification : IDBase
    {
        #region Read
        List<ENotification> Read();
        #endregion
    }
}