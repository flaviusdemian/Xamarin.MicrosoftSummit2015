using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Environment = System.Environment;

namespace MsSummit.Core
{
    public partial class MockService
    {
        //provide the implementation here
        partial void DoSomething()
        {
            _partialString = "DoSomething Android";
        }

        public string IFDEFString
        {
            get
            {
                #if __IOS__
                    return "IOS IFDEF";
                #else
                #if __ANDROID__
                    return "Android IFDEF";
                #else
                        // WinPhone
                        return "WindowsPhoe IFDEF";
                #endif
                #endif
            }
        }

        public string RetrieveIFDEFString()
        {
            return IFDEFString;
        }
    }

}