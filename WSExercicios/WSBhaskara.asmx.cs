using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WSExercicios
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://WSBhaskara.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string Bhaskara(int a, int b, int c)
        {
            double raizUm;
            double raizDois;
            raizUm = ((-b) + Math.Sqrt(b*b) - (4 * a * c)) / (2 * a);
            raizDois = ((-b) - Math.Sqrt(b * b) - (4 * a * c)) / (2 * a);
            var dict = new List<double>();
            dict.Add(raizUm);
            dict.Add(raizDois);
            return "Raiz um: " + dict[0] + ". Raiz dois: " + dict[1];
        }
    }
}
