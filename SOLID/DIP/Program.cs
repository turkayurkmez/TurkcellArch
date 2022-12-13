/*Bağımlılık küçten büyüğe doğru trasarlanmalı*/

public class Report
{
    ISender sender;

    public Report(ISender mailSender)
    {
        this.sender = mailSender;
    }
    public void Send()
    {

        sender.Send();
    }
}

public interface ISender
{
    void Send();
}
public class MailSender : ISender
{
    public void Send() { }
}
public class WhatsAppSender : ISender
{
    public void Send()
    {
        throw new NotImplementedException();
    }
}