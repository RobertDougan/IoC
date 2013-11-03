﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoC.BusinessLogic.Interfaces
{
    public interface ILogger
    {
        string LogPath { get; set; }
        void Log();
    }
}
