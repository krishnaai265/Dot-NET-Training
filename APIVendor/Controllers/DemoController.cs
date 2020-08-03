using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APIVendor.Controllers
{
    public class DemoController : ApiController
    {
        static List<string> l = new List<string>()
        {
            "ABC",
            "DEF",
            "GHI"
        };
        public IEnumerable<string> Get() { return l; }
        public string Get(string id) { return string.Format("Krishna = "+id); }
        public void Post([FromBody]string value){ l.Add(value);  }
        public void Put(int id, [FromBody]string value){ l[id] = value;  }
        public void Delete([FromUri]int id){ l.RemoveAt(id);    }
    }
}
