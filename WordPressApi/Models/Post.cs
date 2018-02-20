using Newtonsoft.Json;

namespace WordPressApi.Models
{
  /// <summary>
  /// WordPress Post
  /// </summary>
  public class Post
  {
    [JsonProperty("id")]
    public long Id { get; set; }
    [JsonProperty("title")]
    public Rendered Title { get; set; }
    [JsonProperty("content")]
    public Rendered Content { get; set; }
  }
}
