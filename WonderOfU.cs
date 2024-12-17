using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    public class WonderOfU
    {
        double impues = 0;
        public string gennamaereci()
        {
            Random rnd = new Random();
            string rndname = rnd.Next(1, 999).ToString();
            string softandwet = "Recibo" + rndname;
            return softandwet;
        }
    }
}
