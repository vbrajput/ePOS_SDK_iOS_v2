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

namespace eposPrinterDemo
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton buttonClear { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton buttonConnect { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton buttonDisconnect { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextView textScanner { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField textTarget { get; set; }

		[Action ("clearScanner:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void clearScanner (UIButton sender);

		[Action ("connectProcess:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void connectProcess (UIButton sender);

		[Action ("disconnectProcess:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void disconnectProcess (UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (buttonClear != null) {
				buttonClear.Dispose ();
				buttonClear = null;
			}
			if (buttonConnect != null) {
				buttonConnect.Dispose ();
				buttonConnect = null;
			}
			if (buttonDisconnect != null) {
				buttonDisconnect.Dispose ();
				buttonDisconnect = null;
			}
			if (textScanner != null) {
				textScanner.Dispose ();
				textScanner = null;
			}
			if (textTarget != null) {
				textTarget.Dispose ();
				textTarget = null;
			}
		}
	}
}
