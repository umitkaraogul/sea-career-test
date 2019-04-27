using System;
using VesselCli.Models;

namespace VesselCli.Contracts
{
    public interface IVesselRepository
    {
        void Add(Vessel vessel);
    }
}