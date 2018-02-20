using Newtonsoft.Json;
using NUnit.Framework;
using WordPressApi.Models;

namespace WordPressApiTests.Models
{
  [TestFixture()]
  public class RenderedTest
  {
    string json = @"{
      'rendered': 'Test string'
    }";

    [Test()]
    public void TestDeserialize()
    {
      var obj = JsonConvert.DeserializeObject<Rendered>(json);

      Assert.IsNotNull(obj);
      Assert.AreEqual("Test string", obj.Content);
    }
  }
}
