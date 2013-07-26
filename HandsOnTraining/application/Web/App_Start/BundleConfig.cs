

using System.Web.Optimization;

namespace RaviDataGlobe.HandsOnTraining.Web.App_Start
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/base/mvvm").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/knockout-2.3.0"));
            
            bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/site.css"));

          
        }
    }
}