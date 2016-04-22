using System;

using UIKit;
using ePOS2_Lib;
using Foundation;
using CoreGraphics;
using ExternalAccessory;
namespace eposPrinterDemo
{


	class Epos2Scan : Epos2ScanDelegate
	{
		ViewController controller;
		public Epos2Scan(ViewController controller)
		{
			this.controller = controller;
		}

		#region implemented abstract members of Epos2ScanDelegate
		public override void ScanData (Epos2BarcodeScanner scannerObj, string scanData)
		{
			string CR = "\n";

			if (controller.textScanner.Text.Length != 0) {
				controller.textScanner.Text = controller.textScanner.Text + CR;  
			}
			controller.textScanner.Text = controller.textScanner.Text + scanData;

			controller.scrollText();
		}
		#endregion
		
	}


	public partial class ViewController : UIViewController
	{
		



		void finalizeObject()
		{
			if (barcodeScanner_ == null) {
				return;
			}

			//barcodeScanner_.SetScanEventDelegate (null);
			barcodeScanner_ = null;
		}


		public bool initializeObject()
		{
			if (barcodeScanner_ != null) {
				finalizeObject ();
			}

			barcodeScanner_ = new Epos2BarcodeScanner();  //[[Epos2BarcodeScanner alloc] init];
			if (barcodeScanner_ == null) 
			{
				ShowMsg.showErrorEpos(Epos2ErrorStatus.ErrMemory,"Init");
				return false;
			}

			barcodeScanner_.SetScanEventDelegate(new Epos2Scan(this));

			return true;
		}

		bool connectScanner()
		{
			Epos2ErrorStatus result = Epos2ErrorStatus.Success;

			if (barcodeScanner_ == null) {
				return false;
			}

			result = (Epos2ErrorStatus)barcodeScanner_.Connect (textTarget.Text, -2);

				
			if (result != Epos2ErrorStatus.Success) {
				ShowMsg.showErrorEpos (result, "connect"); 
				finalizeObject ();
				return false;
			}

			return true;
		}


		public	void setDoneToolbar()
		{
			UIToolbar doneToolbar = new UIToolbar (new CoreGraphics.CGRect (0, 0, this.View.Frame.Width, 44)); 
				
			doneToolbar.BarStyle = UIBarStyle.BlackTranslucent;

			doneToolbar.SizeToFit ();

			UIBarButtonItem space = new UIBarButtonItem (UIBarButtonSystemItem.FlexibleSpace, null);

				
			UIBarButtonItem doneButton = new UIBarButtonItem (UIBarButtonSystemItem.Done, (s, e) => 
			{
					textTarget.ResignFirstResponder();		
			});

			UIBarButtonItem[] items = new UIBarButtonItem[] { space,doneButton};


			doneToolbar.SetItems(items, true);
			textTarget.InputAccessoryView = doneToolbar;
		}


		Epos2BarcodeScanner barcodeScanner_;

	//	UIBackgroundTaskIdentifier bgTask;

		public ViewController (IntPtr handle) : base (handle)
		{
			barcodeScanner_ = null;
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			setDoneToolbar ();
			textTarget.Text = "";
			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}


		partial void connectProcess (UIButton sender)
		{
			if (!initializeObject()) {
				return;
			}

			if (!connectScanner()) {
				return;
			}

			buttonConnect.Enabled = false;
		}



		void disconnectScanner()
		{
			Epos2ErrorStatus result = Epos2ErrorStatus.Success;

			if (barcodeScanner_ == null) {
				return;
			}

			result = (Epos2ErrorStatus)barcodeScanner_.Disconnect;
			if (result != Epos2ErrorStatus.Success) {
				ShowMsg.showErrorEpos (result, "Disconnect");
			}
		}


		partial void disconnectProcess (UIButton sender)
		{
			disconnectScanner();

			finalizeObject();

			buttonConnect.Enabled= true;
		}

		partial void clearScanner (UIButton sender)
		{
			textScanner.Text = "";
		}

		public void	scrollText()
		{
			NSRange range;
			range = textScanner.SelectedRange;

			range.Location = textScanner.Text.Length;

			textScanner.SelectedRange = range;
			textScanner.ScrollEnabled = true;

			nfloat scrollY = textScanner.ContentSize.Height+ textScanner.Font.PointSize  - textScanner.Bounds.Size.Height;
			CGPoint scrollPoint;

			if (scrollY < 0) {
				scrollY = 0;
			}
			scrollPoint = new CGPoint (0, scrollY);

			textScanner.SetContentOffset (scrollPoint, true);
		}
	}
}

