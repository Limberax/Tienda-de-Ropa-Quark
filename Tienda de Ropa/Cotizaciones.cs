using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda_de_Ropa
{
    class Cotizaciones
    {
        //Atributos

        private int cantidadUnidadesCotizadas;
        private float calculandoPrecio;
        private float resultadoCotizacion;

        private float modificadorMangaCorta = 0.1f;
        private float modificadorCuelloMao = 0.03f;
        private float modificadorPremium = 0.3f;
        private float modificadorChupin = 0.12f;


        #region //Propiedades
        public int CodigoIdentificacion
        {
            get
            {
                return codigoIdentificacion;
            }
            set
            {
                codigoIdentificacion = value;
            }
        }
        public int CantidadUnidadesCotizadas
        {
            get
            {
                return cantidadUnidadesCotizadas;
            }
            set
            {
                cantidadUnidadesCotizadas = value;
            }
        }
        public float ResultadoCotizacion
        {
            get
            {
                return resultadoCotizacion;
            }
            set
            {
                resultadoCotizacion = value;
            }
        }
        public int Fecha
        {
            get
            {
                return fecha;
            }
            set
            {
                fecha = value;
            }
        }
        public int Hora
        {
            get
            {
                return hora;
            }
            set
            {
                hora = value;
            }
        }


        #endregion

        //Metodos

        public void CalcularPrecioCamisas(bool mangaCorta, bool cuelloMao, bool Premium, int camisasMangaCortaMaoPremium, int camisasMangaCortaMao,int camisasMangaCortaPremium, int camisasMangaCorta,int camisasMangaLargaMaoPremium,int camisasMangaLargaMao, int camisasMangaLargaPremium, int camisasMangaLarga,float PrecioUnitario)
        {
            //Calcular el precio de las mangas cortas
            if (mangaCorta == true)
            {
                calculandoPrecio = PrecioUnitario - (PrecioUnitario * modificadorMangaCorta);
            }
            else
            {
                calculandoPrecio = PrecioUnitario;
            }

            //Calcular precio del cuello Mao
            if (cuelloMao == true)
            {
                calculandoPrecio = calculandoPrecio + (calculandoPrecio * modificadorCuelloMao);
            }

            //Calcular precio del Premium
            if (Premium == true)
            {
                resultadoCotizacion = calculandoPrecio + (calculandoPrecio * modificadorPremium);
            }
            else
            {
                resultadoCotizacion = calculandoPrecio;
            }

            //Definir Producto Elegido Stock
            if (mangaCorta == true && cuelloMao == true && Premium == true)
            {
                camisasMangaCortaMaoPremium = camisasMangaCortaMaoPremium - cantidadUnidadesCotizadas;
            }
            else
            {
                if (mangaCorta == true && cuelloMao == true)
                {
                    camisasMangaCortaMao = camisasMangaCortaMao - cantidadUnidadesCotizadas;
                }
                else
                {
                    if (mangaCorta == true && Premium == true)
                    {
                        camisasMangaCortaPremium = camisasMangaCortaPremium - cantidadUnidadesCotizadas;
                    }
                    else
                    {
                        if (mangaCorta == true)
                        {
                            camisasMangaCorta = camisasMangaCorta - cantidadUnidadesCotizadas;
                        }
                    }
                }
            }

            if (mangaCorta == false && cuelloMao == true && Premium == true)
            {
                camisasMangaLargaMaoPremium = camisasMangaLargaMaoPremium - cantidadUnidadesCotizadas;
            }
            else
            {
                if (mangaCorta == false && cuelloMao == true)
                {
                    camisasMangaLargaMao = camisasMangaLargaMao - cantidadUnidadesCotizadas;
                }
                else
                {
                    if (mangaCorta == false && Premium == true)
                    {
                        camisasMangaLargaPremium = camisasMangaLargaPremium - cantidadUnidadesCotizadas;
                    }
                    else
                    {
                        if (mangaCorta == false)
                        {
                            camisasMangaLarga = camisasMangaLarga - cantidadUnidadesCotizadas;
                        }
                    }
                }
            }

        }

        public void CalcularPrecioPantalones(bool chupin, bool Premium, int pantalonesChupinesPremium, int pantalonesChupines,int pantalonesComunesPremium, int pantalonesComunes, float PrecioUnitario)
        {
            //Calcular el precio de los Chupines
            if (chupin == true)
            {
                calculandoPrecio = PrecioUnitario - (PrecioUnitario * modificadorChupin);
            }
            else
            {
                calculandoPrecio = PrecioUnitario;
            }

            //Calcular precio del Premium
            if (Premium == true)
            {
                resultadoCotizacion = calculandoPrecio + (calculandoPrecio * modificadorPremium);
            }
            else
            {
                resultadoCotizacion = calculandoPrecio;
            }

            //Definir Producto elegido Stock
            if (chupin == true && Premium == true)
            {
                pantalonesChupinesPremium = pantalonesChupinesPremium - cantidadUnidadesCotizadas;
            }
            else
            {
                if (chupin == true)
                {
                    pantalonesChupines = pantalonesChupines - cantidadUnidadesCotizadas;
                }
            }

            if (chupin == false && Premium == true)
            {
                pantalonesComunesPremium = pantalonesComunesPremium - cantidadUnidadesCotizadas;
            }
            else
            {
                if (chupin == false)
                {
                    pantalonesComunes = pantalonesComunes - cantidadUnidadesCotizadas;
                }
            }



        }


    }
}
