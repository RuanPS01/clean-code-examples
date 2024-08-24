#region Evite

public static class NotificationContext
{
    public static IList<Notification> Notifications { get; set;}
}

#endregion


#region Utilize

public class NotificationContext
{
    public IList<Notification> Notifications { get; set;}
}

#endregion