﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using RestSharp;
using System.Web;

namespace InventarioElTranquilo
{
    public class DbApi
    {
        public static dynamic Get(string urlApi)
        {
            try
            {
                HttpWebRequest objPedido = (HttpWebRequest)WebRequest.Create(urlApi);
                objPedido.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:23.0) Gecko/20100101 Firefox/23.0";
                //objPedido.CookieContainer = myCookie;
                objPedido.Credentials = CredentialCache.DefaultCredentials;
                objPedido.Proxy = null;
                HttpWebResponse objRespuesta = (HttpWebResponse)objPedido.GetResponse();
                Stream objFlujo = objRespuesta.GetResponseStream();
                StreamReader objFlujoLectura = new StreamReader(objFlujo);
                //Leemos los datos
                string datosJson = HttpUtility.HtmlDecode(objFlujoLectura.ReadToEnd());
                dynamic datos = JsonConvert.DeserializeObject(datosJson);
                return datos;
            }
            catch (Exception e)
            {
                dynamic datos = e.ToString();
                return datos;
            }
        }
        public static dynamic Post(string urlApi, string json, string autorizacion = null)
        {
            Method op = Method.Post;
            return operaciones(urlApi, json, autorizacion = null, op);
        }
        public static dynamic Put(string urlApi, string json, string autorizacion = null)
        {
            Method op = Method.Put;
            return operaciones(urlApi, json, autorizacion = null, op);
        }
        public static dynamic Delete(string urlApi, string json, string autorizacion = null)
        {
            Method op = Method.Delete;
            return operaciones(urlApi, json, autorizacion = null, op);
        }
        private static dynamic operaciones(string urlApi, string json, string autorizacion, Method op)
        {
            try
            {
                var objCliente = new RestClient(urlApi);
                var objPedido = new RestRequest();
                objPedido.Method = op;
                objPedido.AddHeader("content-type", "application/json");
                objPedido.AddParameter("application/json", json, ParameterType.RequestBody);
                if (autorizacion != null)
                {
                    objPedido.AddHeader("Authorization", autorizacion);
                }
                RestResponse objRespuesta = objCliente.Execute(objPedido);
                dynamic datos = JsonConvert.DeserializeObject(objRespuesta.Content);
                return datos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
    }
}
