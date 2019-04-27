using System;
using VesselCli.Contracts;
using VesselCli.Models;
using VesselCli.Core.Log;

namespace VesselCli.Service
{
    public class LoggerService : ILoggerService
    {
        ILogger logger;

        public LoggerService()
        {
            //TODO:Read from config or Use dependency injection
            logger = LoggerFactory.CreateInstance(LogType.CONSOLE);
        }


        public void Log(string entry)
        {
            logger.Log(entry);
        }
    }
}