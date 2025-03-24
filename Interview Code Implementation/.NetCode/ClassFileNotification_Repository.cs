Class FileNotification
{
    private INotification _notification;
    FileNotification(INotification notification)
    {
        _notification = notification;
    }
    public void SendFileNotification()
    {
        _notification.SendNotification()
    }

}



Class SmsNotification() : INotification
{
    public void SendNotification()
    {
        /// Sending Notification Via SMS
    }

}



Class EmailNotification() : INotification
{
    public void SendNotification()
    {
        /// Sending Notification Via Email
    }
}


interface INotification 
{
    void SendNotification();
}


// We are injecting Dependency Injecttion 
//program.cs
builder.service.AddScoped(INotification, SmsNotification);