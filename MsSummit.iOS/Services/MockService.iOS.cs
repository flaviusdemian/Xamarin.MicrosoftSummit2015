using System;
using System.Collections.Generic;
using System.Text;

namespace MsSummit.Core
{
    partial class MockService
    {
        partial void DoSomething()
        {
            _partialString = "DoSomething iOS";
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
