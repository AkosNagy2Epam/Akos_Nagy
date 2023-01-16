using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;
using WebAPITest.Payloads;
using WebAPITest.Payloads.Resp;

namespace WebAPITest
{
    public class BookerCrudClient : IBookerCrudClient, IDisposable
    {

        private const string baseUrl= "https://restful-booker.herokuapp.com";
        private readonly RestClient client;

        public BookerCrudClient()
        {
            client = new RestClient(baseUrl);
        }
        public BookerCrudClient(string baseUrl)
        {
            client = new RestClient(baseUrl);
        }
        public RestResponse<CreateBooking> CreateBooking<T>(T payload) where T : class
        {

            RestRequest request = new RestRequest(Endpoints.createBooking, Method.Post);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Accept", "application/json");
            request.AddJsonBody(payload);
            return client.Execute<Payloads.Resp.CreateBooking>(request);

        }

        public RestResponse<CreateToken> CreateToken<T>(T payload) where T : class
        {
            RestRequest request = new RestRequest(Endpoints.createToken, Method.Post);
            request.AddJsonBody(payload);
            return client.Execute<Payloads.Resp.CreateToken>(request);
        }

        public RestResponse DeleteBooking(int id, string token)
        {
            RestRequest request = new RestRequest(Endpoints.deleteBooking, Method.Delete);
            request.AddUrlSegment("id", id);
            request.AddHeader("Cookie", "token=" + token);
            return client.Execute(request);
        }

        public RestResponse<Booking> GetBooking(int id)
        {
            RestRequest request = new RestRequest(Endpoints.getBooking, Method.Get);
            request.AddUrlSegment("id", id);
            request.AddHeader("Accept", "application/json");
            return client.Execute<Booking>(request);


        }

        public RestResponse UpdateBooking<T>(int id, T payload, string token) where T : class
        {
            RestRequest request = new RestRequest(Endpoints.updateBooking, Method.Put);
            request.AddUrlSegment("id", id);
            request.AddHeader("Cookie", "token=" + token);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Accept", "application/json");
            request.AddJsonBody(payload);
            return client.Execute(request);
        }

        public void Dispose()
        {
            client?.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
