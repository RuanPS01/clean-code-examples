// Evite
public static class NotificationContext
{
    public static IList<Notification> Notifications { get; set;}
}


// Utilize
public class NotificationContext
{
    public IList<Notification> Notifications { get; set;}
}