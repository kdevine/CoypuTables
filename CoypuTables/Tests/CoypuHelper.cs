using Coypu;
using Coypu.Drivers;
using Coypu.Drivers.Watin;

namespace CoypuTables.Tests
{
    public static class CoypuHelper
    {
        public static BrowserSession GetNewSession() {
            return new BrowserSession();
        }

        public static BrowserSession GetNewWatinSession() {
          var n = new WatiNDriver(Browser.InternetExplorer);
          return new BrowserSession(n);
        }
    }
}