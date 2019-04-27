using System;
using VesselCli.Models;

namespace VesselCli.Contracts
{
    public interface IVesselService
    {
        void Add(Vessel vessel);
    }
}