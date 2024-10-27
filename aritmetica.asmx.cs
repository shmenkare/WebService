using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.EnterpriseServices;

namespace wsAritmetica
{
    /// <summary>
    /// Descripción breve de aritmetica
    /// </summary>
    [WebService(Description = "WS que suma y resta",Namespace = "http://sitio.com/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio Web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class aritmetica : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod(BufferResponse= true, Description="suma de dos enteros", TransactionOption= TransactionOption.Required)]
        public int Suma(int a, int b)
        {
            ContextUtil.SetAbort();
            ContextUtil.SetComplete();
            
            return a + b;
        }
          
        
        [WebMethod(BufferResponse = true, Description = "resta de dos enteros", TransactionOption = TransactionOption.Required)]
        public int Resta(int a, int b)
        {
            ContextUtil.SetAbort();
            ContextUtil.SetComplete();
            
            return a - b;
        }

        [WebMethod(BufferResponse = true, Description = "division de dos enteros", TransactionOption = TransactionOption.Required)]
        public double Division(int a, int b)
        {
            ContextUtil.SetAbort();
            ContextUtil.SetComplete();

            return (double)a / (double)b;
        }
      
      

    }
    
}