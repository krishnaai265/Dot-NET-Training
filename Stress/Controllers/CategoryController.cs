using Newtonsoft.Json;
using Stress.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;

namespace Stress.Controllers
{
    [RoutePrefix("api/Category")]
    public class CategoryController : ApiController
    {
        SopraDBEntities d = new SopraDBEntities();

        [HttpGet]
        [Route("find")]
        public HttpResponseMessage ABC()
        {
            try
            {
                // var c = d.customers.Find(id);

                var c = d.Category.ToList();
                var response = new HttpResponseMessage(HttpStatusCode.OK);
                             response.Content = new StringContent(JsonConvert.SerializeObject(c));
                             response.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                             return response;
      //          return c;
            }
            catch
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest);
            }
        }
        [HttpGet]
        [Route("find/{id}")]
        public HttpResponseMessage ABC(int id)
        {
            try
            {
                var c = d.Category.Find(id);
                //          var c = d.customers.Where(d=>d.id==id).SingleOrDefault();
                //   var c = d.customers.ToList();
                var response = new HttpResponseMessage(HttpStatusCode.OK);
                response.Content = new StringContent(JsonConvert.SerializeObject(c));//Given the structured format of Json
                response.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");//To access JSON we need to give MediaTypeHeaderValue
                return response;
            }
            catch
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest);
            }
        }
        [HttpPost]
        [Route("remove/{id}")]
        public HttpResponseMessage DeleteABC(int id)
        {
            try
            {
                var response = new HttpResponseMessage(HttpStatusCode.OK);
                var c = d.Category.Find(id);
                //          var c = d.customers.Where(d=>d.id==id).SingleOrDefault();
                //   var c = d.customers.ToList();

                d.Category.Remove(c);
                d.SaveChanges();
                return response;
            }
            catch
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest);
            }
        }
        [HttpPost]
        [Route("update/{id}")]
        public HttpResponseMessage UpdateABC(Category value)
        {
            try
            {
                var response = new HttpResponseMessage(HttpStatusCode.OK);
                var c = d.Category.Find(value.CategoryId);
                //          var c = d.customers.Where(d=>d.id==id).SingleOrDefault();
                //   var c = d.customers.ToList();
                c.CategoryName = value.CategoryName;
                c.CategoryAddedDate = value.CategoryAddedDate;
                

                d.SaveChanges();
                return response;
            }
            catch
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest);
            }
        }

        [HttpPost]
        [Route("add/{id}")]
        public HttpResponseMessage AddABC(Category value)
        {
            try
            {
                var response = new HttpResponseMessage(HttpStatusCode.Created);
                // var c = d.customers.Find(id);
                //          var c = d.customers.Where(d=>d.id==id).SingleOrDefault();
                //   var c = d.customers.ToList();
                d.Category.Add(value);
                // d.customers.Remove(c);
                d.SaveChanges();
                return response;
            }
            catch
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest);
            }
        }
    }
}
