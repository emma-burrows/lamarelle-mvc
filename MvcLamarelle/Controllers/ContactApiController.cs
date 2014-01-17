using MvcLamarelle.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MvcLamarelle.Controllers
{
  public class ContactApiController : ApiController
  {
    private ContactsDBContext db = new ContactsDBContext();

    // GET api/contactapi
    public IEnumerable<string> Get()
    {
      string[] contacts = db.Contacts.ToList().Select(c => c.Nom).ToArray();
      return contacts ;
    }

    // GET api/contactapi/5
    public string Get(int id)
    {
        return "value";
    }

    // POST api/contactapi
    public void Post([FromBody]string value)
    {
    }

    // PUT api/contactapi/5
    public void Put(int id, [FromBody]string value)
    {
    }

    // DELETE api/contactapi/5
    public void Delete(int id)
    {
    }
  }
}
