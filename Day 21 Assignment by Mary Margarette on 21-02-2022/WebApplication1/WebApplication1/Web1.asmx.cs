using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebApplication1
{
    /// <summary>
    /// Summary description for Web1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Web1 : System.Web.Services.WebService
    {

        

        [WebMethod]
        public int Add(int a, int b)
        {
            return a+b;
        }

        [WebMethod]
        public int Mul(int c, int d)
        {
            return c*d;
        }

        [WebMethod]
        public int Div(int e, int f)
        {
            return e / f;
        }

        [WebMethod]
        public int Factorial(int n)
        {
            int fact = 1;
            for(int i = 1; i <= n; i++)
            {
                fact = fact*i;
            }
            return fact;
        }
    }
}
