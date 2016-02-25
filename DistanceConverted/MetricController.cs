using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace DistanceConverted
{
	partial class MetricController : UIViewController
	{
		public MetricController (IntPtr handle) : base (handle)
		{

		}
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            //ConvertTabBarController ctbc = (ConvertTabBarController)this.TabBarController;
            //string[] result = ctbc.Result;
            //result = ctbc.Result;
			var result = ((AppDelegate)UIApplication.SharedApplication.Delegate).Result;
            lblOldEnglish.Text = "Old English";
            lblNewEnglish.Text = "New English";
            lblOldMetric.Text = "Old Metric";
			lblNewMetric.Text = result[2];
        }
	}
}
