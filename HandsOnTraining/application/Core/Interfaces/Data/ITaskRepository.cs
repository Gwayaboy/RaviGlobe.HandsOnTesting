using System.Collections.Generic;
using RaviDataGlobe.HandsOnTraining.Core.Domain;

namespace RaviDataGlobe.HandsOnTraining.Core.Interfaces.Data
{
    public interface ITaskRepository
    {
        IEnumerable<Task> GetAll();
    }
}