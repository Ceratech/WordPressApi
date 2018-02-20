using Refit;

namespace WordPressApi.Services
{
  /// <summary>
  /// Construct WordPress services
  /// </summary>
  public class WordPressServiceFactory
  {
    /// <returns>WordPressService instance</returns>
    /// <param name="baseUrl">WordPress Base URL</param>
    public static IWordPressService Create(string baseUrl)
    {
      return RestService.For<IWordPressService>(baseUrl);
    }
  }
}
