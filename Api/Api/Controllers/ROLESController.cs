using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Conector;

namespace Api.Controllers
{
    public class ROLESController : ApiController
    {
        public IEnumerable<ROLES> Get()
        {
            using (ElTranquiloEntities objEntidad = new ElTranquiloEntities())
            {
                return objEntidad.ROLES.ToList();
            }
        }

        /* // GET: api/ROLES/5
         public string Get(int id)
         {
             return "value";
         }*/

        // POST: api/ROLES
        public HttpResponseMessage Post([FromBody] ROLES objRoles)
        {
            EntityState operacion = EntityState.Added;
            return operar(objRoles, operacion);
        }

        // PUT: api/ROLES/5
        public HttpResponseMessage Put([FromBody] ROLES objRoles)
        {
            EntityState operacion = EntityState.Modified;
            return operar(objRoles, operacion);
        }

        // DELETE: api/PRODUCTO/5
        public HttpResponseMessage Delete([FromBody] ROLES objRoles)
        {
            EntityState operacion = EntityState.Deleted;
            return operar(objRoles, operacion);
        }

        private HttpResponseMessage operar([FromBody] ROLES objRoles, EntityState operacion)
        {
            int resp = 0;
            HttpResponseMessage objMenRespuesta = null;
            try
            {
                using (ElTranquiloEntities objEntidad = new ElTranquiloEntities())
                {
                    objEntidad.Entry(objRoles).State = operacion;
                    resp = objEntidad.SaveChanges();
                    objMenRespuesta = Request.CreateResponse(HttpStatusCode.OK, resp);
                }
            }
            catch (Exception er)
            {
                objMenRespuesta = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, er.Message);
            }
            return objMenRespuesta;
        }
    }
}
