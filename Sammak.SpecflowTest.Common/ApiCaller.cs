using RestSharp;
using System.Configuration;

namespace Sammak.SpecflowTest.Common
{
    public class ApiCaller
    {
        public RestClient RestClient { get; set; }

        public IRestResponse Response { get; set; }

        public IRestResponse ExecuteGet(string apiUrl)
        {
            Response = RestClient.Execute(new RestRequest(apiUrl));
            return Response;
        }

    }
}

