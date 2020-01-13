using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Optimization;
using System.Web;

namespace EntityFramework_MVC.App_Start
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/bundles/css").Include(
                                            "~/Content/bootstrap.css",
                                            "~/Content/site.css"
                                        ));

            var cdnPath = "http://ajax.aspnetcdn.com/ajax/jQuery/jquery-1.7.1.min.js";

            bundles.Add(new ScriptBundle("~/bundles/jquery", cdnPath)
                   .Include("~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/scripts").IncludeDirectory("~/Scripts/", "*.js", true));

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));


            ScriptBundle scriptBndl = new ScriptBundle("~/bundles/bootstrap");
            scriptBndl.Include(
                    "~/Scripts/bootstrap.js",
                    "~/Scripts/respond.js"
                  );
            bundles.Add(scriptBndl);



            BundleTable.EnableOptimizations = true;
        }
    }
}


