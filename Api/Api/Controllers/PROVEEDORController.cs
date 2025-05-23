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
    public class PROVEEDORController : ApiController
    {
        // GET: api/PROVEEDOR
        public IEnumerable<PROVEEDOR> Get()
        {
            using (ElTranquiloEntities objEntidad = new ElTranquiloEntities())
            {
                return objEntidad.PROVEEDOR.ToList();
            }
        }

        /* // GET: api/PROVEEDOR/5
         public string Get(int id)
         {
             return "value";
         }*/

        // POST: api/PROVEEDOR
        public HttpResponseMessage Post([FromBody] PROVEEDOR objProveedor)
        {
            EntityState operacion = EntityState.Added;
            return operar(objProveedor, operacion);
        }

        // PUT: api/PROVEEDOR/5
        public HttpResponseMessage Put([FromBody] PROVEEDOR objProveedor)
        {
            EntityState operacion = EntityState.Modified;
            return operar(objProveedor, operacion);
        }

        // DELETE: api/PROVEEDOR/5
        public HttpResponseMessage Delete([FromBody] PROVEEDOR objProveedor)
        {
            EntityState operacion = EntityState.Deleted;
            return operar(objProveedor, operacion);
        }

        private HttpResponseMessage operar([FromBody] PROVEEDOR objProveedor, EntityState operacion)
        {
            int resp = 0;
            HttpResponseMessage objMenRespuesta = null;
            try
            {
                using (ElTranquiloEntities objEntidad = new ElTranquiloEntities())
                {
                    objEntidad.Entry(objProveedor).State = operacion;
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

