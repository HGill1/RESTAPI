using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestTest
{
    using System.Net;

    class Program
    {
        static void Main(string[] args)
        {
            var client = new RestClient("https://pension-runway.integration.avivaaws.com:8443/api/v1/pensionPlans/TK10083228/valuations");
            var request = new RestRequest(Method.GET);
            ServicePointManager.ServerCertificateValidationCallback +=
        (sender, certificate, chain, sslPolicyErrors) => true;
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("accept", "application/json");
            request.AddHeader("requesting-system", "MyAviva");
            request.AddHeader("authorization", "Basic TXlBdml2YTpHcmsjMVByQ2xAUnU=");
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
        }
    }
}
