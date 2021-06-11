using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ParksClient.Models
{
  public class Park
  {
     public int ParkId { get; set; }
    public string Name { get; set; }
    public string State {get; set; }
    public string City {get; set; }
    public int ZipCode {get; set; }
    public string Type {get; set; }

    public static List<Park> GetParks()
    {
      var task = ApiHelper.GetAll();
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
  }
}