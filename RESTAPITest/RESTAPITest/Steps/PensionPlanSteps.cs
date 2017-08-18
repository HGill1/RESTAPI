using System;
using System.Net;
using Newtonsoft.Json;
using NUnit.Framework;
using RestSharp;
using TechTalk.SpecFlow;
using RESTAPITest.JsonClasses;
using RESTAPITest.Utilities;

namespace RESTAPITest.Steps
{
    [Binding]
    public class PensionPlanSteps
    {
        private string jsonResponse;

        private double fundValue;

        private IRestResponse response;

        private PensionObject pensionObject;

        ConnectToPensionAPI connectToPensionApi = new ConnectToPensionAPI(Utilities.Messages.PENSION_VALUATION);

        [Given(@"I have pension plan with Aviva")]
        public void GivenIHavePensionPlanWithAviva()
        {
            response = connectToPensionApi.getPensionAPIRresponse();
        }

        [When(@"I check my pension plan")]
        public void WhenITryToCheckMyPensionPlan()
        {  
            this.jsonResponse = response.Content;            
        }
        
        [Then(@"I can see my pension plan")]
        public void ThenICanSeeMyPensionPlan()
        {
            pensionObject = JsonConvert.DeserializeObject<PensionObject>(this.jsonResponse);
            foreach (var value in pensionObject.planValuation)
            {
                this.fundValue = value.fundValue;
            }
        }

        [Then(@"my fund value is ""(.*)""")]
        public void ThenMyFundValueIs(decimal fValue)
        {
            Assert.AreEqual(fValue, Math.Round(this.fundValue, 2));
        }

    }
}
