using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject1
{
   public class CustomerAllMethods : BaseAPI
    {
        //Get all customers
        public IRestResponse GetAllRecords()
        {
            string url = $"{baseurl}/{version}/customers";
            var client = new RestClient(url);
            Console.WriteLine(url);
            var request = new RestRequest(Method.GET);
            request.AddHeader("Authorization", $"bearer {token}");
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
            return response;
        }
        //Create/post customers
        public IRestResponse PostCustomer(string body)
        {
            string url = $"{baseurl}/{version}/customers";
            var client = new RestClient(url);
            Console.WriteLine(url);
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Authorization", $"bearer {token}");
            request.AddParameter("application/json", body, ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            return response;
            
        }
            //Delete single record
            public IRestResponse DeleteSingleRecord(string id)
            {
                var client = new RestClient($"{baseurl}/{version}/customers/{id}");
                var request = new RestRequest(Method.DELETE);
                request.AddHeader("Authorization", $" bearer {token}");
                IRestResponse response = client.Execute(request);
            return response;
                
            }
        string updatebody = "{ \"company_name\": \"pcl\", \"vat_number\": \"string\",  \"phone\": \"string\"}";

        //update customers
        public IRestResponse UpdateRecords(string body)
        {
            var client = new RestClient($"{baseurl}/{version}/customers/50");
            var request = new RestRequest(Method.PUT);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Authorization", $" bearer {token}");
            request.AddParameter("application/json", updatebody, ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            return response;
            
        }


    }
}
