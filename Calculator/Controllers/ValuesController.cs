using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Calculator.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
        // GET api/values/5
        public string Get(int id)
        {
            return "value "+id;
        }

        // GET api/values/
        //Created method that returns the sum betwen 2 values.
        public string Get(double value1, double value2)
        {
            string sum = Convert.ToString(value1 + value2);
            return sum;
        }
        
        // POST api/values
        public void Post([FromBody] string value)
        {
        }
        // Post api/values
        //Created method that returns the subtraction betwen 2 values.
        public double Post(double value1, double value2)
        {
            if (value2 >= 0)
            {
                return value1 / value2;
            }
            else
            {
                return 0;        
            }

        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {

        }
        // Put /api/values
        //Created method that returns the subtraction betwen 2 values.
        public double Put(double value1, double value2)
        {
                return value1 * value2;
        }

        // DELETE api/values/5
        public void Delete(int id)
        {

        }
        // DELETE api/values
        //Created method that returns the subtraction betwen 2 values.
        public double Delete(double value1, double value2)
        {
            return value1 - value2;
        }
    }
}
