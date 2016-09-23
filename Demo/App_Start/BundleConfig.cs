﻿using System.Web;
using System.Web.Optimization;

namespace CloudPacs.Demo
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/dicomweb").Include(
                        "~/Scripts/DICOMweb*"));

            //bundles.Add ( new ScriptBundle ( "~/bundles/dwv" ).Include (
            //            "~/Scripts/j2k/*.js",
            //            "~/Scripts/dwv-0.16.0.min.js" ));

            bundles.Add ( new ScriptBundle("~/bundles/cornerstornViewer").Include (
            "~/cornerstoneViewer/js/cornerstone.js",    
            "~/cornerstoneViewer/js/*.js",
                "~/cornerstoneViewer/wadoViewer.js" 
            )) ;

             bundles.Add(new ScriptBundle("~/bundles/app").Include(
                        "~/cloudPacs.App.js" ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      //"~/Content/flatly-bootstrap.css",
                      "~/Content/site.css",
                      "~/Content/jquery.json-viewer.css" ) );

            bundles.Add(new StyleBundle("~/Content/csViewer").Include(
                      "~/cornerstoneViewer/css/cornerstone.min.css"));
        }
    }
}
