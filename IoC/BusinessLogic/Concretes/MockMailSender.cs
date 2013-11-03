using BusinessLogic.Interfaces;

namespace IoC.BusinessLogic.Concretes
{
    public class MockMailSender : IMailSender
    {
        public string SendMail(string toAddress, string subject)
        {
            string mailString = "Email logged: " + toAddress + " with the subject \"" + subject + "\"";
            return mailString;
        }
    }
}
