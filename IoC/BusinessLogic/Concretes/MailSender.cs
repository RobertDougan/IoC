using BusinessLogic.Interfaces;

namespace IoC.BusinessLogic.Concretes
{
    public class MailSender : IMailSender
    {
        public string SendMail(string toAddress, string subject)
        {
            string mailString = "Email sent to " + toAddress + " with the subject \"" + subject + "\"";
            return mailString;
        }
    }
}
