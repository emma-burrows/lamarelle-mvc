using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net.Http;
using System.Collections.Generic;

namespace MvcLamarelle.Tests.Controllers
{
  [TestClass]
  public class ContactApiControllerTest
  {
    private HttpClient _client;

    [TestInitialize]
    public void TestInitialise()
    {
      _client = ApiClient.GetAuthenticatedClient();
    }

    [TestMethod]
    public void contactIndexReturnsStringArray()
    {
      var list = _client
                  .GetAsync("api/ContactApi")
                  .Result.Content.ReadAsAsync<IEnumerable<string>>()
                  .Result;

      Assert.IsTrue(list.Any());
    }
  }
}
