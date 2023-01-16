using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebAPITest
{
    public interface IBookerCrudClient
    {
        
        //GetBooking returning response payload
        RestResponse<Payloads.Booking> GetBooking(int id);
        //CreateBooking returning response payload
        RestResponse<Payloads.Resp.CreateBooking> CreateBooking<T>(T payload) where T : class;
        //UpdateBooking
        RestResponse UpdateBooking<T>(int id, T payload, string token) where T : class;
        //DeleteBooking
        RestResponse DeleteBooking(int id, string token);
        //CreateToken     returning response payload
        RestResponse<Payloads.Resp.CreateToken> CreateToken<T>(T payload) where T : class;
    }
}
