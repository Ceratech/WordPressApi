using Newtonsoft.Json;

namespace WordPressApi.Models
{
  /// <summary>
  /// WordPress category
  /// </summary>
  public class Category
  {
    [JsonProperty("id")]
    public long Id { get; set; }
    [JsonProperty("name")]
    public string Name { get; set; }
    [JsonProperty("description")]
    public string Description { get; set; }
    [JsonProperty("slug")]
    public string Slug { get; set; }
  }
}
