using Newtonsoft.Json;

namespace WordPressApi.Models
{
  /// <summary>
  /// WordPress attachment (img etc).
  /// </summary>
  public class Attachment
  {
    [JsonProperty("id")]
    public long Id { get; set; }

    [JsonProperty("media_type")]
    public string MediaType { get; set; }
  }
}
