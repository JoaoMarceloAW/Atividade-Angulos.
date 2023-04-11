using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Atividade_Angulos_
{
    internal class Angulo
    {
    
    public    int ladoa;
    public    int ladob;
     public   int ladoc;

        public string Calculo()
        {

            string resultado;

          
           if (ladoa == ladob || ladoa == ladoc || ladob == ladoc)
            {

                resultado = "Equilatero";
            }
         else  if (ladoa != ladob || ladoa != ladoc || ladob != ladoc)
            { 
                resultado = "Escaleno";
               
              

            }
           else
            {
                resultado = "Isósceles";
            }
            return resultado;
           
        }
               

    }
}
