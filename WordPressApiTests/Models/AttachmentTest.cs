
using Newtonsoft.Json;
using NUnit.Framework;
using WordPressApi.Models;

namespace WordPressApiTests.Models
{
  [TestFixture()]
  public class AttachmentTest
  {
    string json = @"{
      'id': 1, 
      'media_type': 'image', 
      'title': {
        'rendered': 'title'
      }
    }";

    [Test()]
    public void TestDeserialize()
    {
      var obj = JsonConvert.DeserializeObject<Attachment>(json);

      Assert.IsNotNull(obj);
      Assert.AreEqual("image", obj.MediaType);
    }
  }
}
