using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RestSharp;
using API_Inst.Model;
using Microsoft.Extensions.Logging;
using System.Web.Http;
using System.Text.Json;
using Newtonsoft.Json;
using JsonSerializer = Newtonsoft.Json.JsonSerializer;
using Newtonsoft.Json.Linq;

namespace API_Inst.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class InstagramData : ControllerBase

    {
        [HttpGet(Name = "InstagramData")]

        public async Task<Data> GetResult(string username, string user_id)
        {
            var options = new RestClientOptions($"https://instagram-data1.p.rapidapi.com/followers?username={username}&user_id={user_id}");
            var request = new RestClient(options);
            var getPayload = new RestRequest
            {
                Method = Method.Get,
            };
            getPayload.AddHeader("X-RapidAPI-Key", $"{Constants.Constants.apikey_data}");
            getPayload.AddHeader("X-RapidAPI-Host", $"{Constants.Constants.address_data}");
            var response = await request.ExecuteAsync(getPayload);
            var userList = JsonConvert.DeserializeObject<Data>(response.Content);
            return userList;

        }

    }
}
