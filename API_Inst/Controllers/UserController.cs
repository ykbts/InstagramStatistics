using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RestSharp;
using API_Inst.Model;
using API_Inst.Controllers;
using Microsoft.Extensions.Logging;
using System.Web.Http;
using System.Text.Json;
using Newtonsoft.Json;
using JsonSerializer = Newtonsoft.Json.JsonSerializer;
using Newtonsoft.Json.Linq;
using System.Security.Cryptography;

namespace API_Inst.Controllers
{

    [ApiController]
    [Route("[controller]")]

    public class UserController : ControllerBase

    {

        [HttpGet(Name = "Info")]

        public async Task<User_Info> GetUserInfo(string username) 
        {
            var options = new RestClientOptions("https://rocketapi-for-instagram.p.rapidapi.com/instagram/user/get_info");
            var request = new RestClient(options);
            var postPayload = new RestRequest
            {
                Method = Method.Post,
            };
            postPayload.AddHeader("content-type", "application/json");
            postPayload.AddHeader("X-RapidAPI-Key", $"{Constants.Constants.apikey}");
            postPayload.AddHeader("X-RapidAPI-Host", $"{Constants.Constants.address}");
            var body = "{\r\n    \"username\": \"" + $"{username}" +"\"\r\n}";

            postPayload.AddParameter("application/json", body, ParameterType.RequestBody);
            var response = await request.ExecuteAsync(postPayload);
            var userList = JsonConvert.DeserializeObject<User_Info>(response.Content);
          
            return userList;
        }
  


    }
}
