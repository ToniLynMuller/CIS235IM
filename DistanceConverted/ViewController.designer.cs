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
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btnConvert { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btnMetric { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel lblNewUnits { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel lblOldUnits { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIPickerView pckNewUnits { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIPickerView pckOldUnits { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField txtDistance { get; set; }

		[Action ("BtnConvert_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void BtnConvert_TouchUpInside (UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (btnConvert != null) {
				btnConvert.Dispose ();
				btnConvert = null;
			}
			if (btnMetric != null) {
				btnMetric.Dispose ();
				btnMetric = null;
			}
			if (lblNewUnits != null) {
				lblNewUnits.Dispose ();
				lblNewUnits = null;
			}
			if (lblOldUnits != null) {
				lblOldUnits.Dispose ();
				lblOldUnits = null;
			}
			if (pckNewUnits != null) {
				pckNewUnits.Dispose ();
				pckNewUnits = null;
			}
			if (pckOldUnits != null) {
				pckOldUnits.Dispose ();
				pckOldUnits = null;
			}
			if (txtDistance != null) {
				txtDistance.Dispose ();
				txtDistance = null;
			}
		}
	}
}
