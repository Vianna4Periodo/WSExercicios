using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WSExercicios
{
    /// <summary>
    /// Summary description for WSCalculadora
    /// </summary>
    [WebService(Namespace = "http://wscalculadora.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WSCalculadora : System.Web.Services.WebService
    {

        [WebMethod]
        public double SomaNumeros(double a, double b)
        {
            return a + b;
        }

        [WebMethod]
        public double SubtraiNumeros(double minuendo, double subtraendo)
        {
            return minuendo - subtraendo;
        }

        [WebMethod]
        public double MultiplicaNumeros(double multiplicador, double multiplicando)
        {
            return multiplicador * multiplicando;
        }

        [WebMethod]
        public double? DivisaoNumeros(double dividendo, double divisor)
        {
            try
            {
                return dividendo / divisor;
            }

            catch(Exception ex)
            {
                throw new Exception("Aposto que tentou dividir por zero... ", ex);
            }
                
        }

        [WebMethod]
        public bool IsPar(int n)
        {
            return n % 2 == 0 ? true : false;
        }

        [WebMethod]
        public Int64 Fatorial(int n)
        {
            if (n > 1)
                return n * Fatorial(n - 1);
            else
                return 1;
        }

        [WebMethod]
        public bool IsPrimo(int n)
        {
            for (int i = 2; i < n; i++)
            {
                if (n == 2)
                    return true;
                if (n % i != 0)
                    continue;
                else
                    return false;
            }
            return true;
        }

        [WebMethod]
        public Int64 Poetenciacao(int Base, int Expoente)
        {
            Int64 x = Base;
            Expoente--;
            while (Expoente > 0)
            {
                x *= Base;
                Expoente--;
            }

            return x;
        }

    }
}
