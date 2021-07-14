using AspNetCore.Services.logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore.Services.Logging
{
    interface DatabaseLogger:ILogger
    {
        public void Log(string logMessage)
        {
            //veritabanına kaydetme kodları
        }
    }
}
