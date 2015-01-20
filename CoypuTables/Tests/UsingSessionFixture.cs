using Coypu;

using Xunit;

namespace CoypuTables.Tests
{
    public class UsingSessionFixture : IUseFixture<SessionFixture>
    {
        protected BrowserSession session;

        public void SetFixture(SessionFixture fixture)
        {
            session = fixture.Session;
            fixture.VisitFile(@"..\..\Tests\html\table.html");
        }
    }
}