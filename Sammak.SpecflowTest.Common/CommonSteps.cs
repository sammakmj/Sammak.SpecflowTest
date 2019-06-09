using NUnit.Framework;
using System.Net;
using TechTalk.SpecFlow;

namespace Sammak.SpecflowTest.Common
{
    [Binding]
    public class CommonSteps
    {
        private ApiCaller _restClient;

        /// <summary>
        /// Performs some common functions. usually common initializations used by all test scenarios in this project.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public CommonSteps(ApiCaller restClient)
        {
            _restClient = restClient;
        }

        [Then(@"the status code is OK")]
        public void ThenTheStatusCodeIsOK()
        {
            Assert.AreEqual(HttpStatusCode.OK, _restClient.Response.StatusCode);
        }

        [Then(@"the status code is BAD REQUEST")]
        public void ThenTheStatusCodeIsBadRequest()
        {
            Assert.AreEqual(HttpStatusCode.BadRequest, _restClient.Response.StatusCode, "Was expecting a 400 status code");
        }
    }
}
