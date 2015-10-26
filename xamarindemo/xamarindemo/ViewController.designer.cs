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

namespace xamarindemo
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton dateButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel textLabel { get; set; }

		[Action ("dateButton_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void dateButton_TouchUpInside (UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (dateButton != null) {
				dateButton.Dispose ();
				dateButton = null;
			}
			if (textLabel != null) {
				textLabel.Dispose ();
				textLabel = null;
			}
		}
	}
}
