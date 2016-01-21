using System.Web;
using System.Web.Optimization;
using System.Collections.Generic;
using System.IO;

namespace Ecosologic.UI
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            //// Use the development version of Modernizr to develop with and learn from. Then, when you're
            //// ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            //bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
            //            "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/materialize").Include(
                      "~/Scripts/materialize/materialize.js"));

            var _bundleAngular = new ScriptBundle("~/bundles/AngularJS")
                                 .Include("~/Scripts/Angular/BibliotecaAngular/angular.js")
                                 .Include("~/Scripts/Angular/BibliotecaAngular/angular-route.min.js")
                                 .Include("~/Scripts/Angular/BibliotecaAngular/angular-sanitize.min.js")
                                 .Include("~/Scripts/Angular/BibliotecaAngular/angular-touch.js")
                                 .Include("~/Scripts/Angular/BibliotecaAngular/angular-touch.min.js")
                                 .Include("~/Scripts/Angular/BibliotecaAngular/angular-animate.min.js")
                                 .Include("~/Scripts/Angular/BibliotecaAngular/ui-grid.min.js")
                                 .Include("~/Scripts/Angular/BibliotecaAngular/i18n/grid/ui-i18n.js")
                                 .Include("~/Scripts/Angular/BibliotecaAngular/i18n/grid/pt-br.js")
                                 .Include("~/Scripts/Angular/BibliotecaAngular/angular-file-upload.min.js")
                                 .Include("~/Scripts/Angular/BibliotecaAngular/loading-bar.min.js")
                                 .Include("~/Scripts/Angular/UI/ui-utils.min.js")
                //.Include("~/Scripts/Angular/ng-scrollbar.min.js")
                                 .Include("~/Scripts/Angular/BibliotecaAngular/angucomplete-alt.js")
                                 .Include("~/Scripts/Angular/BibliotecaAngular/ui-bootstrap.js")
                                 .Include("~/Scripts/Angular/BibliotecaAngular/angular-translate.js")
                                 .Include("~/Scripts/Angular/BibliotecaAngular/dialogs.js")
                                 .Include("~/Scripts/Angular/BibliotecaAngular/angular-materialize.js");

            _bundleAngular.Orderer = new NonOrderingDefault();
            bundles.Add(_bundleAngular);

            bundles.Add(new StyleBundle("~/Content/angular/css").Include(
                "~/Content/loading-bar.css",
                "~/Content/angucomplete-alt.css",
                "~/Content/dialogs.css",
                "~/Content/ui-grid.min.css"
                ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/materialize/css/materialize.css"));
        }
    }

    class NonOrderingDefault : IBundleOrderer
    {
        public IEnumerable<BundleFile> OrderFiles(BundleContext context, IEnumerable<BundleFile> files)
        {
            return files;
        }

    }
}
