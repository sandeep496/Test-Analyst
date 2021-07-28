using Newtonsoft.Json;
using NUnit.Framework;
using RestSharp;
using System;
using TestProject1.Authorization;
using TestProject1.Methods;

namespace TestProject1
{
    public class Tests
    {
          [Test]
        public void CreateRecordTest()
        {
            Customer expectedcustomer = new Customer();
            expectedcustomer.company_name = "testing";
            expectedcustomer.vat_number = "23456";
            expectedcustomer.phone = "1234567867";
            expectedcustomer.website = "www";
            expectedcustomer.currency = "euro";
            expectedcustomer.country = "nz";
            expectedcustomer.default_language = "english";
            //converting json
            string jsonBody = JsonConvert.SerializeObject(expectedcustomer);
            CustomerAllMethods cust = new CustomerAllMethods();
            IRestResponse responseData = cust.PostCustomer(jsonBody);
            Console.WriteLine(responseData.Content);
            CustomerResponse actualData = JsonConvert.DeserializeObject<CustomerResponse>(responseData.Content);
            Console.WriteLine(actualData.data.id);


        }
       
       
        
        
        
        
    }
}