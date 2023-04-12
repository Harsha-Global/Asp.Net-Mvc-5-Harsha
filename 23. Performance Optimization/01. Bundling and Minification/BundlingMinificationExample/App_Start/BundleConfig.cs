using System;
using System.Web;
using System.Web.Optimization;

namespace BundlingMinificationExample
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/scriptbundle1").Include("~/Scripts/JavaScript1.js", "~/Scripts/JavaScript2.js", "~/Scripts/JavaScript3.js", "~/Scripts/JavaScript4.js", "~/Scripts/JavaScript5.js"));
            bundles.Add(new ScriptBundle("~/bundles/scriptbundle2").Include("~/Scripts/JavaScript6.js", "~/Scripts/JavaScript7.js", "~/Scripts/JavaScript8.js", "~/Scripts/JavaScript9.js", "~/Scripts/JavaScript10.js"));
            bundles.Add(new StyleBundle("~/bundles/stylebundle1").Include("~/Styles/StyleSheet1.css", "~/Styles/StyleSheet2.css", "~/Styles/StyleSheet3.css", "~/Styles/StyleSheet4.css", "~/Styles/StyleSheet5.css"  ));
            bundles.Add(new StyleBundle("~/bundles/stylebundle2").Include("~/Styles/StyleSheet6.css", "~/Styles/StyleSheet7.css", "~/Styles/StyleSheet8.css", "~/Styles/StyleSheet9.css", "~/Styles/StyleSheet10.css"));
            BundleTable.EnableOptimizations = true;
        }
    }
}


