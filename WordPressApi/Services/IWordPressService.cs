using System;
using System.Collections.Generic;
using Refit;
using WordPressApi.Models;

namespace WordPressApi.Services
{
  /// <summary>
  /// WordPress JSON REST API
  /// </summary>
  public interface IWordPressService
  {
    /// <summary>
    /// Fetch all categories from WP
    /// </summary>
    /// <returns>List with categories</returns>
    [Get("/wp-json/wp/v2/categories")]
    IObservable<IEnumerable<Category>> GetCategories();

    /// <summary>
    /// Fetches all posts for a specific category
    /// </summary>
    /// <returns>The category posts.</returns>
    /// <param name="categoryId">Category id</param>
    [Get("/wp-json/wp/v2/posts")]
    IObservable<IEnumerable<Post>> GetCategoryPosts([AliasAs("categories")] long categoryId);
  }
}
