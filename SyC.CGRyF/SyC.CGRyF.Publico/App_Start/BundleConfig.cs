using System.Web;
using System.Web.Optimization;

namespace SyC.CGRyF.Publico
{
    public class BundleConfig
    {
        // Para obtener más información sobre las uniones, visite https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            var jqueryGobMx = new ScriptBundle("~/bundles/gobmx", "https://framework-gb.cdn.gob.mx/gobmx.js").Include("~/Scripts/gobmx.js");
            jqueryGobMx.CdnFallbackExpression = "window.jquery";
            bundles.Add(jqueryGobMx);

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new StyleBundle("~/Content/gobmx", "https://framework-gb.cdn.gob.mx/qa/assets/styles/main.css").Include(
                "~/Content/site.css"));

            BundleTable.EnableOptimizations = true;
            bundles.UseCdn = true;
        }
    }
}
