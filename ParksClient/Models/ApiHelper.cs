using System.Threading.Tasks;
using RestSharp;

namespace ParksClient.Models
{
  class ApiHelper
  {
    public static async Task<string> GetAll()
    {
      RestClient client = new("http://localhost:5000/api");
      RestRequest request = new("parks", Method.GET);
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
  }
}