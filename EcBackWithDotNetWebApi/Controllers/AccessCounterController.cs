using EcBackWithDotNetWebApi.Entities;
using EcBackWithDotNetWebApi.Models;
using EcBackWithDotNetWebApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EcBackWithDotNetWebApi.Controllers
{
    public class AccessCounterController : ApiController
    {

        private IEbiRepository<access_counter_db> _repAccessCounterDb;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="repAccessCounterDb"></param>
        public AccessCounterController(IEbiRepository<access_counter_db> repAccessCounterDb)
        {

            _repAccessCounterDb = repAccessCounterDb;

        }

        // GET: api/AccessCounter
        public IEnumerable<AccessCountViewModel> Get()
        {
            return _repAccessCounterDb
                .GetAll()
                .Select(a => new AccessCountViewModel()
                {
                    PageId = a.pageid,
                    ADate = a.adate,
                    Url = a.url
                });

        }

        // GET: api/AccessCounter/5
        public AccessCountViewModel Get(int id)
        {
            access_counter_db entity = _repAccessCounterDb.Get(id);

            if (entity != null)
            {
                return new AccessCountViewModel()
                {
                    PageId = entity.pageid,
                    ADate = entity.adate,
                    Url = entity.url
                };
            }
            else
            {
                return null;
            }
            

        }

        // POST: api/AccessCounter
        public void Post([FromBody]AccessCountBindingModel value)
        {
            _repAccessCounterDb.Insert(new access_counter_db(){ pageid = "a", adate = value.ADate, url = value.Url});
        }

        // PUT: api/AccessCounter/5
        public void Put(string id, [FromBody]AccessCountBindingModel value)
        {
            access_counter_db entity = _repAccessCounterDb.Get(int.Parse(id));

            if (entity != null)
            {
                _repAccessCounterDb.Update(entity, new access_counter_db()
                {
                    pageid = id,
                    adate = value.ADate,
                    url = value.Url
                });
            }
            else
            {
                throw new HttpResponseException(
                    new HttpRequestMessage().CreateErrorResponse(HttpStatusCode.NotFound, ""));
            }
        }

        // DELETE: api/AccessCounter/5
        public void Delete(string id)
        {
            access_counter_db entity = _repAccessCounterDb.Get(int.Parse(id));

            if (entity != null)
            {
                _repAccessCounterDb.Delete(int.Parse(id));
            }
            else
            {
                throw new HttpResponseException(
                    new HttpRequestMessage().CreateErrorResponse(HttpStatusCode.NotFound, ""));
            }
        }
    }
}
