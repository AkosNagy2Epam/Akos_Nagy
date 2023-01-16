using System;
using System.Collections.Generic;
using System.Text;

namespace WebAPITest.Payloads.Req
{
    public class Booking_BadReq
    {       //It is the same as Booking but with missing totalprice field
        public string firstname { get; set; }
        public string lastname { get; set; }
        //public int totalprice { get; set; }
        public bool depositpaid { get; set; }
        public BookingDates bookingdates { get; set; }
        public string additionalneeds { get; set; }

    }
}
