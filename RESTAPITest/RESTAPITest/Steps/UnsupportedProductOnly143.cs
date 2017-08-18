using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using NUnit.Framework;
using RestSharp;
using RESTAPITest.JsonClasses;
using RESTAPITest.Utilities;
using TechTalk.SpecFlow;

namespace RESTAPITest.Steps
{
    [Binding]
    class UnsupportedProductOnly143
    {
        ConnectToPensionAPI connectToPensionApi = new ConnectToPensionAPI(Utilities.Messages.PENSION_VALUATION);
        private IRestResponse response;
        private string jsonResponse;
        private PensionObject pensionObject;

        [Given(@"I have one policy that is an unsupported product")]
        public void GivenIHaveOnePolicyThatIsAnUnsupportedProduct()
        {
            response = connectToPensionApi.getPensionAPIRresponse();
        }

        [Given(@"I request Alexa the value of my pension")]
        public void GivenIRequestAlexaTheValueOfMyPension()
        {
            this.jsonResponse = response.Content;
        }

        [When(@"I give my correct PIN")]
        public void WhenIGiveMyCorrectPIN()
        {
            this.pensionObject = JsonConvert.DeserializeObject<PensionObject>(this.jsonResponse);
        }

        [Then(@"I will receive following responses")]
        public void ThenIWillReceiveFollowingResponses(Table table)
        {
            string APIResponse = "have a great morning";
            Assert.AreEqual(Utilities.Messages.MORNING_MSG, APIResponse);
        }
    }
}
