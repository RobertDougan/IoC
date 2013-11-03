using IoC.BusinessLogic.Concretes;
using IoC.BusinessLogic.Interfaces;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IoC.Ninject
{
    public class Bindings : NinjectModule
    {
        public override void Load()
        {
            Bind<IMailSender>().To<MailSender>();
            Bind<ILogger>().To<MailLogger>();
        }
    }
}