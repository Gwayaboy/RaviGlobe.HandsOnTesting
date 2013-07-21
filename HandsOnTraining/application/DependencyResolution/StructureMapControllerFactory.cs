
using System.Web.Mvc;
using System.Web.Routing;
using StructureMap;

namespace RaviDataGlobe.HandsOnTraining.DependencyResolution
{

    public class StructureMapControllerFactory : DefaultControllerFactory
    {
        protected override IController GetControllerInstance(RequestContext requestContext, System.Type controllerType)
        {
            try
            {
                return ObjectFactory.GetInstance(controllerType) as Controller;
            }
            catch (StructureMapException)
            {
                System.Diagnostics.Debug.WriteLine(ObjectFactory.WhatDoIHave());
                throw;
            }
        }
    }

}
