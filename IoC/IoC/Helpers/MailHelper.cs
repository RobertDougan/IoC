using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IoC.BusinessLogic.Interfaces;

namespace IoC.Helpers
{
    public class MailHelper
    {
        private readonly IMailSender _mailSender;

        public MailHelper(IMailSender mailSender)
        {
            _mailSender = mailSender;
        }

        public string SendMail(string toAddress, string subject)
        {
            var mailResult = _mailSender.SendMail(toAddress, subject);
            return mailResult;
        }
    }
}