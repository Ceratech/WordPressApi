using System;
using System.Collections.Generic;
using Refit;
using WordPressApi.Models;

namespace WordPressApi.Services
{
  /// <summary>
  /// WordPress JSON REST API definitie
  /// </summary>
  public interface IWordPressService
  {
    /// <summary>
    /// Lijst met categorieën ophalen uit WP
    /// </summary>
    /// <returns>Lijst met categorieën</returns>
    [Get("/wp-json/wp/v2/categories")]
    IObservable<IEnumerable<Category>> GetCategories();

    /// <summary>
    /// Posts voor category ophalen
    /// </summary>
    /// <returns>De category posts.</returns>
    /// <param name="categoryId">Category id</param>
    [Get("/wp-json/wp/v2/posts")]
    IObservable<IEnumerable<Post>> GetCategoryPosts([AliasAs("categories")] long categoryId);
  }
}
