using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TareaGasolinera;

namespace TareaGasolinera.Clases
{
    public class Gasolina
    {   
        private String tipo;

        public String Tipo
        {
            get { return tipo; }
            set { tipo = value; } 
        }
        private int candtidadDeGalones;

        public int CantidadDeGalones
        {
            get { return candtidadDeGalones; }
            set { candtidadDeGalones = value; }
        }
        private double precio;        
        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }


        double subtotal = 0;
        double iva = 0;
        double total = 0;
        public double SubTotal()
        {
            subtotal = CantidadDeGalones * Precio;
            return subtotal;
        }
        public double IVA()
        {
            iva = subtotal* 12 / 100;
            return iva;
        }
        public double Total()
        {
            total =subtotal+iva;
            return total;
        }

        


    }
}
