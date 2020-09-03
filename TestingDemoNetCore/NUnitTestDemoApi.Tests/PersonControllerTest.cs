using NUnit.Framework;
using NUnitTestDemoApi.Tests;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace Tests
{
    public class PersonControllerTest
    {
        //[SetUp]
        //public void Setup()
        //{
        //}

        [Test]
        public async Task Get_LoadData()
        {
            var _client = new TestClientProvider().client;

            HttpResponseMessage response = await _client.GetAsync("/api/person");


            Assert.True(response.StatusCode == HttpStatusCode.OK);
        }
    }
}