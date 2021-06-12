using System.Threading.Tasks;
using RestSharp;
using System.Collections.Generic;
using System;
namespace ParksClient.Models
{
  class ApiHelper
  {
    public static async Task<string> GetAll(string name, string state, string city, string type, string zipcode, string radius)
    {
     
      var queryArray = new List<string>();
      if (name != null)
      {
        queryArray.Add($"name={name} ");
      }
       if (state != null)
      {
        queryArray.Add($"state={state} ");
      }
       if (city != null)
      {
        queryArray.Add($"city={city} ");
      }
       if (type != null)
      {
        queryArray.Add($"type={type} ");
      }
       if (zipcode != null)
      {
        queryArray.Add($"zipcode={zipcode} ");
      }
       if (radius != null)
      {
        queryArray.Add($"radius={radius} ");
      }
      var queryString = String.Join("", queryArray.ToArray()).Replace(" ", "&");
      RestClient client = new("http://localhost:5000/api");
      var request = new RestRequest();
      if (queryString != null)
      {
        request = new($"parks?{queryString}", Method.GET);
         
      }
      else
      {
         request = new($"parks", Method.GET);
      }
      
      var response = await client.ExecuteTaskAsync(request);
      
      return response.Content;
    }
     public static async Task<string> GetWithId(int id)
    {
      RestClient client = new("http://localhost:5000/api");
      RestRequest request = new($"parks/{id}", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }
    public static async Task<string> Post(string newPark)
    {
      
      RestClient client = new ("http://localhost:5000/api");
      RestRequest request = new ($"parks", Method.POST);
      request.AddHeader("Content-Type", "application/json");
      request.AddJsonBody(newPark);
      var response = await client.ExecuteTaskAsync(request);
      Console.WriteLine($"Content: {response.Content}");
      return response.Content;
    }
      public static async Task Delete(int id)
    {
      RestClient client = new("http://localhost:5000/api");
      RestRequest request = new($"parks/{id}", Method.DELETE);
      request.AddHeader("Content-Type", "application/json");
      var _ = await client.ExecuteTaskAsync(request);
    }
  }
}