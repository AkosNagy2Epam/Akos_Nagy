using System;
using System.Collections.Generic;
using System.Text;

namespace WebAPITest
{
    public static class Endpoints
    {
        public const string createBooking = "/booking";
        public const string getBooking = "/booking/{id}";
        public const string updateBooking = "/booking/{id}";
        public const string deleteBooking = "/booking/{id}";
        public const string createToken = "/auth";

    }
}
