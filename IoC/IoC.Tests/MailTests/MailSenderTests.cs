using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IoC.BusinessLogic.Interfaces;
using IoC.BusinessLogic.Concretes;

namespace IoC.Tests.MailTests
{
    [TestClass]
    public class MailSenderTests
    {
        [TestMethod]
        public void Ensure_MailSender_Sends_Email()
        {
            var testString = "Email sent to robert.dougan@gmail.com with the subject \"Hello\"";
            IMailSender sender = new MailSender();
            var mailString = sender.SendMail("robert.dougan@gmail.com", "Hello");
            Assert.AreEqual(testString, mailString);
        }

        [TestMethod]
        public void Ensure_MockMailSender_Logs_Email()
        {
            var testString = "Email logged: robert.dougan@gmail.com with the subject \"Hello\"";
            IMailSender sender = new MockMailSender();
            var mailString = sender.SendMail("robert.dougan@gmail.com", "Hello");
            Assert.AreEqual(testString, mailString);
        }
    }
}
