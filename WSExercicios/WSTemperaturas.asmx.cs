using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WSExercicios
{
    /// <summary>
    /// Summary description for WSTemperaturas
    /// </summary>
    [WebService(Namespace = "http://WSTemperaturas.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WSTemperaturas : System.Web.Services.WebService
    {

        [WebMethod]
        public double CelsiusToFahrenheit(double TempInCelsius)
        {
            return  (TempInCelsius*1.8)+32;
        }

        [WebMethod]
        public double FahrenheitToCelsius(double TempInFahrenheit)
        {
            return (TempInFahrenheit - 32) / 1.8;
        }

        [WebMethod]
        public double CelsiusToKelvin(double TempInCelsius)
        {
            return TempInCelsius + 273;
        }

        [WebMethod]
        public double KelvinToCelsius(double TempInKelvin)
        {
            return TempInKelvin - 273;
        }
    }
}

