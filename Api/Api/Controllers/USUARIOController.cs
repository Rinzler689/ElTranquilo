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
    public class USUARIOController : ApiController
    {
        public IEnumerable<USUARIO> Get()
        {
            using (ElTranquiloEntities objEntidad = new ElTranquiloEntities())
            {
                return objEntidad.USUARIO.ToList();
            }
        }

        /* // GET: api/USUARIO/5
         public string Get(int id)
         {
             return "value";
         }*/

        // POST: api/USUARIO
        public HttpResponseMessage Post([FromBody] USUARIO objUsuario)
        {
            EntityState operacion = EntityState.Added;
            return operar(objUsuario, operacion);
        }

        // PUT: api/USUARIO/5
        public HttpResponseMessage Put([FromBody] USUARIO objUsuario)
        {
            EntityState operacion = EntityState.Modified;
            return operar(objUsuario, operacion);
        }

        // DELETE: api/USUARIO/5
        public HttpResponseMessage Delete([FromBody] USUARIO objUsuario)
        {
            EntityState operacion = EntityState.Deleted;
            return operar(objUsuario, operacion);
        }

        private HttpResponseMessage operar([FromBody] USUARIO objUsuario, EntityState operacion)
        {
            int resp = 0;
            HttpResponseMessage objMenRespuesta = null;
            try
            {
                using (ElTranquiloEntities objEntidad = new ElTranquiloEntities())
                {
                    objEntidad.Entry(objUsuario).State = operacion;
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
