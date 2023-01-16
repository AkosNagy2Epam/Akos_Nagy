using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using WebAPITest;
using WebAPITest.Payloads;

namespace Tests.Features
{
    [Binding]
    public class SuccessfullyUpdateBookingSteps
    {
        RestSharp.RestResponse response;
        BookerCrudClient client = new BookerCrudClient();
        int id = 0;
        string token = "";
        Booking payload = new Booking();

        [Given(@"a new first name of ""(.*)""")]
        public void GivenANewFirstNameOf(string p0)
        {
            payload.firstname = p0;
        }
        
        [Given(@"a new last name of ""(.*)""")]
        public void GivenANewLastNameOf(string p0)
        {
            payload.lastname = p0;
        }
        
        [Given(@"a new total price of (.*)")]
        public void GivenANewTotalPriceOf(int p0)
        {
            payload.totalprice = 7000;
        }
        
        [Given(@"a new deposit being paid value of ""(.*)""")]
        public void GivenANewDepositBeingPaidValueOf(string p0)
        {
            payload.depositpaid = bool.Parse(p0);
        }
        
        [Given(@"a new check in date of ""(.*)""")]
        public void GivenANewCheckInDateOf(string p0)
        {
            payload.bookingdates = new BookingDates() { checkin = p0 };
        }
        
        [Given(@"a new check out date of ""(.*)""")]
        public void GivenANewCheckOutDateOf(string p0)
        {
            payload.bookingdates.checkout = p0;
        }
        
        [Given(@"a new additional need of ""(.*)""")]
        public void GivenANewAdditionalNeedOf(string p0)
        {
            payload.additionalneeds = p0;
        }
        
        [Given(@"we have a valid token for authentication")]
        public void GivenWeHaveAValidTokenForAuthentication()
        {
            var payload = new WebAPITest.Payloads.Req.CreateToken() { password = "password123", username = "admin" };
            token = client.CreateToken(payload).Data.Token;
        }

        [Given(@"we have the id of an existing booking")]
        public void GivenWeHaveTheIdOfAnExistingBooking()
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

        [When(@"we send a request to update the booking using the token and the ID")]
        public void WhenWeSendARequestToUpdateTheBookingUsingTheTokenAndTheID()
        {
            response = client.UpdateBooking(id, payload, token);
        }
        
        [Then(@"the response should contain a confirmation code of (.*)")]
        public void ThenTheResponseShouldContainAConfirmationCodeOf(int p0)
        {
            Assert.AreEqual(p0, (int)response.StatusCode);
        }
    }
}
