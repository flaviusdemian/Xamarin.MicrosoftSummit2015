using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace MsSummit.Core
{
    public partial class MockService
    {
        private string _partialString = null;

        public string RetrieveMockString()
        {
            return "this is the mock string";
        }

        public string RetrievePartialStringWrapper()
        {
            DoSomething();
            return _partialString;
        }

        //always private and returns void
        partial void DoSomething();
    }
}
