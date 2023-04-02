using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda_de_Ropa
{
    class Vendedor
    {
        //Atributos

        private String nombre;
        private String apellido;
        private int codigoVendedor;

        #region //Propiedades
        public String Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }
        public String Apellido
        {
            get
            {
                return apellido;
            }
            set
            {
                apellido = value;
            }
        }
        public int CodigoVendedor
        {
            get
            {
                return codigoVendedor;
            }
            set
            {
                codigoVendedor = value;
            }
        }
        #endregion



    }
}
