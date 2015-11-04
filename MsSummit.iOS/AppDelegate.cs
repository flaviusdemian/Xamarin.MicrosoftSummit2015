using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace MsSummit.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    public partial class AppDelegate : UIApplicationDelegate
    {
        UIWindow _window;
        public static UIStoryboard Storyboard;
        public static UIViewController initialViewController;
        public static string MainStoryBoardName = null;

        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            MainStoryBoardName = "MainStoryboard_iPhone";
            if (UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.Pad)
            {
                MainStoryBoardName = "MainStoryboard_iPad";
            }
            Storyboard = UIStoryboard.FromName(MainStoryBoardName, null);
            initialViewController = Storyboard.InstantiateViewController("MainViewController");
            initialViewController = initialViewController as MainViewController;
            _window.RootViewController = initialViewController;
            _window.MakeKeyAndVisible();

            return true;
        }
    }
}