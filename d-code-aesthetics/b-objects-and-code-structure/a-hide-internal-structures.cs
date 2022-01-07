public class NotificationContext
{
    private List<string> _notifications; //privado e somente acessível por métodos

    public void Add(string notification) 
    {
        _notifications.Add(notification);
    }

    public bool IsValid() => _notifications.Any();

    public IEnumerable Notifications { get => _notifications.AsEnumerable(); }
}