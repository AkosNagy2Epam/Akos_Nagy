using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using WebAPITest;
using WebAPITest.Payloads;

namespace Tests.Features
{
    [Binding]
    public class FailedDeleteBookingSteps
    {
        RestSharp.RestResponse response;
        BookerCrudClient client = new BookerCrudClient();
        int id = 105;
        string token = "";

        [Given(@"a valid authentication token is obtained")]
        public void GivenAValidAuthenticationTokenIsObtained()
        {
            var payload = new WebAPITest.Payloads.Req.CreateToken() { password = "password123", username = "admin" };
            token = client.CreateToken(payload).Data.Token;
        }
        
        [Given(@"an ID that is not associated with any existing booking")]
        public void GivenAnIDThatIsNotAssociatedWithAnyExistingBooking()
        {
            client.DeleteBooking(id, token);
        }
        
        [When(@"a request is sent to delete using the ID and the token")]
        public void WhenARequestIsSentToDeleteUsingTheIDAndTheToken()
        {
            response = client.DeleteBooking(id, token);
        }
        
        [Then(@"the response contains an error code of (.*)")]
        public void ThenTheResponseContainsAnErrorCodeOf(int p0)
        {
            Assert.AreEqual(p0,(int)response.StatusCode);
        }
    }
}
