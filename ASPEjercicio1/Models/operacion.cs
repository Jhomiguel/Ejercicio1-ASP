using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;

namespace ASPEjercicio1.Models
{
    public class operacion
    {
       public int numero { get; set; }
       

        public static int InvertirNum(int num)
        { 
                string numS = num.ToString();
                char[] c = new char[2];
                c[0] = numS[1];
                c[1] = numS[0];
                string result = new string(c);      
                return int.Parse(result);
        }
    }
}