using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using WebAPITest;
using WebAPITest.Payloads;

namespace Tests.Features
{
    [Binding]
    public class FailedGetBookingSteps
    {
        RestSharp.RestResponse<Booking> response;
        BookerCrudClient client = new BookerCrudClient();
        int id = 105;
        string token = "";

        [Given(@"a booking ID that is not associated with any existing booking")]
        public void GivenABookingIDThatIsNotAssociatedWithAnyExistingBooking()
        {
            var payload = new WebAPITest.Payloads.Req.CreateToken() { password = "password123", username = "admin" };
            token = client.CreateToken(payload).Data.Token;
            client.DeleteBooking(id, token);
        }
        
        [When(@"we request the booking data using this ID")]
        public void WhenWeRequestTheBookingDataUsingThisID()
        {
            response=client.GetBooking(id);
        }
        
        [Then(@"we should get an error code of (.*)")]
        public void ThenWeShouldGetAnErrorCodeOf(int p0)
        {
            Assert.AreEqual(p0,(int)response.StatusCode);
        }
    }
}
