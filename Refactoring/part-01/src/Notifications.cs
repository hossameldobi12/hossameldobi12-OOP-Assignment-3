namespace RefactoringLab;

public interface INotification
{
    void Send(string to, string message);
}

public class EmailNotification : INotification
{
    public void Send(string to, string message) =>
        Console.WriteLine($"[email] {to}: {message}");
}

public class SmsNotification : INotification
{
    public void Send(string to, string message) =>
        Console.WriteLine($"[sms] {to}: {message}");
}
public class PushNotification : INotification
{
    public void Send(string to, string message) =>
        Console.WriteLine($"[push] {to}: {message}");
}

public class UrgentNotification : INotification
{
    private readonly INotification _notification;
    public UrgentNotification(INotification notification)
    {
        _notification = notification;
    }

    public void Send(string to, string message) =>
        _notification.Send(to, $"[URGENT] {message}");
}


public class ScheduledNotification : INotification
{
    public DateTime SendAt { get; set; }
    private readonly INotification _notification;

    public ScheduledNotification(INotification notification, DateTime sendAt)
    {
        _notification  = notification;
        SendAt = sendAt;
    }

    public void Send(string to, string message)
    {
        Console.WriteLine($"[scheduled {SendAt:g}]");
        _notification.Send(to, message);
    }
}


