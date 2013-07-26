using System.Web.Mvc;
using RaviDataGlobe.HandsOnTraining.DependencyResolution.DependencyResolution;
using RaviDataGlobe.HandsOnTraining.DependencyResolution.Registries;
using StructureMap;

namespace RaviDataGlobe.HandsOnTraining.DependencyResolution
{
    public static class ApplicationConfigurator
    {
        private static IContainer _container;
        public static void BootStrap()
        {
            _container = BuildContainer();
            DependencyResolver.SetResolver(new StructureMapDependencyResolver(_container));
            Start();
        }

        private static void Start()
        {
        }

        private static IContainer BuildContainer()
        {
            ObjectFactory.Initialize(x => x.AddRegistry<DataRegistry>());

            return ObjectFactory.Container;
        }
    }
}
