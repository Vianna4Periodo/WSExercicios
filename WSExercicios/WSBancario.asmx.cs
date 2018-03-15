using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WSExercicios
{
    /// <summary>
    /// Summary description for WSBancario
    /// </summary>
    [WebService(Namespace = "http://WSBancario.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WSBancario : System.Web.Services.WebService
    {

        [WebMethod]
        public string NovoCliente(string nome, string cpf, double saldo_inicial)
        {
            if(saldo_inicial > 0 && !String.IsNullOrEmpty(cpf) && !String.IsNullOrEmpty(nome))
            {
                var conta = new Random();
                return "Cliente: " + nome + " - " + cpf + " --> Conta: " + conta.Next(000000,999999).ToString();
            }
            else
            {
                throw new Exception("Nome e CPF são obrigatórios o saldo nao pode ser menor que zero.");
            }
        }
    }
}
