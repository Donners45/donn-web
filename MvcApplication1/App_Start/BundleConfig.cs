using System.Web;
using System.Web.Optimization;

namespace DonnWeb
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {

        //    bundles.Add(new ScriptBundle("~/Content/Bootstrap").Include("~/Scripts/bootstrap.js"));"~/Content/css/jquery.fullPage.css"
                    bundles.IgnoreList.Clear();


            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-1.11.3.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/libs").Include(
            "~/Scripts/parallax.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrapjs").Include(
                        "~/Scripts/bootstrap.min.js"));

            bundles.Add(new StyleBundle("~/Content/bootstrapcss").Include(
                        "~/Content/css/bootstrap.min.css",
                        "~/Content/css/bootstrap-responsive.min.css"
                        ));  
  
           bundles.Add(new StyleBundle("~/bundles/main-style").Include(
             "~/Content/sass-styles/main.css"
            )); 
 
        
        }
    }
}