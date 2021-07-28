using Newtonsoft.Json;
using RestSharp;
using TestProject1.Authorization;

namespace TestProject1
{
    public class BaseAPI
    {
       public static string baseurl = "http://api.qaauto.co.nz/api";
       public static string version = "v1";
       public static string token = "";
       // [OneTimeSetUp]
        public void Setup()
        {
            User user = new User();
            user.email = "user6@sector36.com";
            user.password = "user@006";
            // convert to json string
            string auth = JsonConvert.SerializeObject(user);
            token = GetAuthToken(auth);
        }
        // Authorization
        public string GetAuthToken(string auth)
        {
            var client = new RestClient($"{baseurl}/{version}/auth/login");
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("application/json", auth, ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            string jsonData = response.Content;
            Token data = JsonConvert.DeserializeObject<Token>(jsonData);
            return data.access_token;



        }
    }
}