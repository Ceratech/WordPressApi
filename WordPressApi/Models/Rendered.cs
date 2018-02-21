using System;
using Newtonsoft.Json;

namespace WordPressApi.Models
{
  /// <summary>
  /// Pre-rendered property (WP API pre-renders titles etc)
  /// </summary>
  public class Rendered
  {
    [JsonProperty("rendered")]
    public string Content { get; set; }
  }
}
