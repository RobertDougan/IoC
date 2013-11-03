namespace IoC.BusinessLogic.Interfaces
{
    public interface IMailSender
    {
        string SendMail(string toAddress, string subject);
    }
}
