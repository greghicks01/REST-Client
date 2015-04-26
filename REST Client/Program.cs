using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.NetworkInformation;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Grapevine.Client;
using Newtonsoft.Json;

namespace REST_Client
{
    class Program
    {
        static void Main(string[] args)
        {
            RESTClient gc = new RESTClient("http://localhost:1234");
            //gc.NetworkCredentials = new Grapevine.NetworkCredential("username", "password");
            //var cookie = new Grapevine.Cookie("sessionid", "A113");
            //gc.Cookies.Add(cookie);
            var request = new RESTRequest("/user/{id}");
            request.AddParameter("id", "1234");
            request.Method = Grapevine.HttpMethod.GET;
            request.ContentType = Grapevine.ContentType.JSON;
            request.Payload = "{\"key\":\"value\"}";
            request.ContentType = Grapevine.ContentType.JSON;
            request.Payload = "{\"key\":\"value\"}";
            var response = gc.Execute(request);
        }
    }
}
