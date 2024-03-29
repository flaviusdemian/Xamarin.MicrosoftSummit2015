
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

        public MainViewController()
        {
        }

        public MainViewController(IntPtr handle)
            : base(handle)
        {
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

            label1.Text = _mockService.RetrieveMockString();

            label2.Text = _mockService.RetrievePartialStringWrapper();

            label3.Text = _mockService.RetrieveIFDEFString();
        }
    }
}