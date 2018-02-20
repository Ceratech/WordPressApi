using System;
using Newtonsoft.Json;

namespace WordPressApi.Models
{
  /// <summary>
  /// Gerenderde property
  /// </summary>
  public class Rendered
  {
    [JsonProperty("rendered")]
    public string Content { get; set; }
  }
}
