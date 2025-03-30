Class FileNotification
{
    NotificationFactory nf = new NotificationFactory();
    INotification object  = nf.GetNotificationObject("Email")
    object.SendNotification();

}


Class SmsNotification : INotification
{
    public void SendNotification()
    {
        /// Sending Notification Via SMS
    }

}



Class EmailNotification : INotification
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


Class NotificationFactory
{
    public INotification GetNotificationObject(string key)
    {
        switch(key)
        {
            case "Email":
                return new EmailNotification();
            case "Sms":
                return new SmsNotification();

        }
    }
}