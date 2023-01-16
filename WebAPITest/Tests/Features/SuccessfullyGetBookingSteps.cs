using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using WebAPITest;
using WebAPITest.Payloads;

namespace Tests.Features
{
    [Binding]
    public class SuccessfullyGetBookingSteps
    {

        RestSharp.RestResponse<Booking> response;
        BookerCrudClient client = new BookerCrudClient();
        int id = 0;
        Booking payload = new Booking();

        [Given(@"a booking exists with first name ""(.*)""")]
        public void GivenABookingExistsWithFirstName(string p0)
        {
            payload.firstname = p0;
        }
        
        [Given(@"last name ""(.*)""")]
        public void GivenLastName(string p0)
        {
            payload.lastname = p0;
            payload.bookingdates = new BookingDates() { checkin = "2018 - 01 - 01", checkout = "2018 - 02 - 01" };
            payload.additionalneeds = "none";
            payload.depositpaid = false;
            payload.totalprice = 2000;
            id = client.CreateBooking(payload).Data.BookingId;
        }
        
        [When(@"we request its data using its ID")]
        public void WhenWeRequestItsDataUsingItsID()
        {
            response=client.GetBooking(id);
        }
        
        [Then(@"we should get a confirmation code of (.*) and data with the correct name")]
        public void ThenWeShouldGetAConfirmationCodeOfAndDataWithTheCorrectName(int p0)
        {
            Assert.AreEqual(p0,(int)response.StatusCode);
            Assert.AreEqual(payload.firstname,response.Data.firstname);
            Assert.AreEqual(payload.lastname,response.Data.lastname);
        }
    }
}
