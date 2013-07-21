using RaviDataGlobe.HandsOnTraining.Core.Interfaces.Data;
using RaviDataGlobe.HandsOnTraining.Infrastructure.Data;
using StructureMap.Configuration.DSL;

namespace RaviDataGlobe.HandsOnTraining.DependencyResolution.Registries
{
    public class DataRegistry : Registry
    {
        public DataRegistry()
        {
            For<ITaskRepository>().Use<TaskRepository>();
        }
    }

   
}