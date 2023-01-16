using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using WebAPITest;
using WebAPITest.Payloads;

namespace Tests.Features
{
    [Binding]
    public class FailedUpdateBookingSteps
    {

        RestSharp.RestResponse response;
        BookerCrudClient client = new BookerCrudClient();
        int id = 0;
        string token = "";
        WebAPITest.Payloads.Req.Booking_BadReq payload = new WebAPITest.Payloads.Req.Booking_BadReq();

        [Given(@"we have a new first name of ""(.*)""")]
        public void GivenWeHaveANewFirstNameOf(string p0)
        {
            payload.firstname = p0;
        }
        
        [Given(@"we have a new last name of ""(.*)""")]
        public void GivenWeHaveANewLastNameOf(string p0)
        {
            payload.lastname = p0;
        }
        
        [Given(@"we have a new deposit being paid value of ""(.*)""")]
        public void GivenWeHaveANewDepositBeingPaidValueOf(string p0)
        {
            payload.depositpaid = bool.Parse(p0);
        }
        
        [Given(@"we have a new check in date of ""(.*)""")]
        public void GivenWeHaveANewCheckInDateOf(string p0)
        {
            payload.bookingdates = new BookingDates() { checkin = p0 };
        }
        
        [Given(@"we have a new check out date of ""(.*)""")]
        public void GivenWeHaveANewCheckOutDateOf(string p0)
        {
            payload.bookingdates.checkout = p0;
        }
        
        [Given(@"we have a new additional need of ""(.*)""")]
        public void GivenWeHaveANewAdditionalNeedOf(string p0)
        {
            payload.additionalneeds = p0;
        }
        
        [Given(@"also a valid token for authentication")]
        public void GivenAlsoAValidTokenForAuthentication()
        {
            var payload = new WebAPITest.Payloads.Req.CreateToken() { password = "password123", username = "admin" };
            token = client.CreateToken(payload).Data.Token;
        }

        [Given(@"we also have the id of an existing booking")]
        public void GivenWeAlsoHaveTheIdOfAnExistingBooking()
        {
            var payloadForCreating = new Booking()
            {
                firstname = "Liam",
                lastname = "Howlett",
                totalprice = 1000,
                depositpaid = false,
                additionalneeds = "none",
                bookingdates = new BookingDates() { checkin = "2018 - 01 - 01", checkout = "2018-01-02" }
            };
            id = client.CreateBooking(payloadForCreating).Data.BookingId;
        }

        [When(@"a request is sent to update with no price data using the token and the ID")]
        public void WhenARequestIsSentToUpdateWithNoPriceDataUsingTheTokenAndTheID()
        {
            response = client.UpdateBooking(id, payload, token);
        }
        
        [Then(@"the response should contain an error code of (.*)")]
        public void ThenTheResponseShouldContainAnErrorCodeOf(int p0)
        {
            Assert.AreEqual(p0,(int)response.StatusCode);            
        }
    }
}
