using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using WebAPITest;
using WebAPITest.Payloads;

namespace Tests.Features
{
    [Binding]
    public class FailedCreateBookingSteps
    {
        WebAPITest.Payloads.Req.Booking_BadReq payload = new WebAPITest.Payloads.Req.Booking_BadReq();
        RestSharp.RestResponse<WebAPITest.Payloads.Resp.CreateBooking> response;

        [Given(@"an incomplete booking with first name ""(.*)""")]
        public void GivenAnIncompleteBookingWithFirstName(string p0)
        {
            payload.firstname = p0;
        }
        
        [Given(@"also with last name ""(.*)""")]
        public void GivenAlsoWithLastName(string p0)
        {
            payload.lastname = p0;
        }
        
        [Given(@"also with the deposit being paid is ""(.*)""")]
        public void GivenAlsoWithTheDepositBeingPaidIs(string p0)
        {
            payload.depositpaid = bool.Parse(p0);
        }
        
        [Given(@"also with check in date ""(.*)""")]
        public void GivenAlsoWithCheckInDate(string p0)
        {
            payload.bookingdates = new BookingDates() { checkin = p0 };
        }
        
        [Given(@"also with check out date ""(.*)""")]
        public void GivenAlsoWithCheckOutDate(string p0)
        {
            payload.bookingdates.checkout = p0;
        }
        
        [Given(@"also with additional needs of ""(.*)""")]
        public void GivenAlsoWithAdditionalNeedsOf(string p0)
        {
            payload.additionalneeds = p0;
        }
        
        [When(@"the request is sent to register the booking with a missing field")]
        public void WhenTheRequestIsSentToRegisterTheBookingWithAMissingField()
        {
            BookerCrudClient client = new BookerCrudClient();
            response = client.CreateBooking<WebAPITest.Payloads.Req.Booking_BadReq>(payload);
        }
        
        [Then(@"the response should show the creating process has failed")]
        public void ThenTheResponseShouldShowTheCreatingProcessHasFailed()
        {
            Assert.AreEqual(500, (int)response.StatusCode);
         
        }
    }
}
