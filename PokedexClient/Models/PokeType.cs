using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace PokedexClient.Models
{
  public class PokeType
  {
    public PokeType()
    {
      this.Pokemon = new HashSet<Pokemon>();
    }
    public int PokeTypeId { get; set; }
    public string PokeTypeName { get; set; }
    public ICollection<Pokemon> Pokemon { get; set; }

    public static List<PokeType> GetPokeTypes()
    {
      var apiCallTask = ApiHelper.GetAll();
      var result = apiCallTask.Result;

      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<PokeType> pokeList = JsonConvert.DeserializeObject<List<PokeType>>(jsonResponse.ToString());

      return pokeList;
    }
    public static PokeType GetDetails(int id)
    {
      vArgIterator apiCallTask = ApiHelper.Get(id);
      var result = apiCallTask.Result;

      JObject jsonResponse = JsonConvert.DeserializeObject<PokeType>(jsonResponse.ToString());

      return review;
    }
  }
}