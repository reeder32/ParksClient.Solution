using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;

namespace ParksClient.Models
{
  public class Park
  {
     public int ParkId { get; set; }
    public string Name { get; set; }
    public string State {get; set; }
    public string City {get; set; }
    [Range(5,5, ErrorMessage = "Zip Code needs to be 5 characters long")]
    public int ZipCode {get; set; }
    public string Type {get; set; }

    public static List<Park> GetParks(string name, string state, string city, string type, string zipcode, string radius)
    {
      var task = ApiHelper.GetAll(name, state, city, type, zipcode, radius);
      var result = task.Result;
      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<Park> parks = JsonConvert.DeserializeObject<List<Park>>(jsonResponse.ToString());
      return parks;
    }
      public static Park GetWithId(int id)
    {
      var task = ApiHelper.GetWithId(id);
      var result = task.Result;
      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      Park park = JsonConvert.DeserializeObject<Park>(jsonResponse.ToString());
      return park;
    }
      public static Park Post(Park p)
    {
      string jsonPark = JsonConvert.SerializeObject(p);
      var  postPark = ApiHelper.Post(jsonPark);
      var result = postPark.Result;
      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      Park park = JsonConvert.DeserializeObject<Park>(jsonResponse.ToString());
      return park;
    }
  }
}