using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda_de_Ropa
{
    class Pantalones : Prenda
    {
        //Atributos
        public bool chupin = false;

        public int pantalonesChupinesPremium = 750;
        public int pantalonesChupines = 750;
        public int pantalonesChupinesTotales;

        public int pantalonesComunesPremium = 250;
        public int pantalonesComunes = 250;
        public int pantalonesComunesTotales;

        //Constructor
        public Pantalones()
        {
            pantalonesChupinesTotales = pantalonesChupinesPremium + pantalonesChupines;
            pantalonesComunesTotales = pantalonesComunesPremium + pantalonesComunes;
            StockTotal = pantalonesChupinesTotales + pantalonesComunesTotales;
        }
    }
}
