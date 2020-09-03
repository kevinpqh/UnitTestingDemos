using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using TestingDemoNetCore;

namespace NUnitTestDemoApi.Tests
{
    public class TestClientProvider
    {
        public HttpClient client {get; private set; }
        public TestClientProvider()
        {
            //var server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            var server = new TestServer(WebHost.CreateDefaultBuilder().UseStartup<Startup>());
            client =server.CreateClient();
        }
    }
}
