using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RESTAPITest.Utilities
{
    class ConnectToPensionAPI
    {
        private String apiURL;

        public ConnectToPensionAPI(String URL)
        {
            this.apiURL = URL;
        }
        public IRestResponse getPensionAPIRresponse()
        {

            var client =
               new RestClient(this.apiURL);
            var request = new RestRequest(Method.GET);
            ServicePointManager.ServerCertificateValidationCallback +=
                (sender, certificate, chain, sslPolicyErrors) => true;
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("accept", "application/json");
            request.AddHeader("requesting-system", "MyAviva");
            request.AddHeader("authorization", "Basic TXlBdml2YTpHcmsjMVByQ2xAUnU=");
            return client.Execute(request);
        }

    }
}
