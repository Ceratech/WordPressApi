﻿using System;
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
    public string Title { get; set; }
    [JsonProperty("content")]
    public string Content { get; set; }
  }
}
