using System.Web;
using System.Web.Optimization;

namespace alsStop
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/lib/jquery/jquery.min.js",
                        "~/Scripts/lib/jquery/jquery-migrate.min.js"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts//lib/bootstrap/js/bootstrap.min.js",
                       "~/Scripts//lib/bootstrap/js/bootstrap.bundle.min.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Scripts/lib/bootstrap/css/bootstrap.min.css",
                      "~/Content/site.css",
                      "~/Content/theme/style.css"));

            //theme library
            bundles.Add(new StyleBundle("~/bundles/themelib").Include(
                       "~/Scripts/lib/animate/animate.min.css",
                       "~/Scripts/lib/font-awesome/font-awesome.min.css",
                       "~/Scripts/lib/ionicons/ionicons.min.css",
                       "~/Scripts/lib/magnific-popup/magnific-popup.css"
                       ));

            //adding main.css
            bundles.Add(new StyleBundle("~/bundles/themestyle").Include(
                       "~/Content/theme/style.css"
                       ));

            // adding javascripts libraries
            bundles.Add(new ScriptBundle("~/bundles/themelibraries").Include(
                       "~/Scripts/lib/easing/easing.min.js",
                       "~/Scripts/lib/wow/wow.min.js",
                       "~/Scripts/lib/superfish/hoverIntent.js",
                       "~/Scripts/lib/superfish.min.js",
                       "~/Scripts/lib/magnific-popup/magnific-popup-min.js"
                       ));

            //contact form javascript
            bundles.Add(new ScriptBundle("~/bundles/themeform").Include(
                       "~/Scripts/lib/contactform/contactform.js"
                       ));

            //Main javascript for all the function
            bundles.Add(new ScriptBundle("~/bundles/thememain").Include(
                       "~/Scripts/theme/main.js"
                       ));

        }
    }
}
