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
    public class PRODUCTOController : ApiController
    {
        // GET: api/PRODUCTO
        public IEnumerable<PRODUCTO> Get()
        {
            using (ElTranquiloEntities objEntidad = new ElTranquiloEntities())
            {
                return objEntidad.PRODUCTO.ToList();
            }
        }

        /* // GET: api/PRODUCTO/5
         public string Get(int id)
         {
             return "value";
         }*/

        // POST: api/PRODUCTO
        public HttpResponseMessage Post([FromBody] PRODUCTO objProducto)
        {
            EntityState operacion = EntityState.Added;
            return operar(objProducto, operacion);
        }

        // PUT: api/PRODUCTO/5
        public HttpResponseMessage Put([FromBody] PRODUCTO objProducto)
        {
            EntityState operacion = EntityState.Modified;
            return operar(objProducto, operacion);
        }

        // DELETE: api/PRODUCTO/5
        public HttpResponseMessage Delete([FromBody] PRODUCTO objProducto)
        {
            EntityState operacion = EntityState.Deleted;
            return operar(objProducto, operacion);
        }

        private HttpResponseMessage operar([FromBody] PRODUCTO objProducto, EntityState operacion)
        {
            int resp = 0;
            HttpResponseMessage objMenRespuesta = null;
            try
            {
                using (ElTranquiloEntities objEntidad = new ElTranquiloEntities())
                {
                    objEntidad.Entry(objProducto).State = operacion;
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
