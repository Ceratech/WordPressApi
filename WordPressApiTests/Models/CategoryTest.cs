using Newtonsoft.Json;
using NUnit.Framework;
using WordPressApi.Models;

namespace WordPressApiTests.Models
{
  [TestFixture()]
  public class CategoryTest
  {
    string json = @"{
      'id': 1234,
      'name': 'test',
      'slug': 'test',
      'description': 'description'
    }";

    [Test()]
    public void TestDeserialize()
    {
      var obj = JsonConvert.DeserializeObject<Category>(json);

      Assert.IsNotNull(obj);
      Assert.AreEqual(1234, obj.Id);
      Assert.AreEqual("test", obj.Name);
    }
  }
}
