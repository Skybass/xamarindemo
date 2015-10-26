using System;

using UIKit;

namespace xamarindemo
{
	public partial class ViewController : UIViewController
	{
		public ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}

		partial void dateButton_TouchUpInside (UIButton sender)
		{
			dateLabel.Text = DateTime.Now.ToString("dd.MM.yy H:mm:ss");
		}
	}
}

