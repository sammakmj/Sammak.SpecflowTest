using Newtonsoft.Json;
using NUnit.Framework;
using Sammak.SpecflowTest.Common;
using System;
using TechTalk.SpecFlow;

namespace Sammak.SpecflowTest
{
    [Binding]
    [Scope(Feature = "GetLocationPayer")]
    public class GetLocationPayerSteps : BillingCommonSteps
    {
        private int _payerId;

        public GetLocationPayerSteps(ApiCaller restClient) : base(restClient)
        {
        }

        [Given(@"I have a valid payer ID (.*)")]
        public void GivenIHaveAValidPayerID(int payerId)
        {
            _payerId = payerId;
        }

        [When(@"I make a request to the API with payer ID")]
        public void WhenIMakeARequestToTheAPIWithPayerID()
        {
            _apiCaller.ExecuteGet($"get-location-payer/{_payerId}");
        }

        [Then(@"The name in the record returned should be (.*)")]
        public void ThenTheNameInTheRecordReturnedShouldBe(string name)
        {
            var locationPayer = JsonConvert.DeserializeObject<LocationPayer>(_apiCaller.Response.Content);
            Assert.IsNotNull(locationPayer, "Expected a Location Payer but no payer was returned.");
            Assert.AreEqual(name, locationPayer.PayerName);
        }

        [Given(@"I have an invalid payer ID (.*)")]
        public void GivenIHaveAnInvalidPayerID(int invalidPayerId)
        {
            _payerId = invalidPayerId;
        }

        [Then(@"The returned result is empty")]
        public void ThenTheReturnedResultIsEmpty()
        {
            var locationPayer = JsonConvert.DeserializeObject<LocationPayer>(_apiCaller.Response.Content);
            Assert.IsNull(locationPayer, "Expected no payer but received a Location Payer");
        }
    }
}
