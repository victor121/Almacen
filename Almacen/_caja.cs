using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almacen
{
    public partial class caja
    {
        public bool ingresarDinero(int plata)
        {
            var bd = new BD();
            var tablaCaja = bd.caja;
	    if (tablaCaja.Count() == 0)
        	        {
                	    caja cajita = new caja();
    	                    cajita.dinero = plata;
	                    bd.caja.Add(cajita);
	                    bd.SaveChanges();
	                }
            foreach (var caja in tablaCaja)
            {           
                caja.dinero = caja.dinero + plata;
                return true;
            }
            bd.SaveChanges();
            return false;
        }
 
        public bool sacarDinero(int plata)
        {
            var bd = new BD();
            var tablaCaja = bd.caja;
            foreach(var caja in tablaCaja)
            {
                if(plata<=caja.dinero)
                {
                    caja.dinero = caja.dinero - plata;
                    bd.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
            bd.SaveChanges();
        }
    }
}
