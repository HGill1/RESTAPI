using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace RESTAPITest.Steps
{
    [Binding]
    class GetValueofPensionPolicy88
    {
        [Given(@"I do not have a pension policy with Aviva on MDM")]
        public void GivenIDoNotHaveAPensionPolicyWithAvivaOnMDM()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I ask Alexa for the value of my pension")]
        public void WhenIAskAlexaForTheValueOfMyPension()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Alexa will tell me that they cannot locate a pension policy for me")]
        public void ThenAlexaWillTellMeThatTheyCannotLocateAPensionPolicyForMe()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I only have an out-of-scope pension policy with Aviva")]
        public void GivenIOnlyHaveAnOut_Of_ScopePensionPolicyWithAviva()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Alexa will tell me that they cannot service valuations for my pension\(s\) right now")]
        public void ThenAlexaWillTellMeThatTheyCannotServiceValuationsForMyPensionSRightNow()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I only have one in-scope pension policy")]
        public void GivenIOnlyHaveOneIn_ScopePensionPolicy()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"the value of that policy has been supplied from the api")]
        public void WhenTheValueOfThatPolicyHasBeenSuppliedFromTheApi()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Alexa will tell me the value of the pension")]
        public void ThenAlexaWillTellMeTheValueOfThePension()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"let me know the date that valuation was calculated")]
        public void ThenLetMeKnowTheDateThatValuationWasCalculated()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I have asked Alexa for the value of my pension policy")]
        public void GivenIHaveAskedAlexaForTheValueOfMyPensionPolicy()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"Alexa gets a bad-response from the getPensions Valuation api")]
        public void WhenAlexaGetsABad_ResponseFromTheGetPensionsValuationApi()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Alexa will tell me that my pension value is not available right now")]
        public void ThenAlexaWillTellMeThatMyPensionValueIsNotAvailableRightNow()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"the getPensions Valuation api response is time-out")]
        public void WhenTheGetPensionsValuationApiResponseIsTime_Out()
        {
            ScenarioContext.Current.Pending();
        }

    }
}
