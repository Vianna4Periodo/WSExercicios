using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WSExercicios
{
    /// <summary>
    /// Summary description for WSFisica
    /// </summary>
    [WebService(Namespace = "http://WSFisica.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WSFisica : System.Web.Services.WebService
    {

        [WebMethod]
        public double VelocidadeMedia(double Distancia, int tempo)
        {
            return Distancia / tempo;
        }

        [WebMethod]
        public double Aceleracao(double Velocidade, int tempo)
        {
            return Velocidade / tempo;
        }

        [WebMethod]
        public double Forca(double massa, int aceleracao)
        {
            return massa*aceleracao;
        }
    }
}
//Velocidade Média entrará com a Distancia e tempo: V = S /  T;
//Aceleração(entradas: Velocidade e Tempo) : A = V / T
//Força: (entradas: massa e aceleração): F = m* a;
