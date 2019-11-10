using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaGasolinera.Clases
{
    public class Cliente
    {

       

        private String apellidos;

        public String Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }

        }
        private String nombres;

        public String Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }
        private String numeroDeCedula;

        public String NumeroDeCedula
        {
            get { return numeroDeCedula; }
            set { numeroDeCedula = value; }
        }
        private String direccion;

        public String Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }




    }
}
