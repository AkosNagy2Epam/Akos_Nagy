using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using WebAPITest;
using WebAPITest.Payloads;

namespace Tests.Features
{
    [Binding]
    public class SuccessfullyDeleteBookingSteps
    {
        RestSharp.RestResponse response;
        BookerCrudClient client = new BookerCrudClient();
        int id = 0;
        string token = "";


        [Given(@"an ID that is associated with an existing booking")]
        public void GivenAnIDThatIsAssociatedWithAnExistingBooking()
        {
            var payload = new Booking() { firstname = "Liam", lastname = "Howlett", totalprice = 1000, depositpaid = false, additionalneeds = "none",
                bookingdates = new BookingDates() { checkin = "2018 - 01 - 01",checkout= "2018-01-02" } };
            id=client.CreateBooking(payload).Data.BookingId;
        }
        
        [Given(@"a valid authentication token is present")]
        public void GivenAValidAuthenticationTokenIsPresent()
        {
            var payload = new WebAPITest.Payloads.Req.CreateToken() { password = "password123", username = "admin" };
            token = client.CreateToken(payload).Data.Token;
        }       

        [When(@"a request is sent to delete a booking using the ID and the token")]
        public void WhenARequestIsSentToDeleteABookingUsingTheIDAndTheToken()
        {
           response= client.DeleteBooking(id, token);
        }
        
        [Then(@"the response contains a confirmation code of (.*)")]
        public void ThenTheResponseContainsAConfirmationCodeOf(int p0)
        {
            Assert.AreEqual(p0, (int)response.StatusCode);
        }
    }
}
