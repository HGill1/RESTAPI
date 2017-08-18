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
    class ClientClosesSession110
    {
        ConnectToPensionAPI connectToPensionApi = new ConnectToPensionAPI(Utilities.Messages.PENSION_VALUATION);
        private IRestResponse response;
        private string jsonResponse;
        private PensionObject pensionObject;

        [Given(@"a MyAviva skill session is open")]
        public void GivenAMyAvivaSkillSessionIsOpen()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I say ""(.*)""")]
        public void WhenISay(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Alexa will say ""(.*)""")]
        public void ThenAlexaWillSay(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"my session will close")]
        public void ThenMySessionWillClose()
        {
            ScenarioContext.Current.Pending();
        }

    }
}
