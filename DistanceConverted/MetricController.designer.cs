// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace DistanceConverted
{
	[Register ("MetricController")]
	partial class MetricController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel lblNewEnglish { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel lblNewMetric { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel lblOldEnglish { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel lblOldMetric { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (lblNewEnglish != null) {
				lblNewEnglish.Dispose ();
				lblNewEnglish = null;
			}
			if (lblNewMetric != null) {
				lblNewMetric.Dispose ();
				lblNewMetric = null;
			}
			if (lblOldEnglish != null) {
				lblOldEnglish.Dispose ();
				lblOldEnglish = null;
			}
			if (lblOldMetric != null) {
				lblOldMetric.Dispose ();
				lblOldMetric = null;
			}
		}
	}
}
