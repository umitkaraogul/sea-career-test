using System;
using VesselCli.Contracts;
using VesselCli.Models;

namespace VesselCli.Service
{
    public class VesselService : IVesselService
    {
        IVesselRepository vesselRespository;
        private readonly ILoggerService loggerService;

        //TODO:Use dependency injection
        public VesselService(IVesselRepository repository, ILoggerService log)
        {
            //TODO:dependency injection.
            vesselRespository = repository;
            loggerService = log;
        }

        public void Add(Vessel vessel)
        {
            vesselRespository.Add(vessel);

            loggerService.Log($"Vessel added {vessel.VesselId}");

        }
    }
}