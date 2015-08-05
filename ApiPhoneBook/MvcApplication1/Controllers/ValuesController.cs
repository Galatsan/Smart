using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MvcApplication1.Models;
using System.Data;

namespace MvcApplication1.Controllers
{
    public class ValuesController : ApiController
    {
        NumberContext nm = new NumberContext();
        public IEnumerable<Number> Get()
        {
            return nm.Numbers.OrderBy(i => i.SecondName);
        }

        public Number Get(int id)
        {
            return nm.Numbers.Find(id);
        }

        public void Post([FromBody]Number number)
        {
            nm.Numbers.Add(number);
            nm.SaveChanges();
        }

        public void Put(int id, [FromBody]Number number)
        {
            if (id == number.Id)
            {
                Number old = Get(id);
                old.FirstName = number.FirstName;
                old.SecondName = number.SecondName;
                old.DataChange = number.DataChange;
                nm.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            Number num = nm.Numbers.Find(id);
            if (num != null)
            {
                nm.Numbers.Remove(num);
                nm.SaveChanges();
            }
        }
    }
}