using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tienda_de_Ropa
{
    public partial class Form1 : Form
    {

        Cotizaciones Calcular = new Cotizaciones();
        Camisas camisas = new Camisas();
        Pantalones pantalones = new Pantalones();
        Vendedor comerciante = new Vendedor();
        Tienda tiendita = new Tienda();
        
        public Form1()
        {
            InitializeComponent();
            comerciante.Nombre = labelNombreVendedor.Text;
            comerciante.Apellido = labelApellido.Text;
            comerciante.CodigoVendedor = int.Parse(labelCodigoVendedor.Text);
            tiendita.Direccion = labelDireccion.Text;
            tiendita.Nombre = labelTienda.Text;

            
        }
        #region
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        #endregion
        private void radioCamisa_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxChupin.Checked = false;
            checkBoxChupin.Enabled = false;
            checkBoxCorta.Enabled = true;
            checkBoxMao.Enabled = true;

            labelStock.Text = camisas.camisasMangaLarga.ToString();
        }
        private void checkBoxCorta_CheckedChanged(object sender, EventArgs e)
        {
            
            if (checkBoxCorta.Checked == true && checkBoxMao.Checked == true && radioPremium.Checked == true)
            {
                labelStock.Text = camisas.camisasMangaCortaMaoPremium.ToString();
            }
            else
            {
                if (checkBoxCorta.Checked == true && checkBoxMao.Checked == true)
                {
                    labelStock.Text = camisas.camisasMangaCortaMao.ToString();
                }
                else
                {
                    if (checkBoxCorta.Checked == true)
                    {
                        labelStock.Text = camisas.camisasMangaCorta.ToString();
                    }
                }
            }
        }

        private void checkBoxMao_CheckedChanged(object sender, EventArgs e)
        {
            if ( checkBoxMao.Checked == true && checkBoxCorta.Checked == true && radioPremium.Checked == true)
            {
                labelStock.Text = camisas.camisasMangaCortaMaoPremium.ToString();
            }
            else
            {
                if (checkBoxMao.Checked == true && checkBoxCorta.Checked == true)
                {
                    labelStock.Text = camisas.camisasMangaCortaMao.ToString();
                }
                else
                {
                    if (checkBoxCorta.Checked == true)
                    {
                        labelStock.Text = camisas.camisasMangaCorta.ToString();
                    }
                }
            }
        }

        private void radioPantalon_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxCorta.Checked = false;
            checkBoxMao.Checked = false;

            checkBoxChupin.Enabled = true;
            checkBoxCorta.Enabled = false;
            checkBoxMao.Enabled = false;

            if (radioPantalon.Checked == true && checkBoxChupin.Checked == true && radioPremium.Checked == true)
            {
                labelStock.Text = pantalones.pantalonesChupinesPremium.ToString();
            }
            else
            {
                if (radioPantalon.Checked == true && checkBoxChupin.Checked == true)
                {
                    labelStock.Text = pantalones.pantalonesChupines.ToString();
                }
                else
                {
                   if (radioPantalon.Checked == true && radioPremium.Checked == true)
                    {
                        labelStock.Text = pantalones.pantalonesComunesPremium.ToString();
                    }
                    else
                    {
                        if (radioPantalon.Checked == true)
                        {
                            labelStock.Text = pantalones.pantalonesComunes.ToString();
                        }
                    }
                }
            }
        }
        private void checkBoxChupin_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxChupin.Checked == true && radioPremium.Checked == true)
            {
                labelStock.Text = pantalones.pantalonesChupinesPremium.ToString();
            }
            else
            {
                if (checkBoxChupin.Checked == true && radioPremium.Checked == false)
                {
                    labelStock.Text = pantalones.pantalonesChupines.ToString();
                }
                else
                {
                    if (checkBoxChupin.Checked == false && radioPremium.Checked == false)
                    {
                        labelStock.Text = pantalones.pantalonesComunesPremium.ToString();
                    }
                    else
                    {
                        if (checkBoxChupin.Checked == false && radioPremium.Checked == false)
                        {
                            labelStock.Text = pantalones.pantalonesComunes.ToString();
                        }
                    }
                }
            }
        }

        private void radioStandar_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioPremium_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPrecioUnitario_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCotizar_Click(object sender, EventArgs e)
        {

            pantalones.chupin = checkBoxChupin.Checked;
            pantalones.Premium = radioPremium.Checked;

            camisas.mangaCorta = checkBoxCorta.Checked;
            camisas.cuelloMao = checkBoxMao.Checked;
            camisas.Premium = radioPremium.Checked;


            try
            {
                int precioUnitario = int.Parse(textBoxPrecioUnitario.Text);



                camisas.PrecioUnitario = precioUnitario;


                pantalones.PrecioUnitario = precioUnitario;

                Calcular.CantidadUnidadesCotizadas = int.Parse(textBoxCantidad.Text);


                if (radioCamisa.Checked == true)
                {
                    Calcular.CalcularPrecioCamisas(camisas.mangaCorta, camisas.cuelloMao, camisas.Premium, camisas.camisasMangaCortaMaoPremium, camisas.camisasMangaCortaMao, camisas.camisasMangaCortaPremium, camisas.camisasMangaCorta, camisas.camisasMangaLargaMaoPremium, camisas.camisasMangaLargaMao, camisas.camisasMangaLargaPremium, camisas.camisasMangaLarga, camisas.PrecioUnitario);

                }
                if (radioCamisa.Checked == false)
                {
                    Calcular.CalcularPrecioPantalones(pantalones.chupin, pantalones.Premium, pantalones.pantalonesChupinesPremium, pantalones.pantalonesChupines, pantalones.pantalonesComunesPremium, pantalones.pantalonesComunes, pantalones.PrecioUnitario);
                }
                float resultadoCotizacion = Calcular.ResultadoCotizacion * int.Parse(textBoxCantidad.Text);
                labelPrecioTotal.Text = resultadoCotizacion.ToString("0.0");

            }
            catch(FormatException ex)
            {
                MessageBox.Show("No seas gil, dale, Completa todos los campos e ingresa un numero y dejate de joder por favor.");
            }




        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
