
using System;
using System.Drawing;

using Foundation;
using UIKit;
using MsSummit.Core;

namespace MsSummit.iOS
{
    public partial class MainViewController : UIViewController
    {
        private MockService _mockService = new MockService();

        static bool UserInterfaceIdiomIsPhone
        {
            get { return UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.Phone; }
        }

        public MainViewController()
        {
        }

        public MainViewController(IntPtr handle)
            : base(handle)
        {
        }

        public override void DidReceiveMemoryWarning()
        {
            // Releases the view if it doesn't have a superview.
            base.DidReceiveMemoryWarning();

            // Release any cached data, images, etc that aren't in use.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Perform any additional setup after loading the view, typically from a nib.
            #if __MOBILE__
                        Console.WriteLine("__MOBILE__ is defined");
            #endif

            #if __IOS__
                        Console.WriteLine("__IOS__ is defined");
            #endif

            UILabel label1 = new UILabel();
            label1.Text = _mockService.RetrieveMockString();
            Add(label1);

            UILabel label2 = new UILabel();
            label2.Text = _mockService.RetrievePartialStringWrapper();
            Add(label2);

            UILabel label3 = new UILabel();
            label1.Text = _mockService.RetrieveIFDEFString();
            Add(label3);
        }
    }
}