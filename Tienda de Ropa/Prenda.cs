using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda_de_Ropa
{
    class Prenda
    {
        //Atributos
        protected bool premium = false;

        protected float precioUnitario;
        protected int stockTotal;

        #region //Propiedades
        public float PrecioUnitario
        {
            get
            {
                return precioUnitario;
            }
            set
            {
                precioUnitario = value;
            }
        }
        public int StockTotal
        {
            get
            {
                return stockTotal;
            }
            set
            {
                stockTotal = value;
            }
        }   
        public bool Premium
        {
            get
            {
                return premium;
            }
            set
            {
                premium = value;
            }
        }
        #endregion

    }
}
