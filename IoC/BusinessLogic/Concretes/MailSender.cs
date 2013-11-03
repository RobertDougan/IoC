using IoC.BusinessLogic.Interfaces;

namespace IoC.BusinessLogic.Concretes
{
    public class MailSender : IMailSender
    {
        private readonly ILogger _logger;

        public MailSender(ILogger logger)
        {
            this._logger = logger;
        }
        
        public string SendMail(string toAddress, string subject)
        {
            string mailString = "Email sent to " + toAddress + " with the subject \"" + subject + "\"";
            return mailString;
        }
    }
}
