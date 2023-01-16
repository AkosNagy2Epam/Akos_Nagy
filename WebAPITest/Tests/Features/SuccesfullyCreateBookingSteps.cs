using NUnit.Framework;
using System;
using System.Diagnostics;
using TechTalk.SpecFlow;
using WebAPITest;
using WebAPITest.Payloads;


namespace Tests.Features
{
    [Binding]
    public class SuccesfullyCreateBookingSteps
    {
        Booking payload = new WebAPITest.Payloads.Booking();
        RestSharp.RestResponse<WebAPITest.Payloads.Resp.CreateBooking> response;

        

        [Given(@"a booking with first name ""(.*)""")]
        public void GivenABookingWithFirstName(string fName)
        {      
            payload.firstname = fName;
        }

        [Given(@"with last name ""(.*)""")]
        public void GivenWithLastName(string lName)
        {

            payload.lastname = lName;
        }

        [Given(@"with last total price (.*)")]
        public void GivenWithLastTotalPrice(int price)
        {
            payload.totalprice = price;
        }

        [Given(@"with the deposit being paid is ""(.*)""")]
        public void GivenWithTheDepositBeingPaidIs(string isPaid)
        {
            payload.depositpaid = bool.Parse(isPaid);
        }

        [Given(@"with check in date ""(.*)""")]
        public void GivenWithCheckInDate(string checkIn)
        {
            payload.bookingdates = new BookingDates() { checkin = checkIn };
        }

        [Given(@"with check out date ""(.*)""")]
        public void GivenWithCheckOutDate(string checkOut)
        {
            payload.bookingdates.checkout = checkOut;
        }

        [Given(@"with additional needs of ""(.*)""")]
        public void GivenWithAdditionalNeedsOf(string p0)
        {
            payload.additionalneeds = p0;
        }

        [When(@"the request is sent to register the booking")]
        public void WhenTheRequestIsSentToRegisterTheBooking()
        {

            BookerCrudClient client = new BookerCrudClient();
            response = client.CreateBooking<Booking>(payload);

        }

        [Then(@"the response should confirm the booking got created")]
        public void ThenTheResponseShouldConfirmTheBookingGotCreated()
        {
                        
            Assert.AreEqual(200, (int)response.StatusCode);
                       
        }
        
        
    }
}
