using RestSharp;
using System.Configuration;
using TechTalk.SpecFlow;

namespace Sammak.SpecflowTest.Common
{
    [Binding]
    public abstract class BillingCommonSteps
    {
        private static string _billingEndpointUrl = $"{ConfigurationManager.AppSettings["Test_BillingClientApiUrl"]}/api/billing/";
        protected ApiCaller _apiCaller;

        /// <summary>
        /// Performs some common functions. usually common initializations used by all test scenarios in this project.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public BillingCommonSteps(ApiCaller apiCaller) 
        {
            //string appSettingValue = ConfigurationManager.AppSettings["Test_BillingClientApiUrl"];
            //return string.IsNullOrEmpty(appSettingValue) ? string.Empty : appSettingValue;
            //string _billingEndpointUrl = $"{appSettingValue}/api/billing/";
            _apiCaller = apiCaller;
            _apiCaller.RestClient = new RestClient(_billingEndpointUrl);
        }

        [Given(@"the feature test is initialized")]
        public void GivenTheFeatureTestIsInitialized()
        {
            // place any common test initialization here
        }

    }
}
