using Newtonsoft.Json;
using NUnit.Framework;
using WordPressApi.Models;

namespace WordPressApiTests.Models
{
  [TestFixture()]
  public class PostTest
  {
    string json = @"{
      'id': '1',
      'title': {
        'rendered': 'Titel'
      },
      'content': {
        'rendered': 'Content'
      }
    }";

    [Test()]
    public void TestDeserialize()
    {
      var obj = JsonConvert.DeserializeObject<Post>(json);

      Assert.NotNull(obj);
      Assert.AreEqual("Titel", obj.Title.Content);
    }
  }
}
