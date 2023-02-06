using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/*
DESARROLLAR UN PROGRAMA QUE PERMITA INGRESAR LA CANTIDAD DE
PRODUCTOS ADQUIRIDOS EN UNA TIENDA, Y EL PRECIO UNITARIO DEL
PRODUCTO. EL PROGRAMA DEBE MOSTRAR EL IMPORTE A PAGAR, TENIENDO
EN CUENTA QUE POR PROMOCIÓN EXISTE UN DESCUENTO DEL 15.25%.

Villavicencio Rios Piero
 */

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)

        {
            Focus();

            //SUMA DE TODOS LAS UNIDADES DE PRODUCTOS
            txtTotalProductos.Text = Convert.ToString(numGloria.Value + numINKA.Value + numCOCA.Value);
            double totalProductos = Convert.ToDouble(txtTotalProductos.Text);

            //CALCULANDO PRECIOS UNITARIOS

            double Coca =Convert.ToDouble( numCOCA.Value);
            double Inka = Convert.ToDouble(numINKA.Value);
            double Gloria = Convert.ToDouble(numGloria.Value);

            double PrecioCoca = Coca * 8.00;
            double PrecioInka = Inka * 10.00;
            double PrecioGloria = Gloria * 15.00;

            /////////////////////////////////////////////////////////////////////////////////////////////
            
            //CALCULANDO EL PRECIO TOTAL SIN IGV
            txtSinIGV.Text = Convert.ToString (PrecioCoca + PrecioInka + PrecioGloria);

            /////////////////////////////////////////////////////////////////////////////////////////////
            //CALCULANDO EL PRECIO TOTAL CON IGV

            double Igv = Convert.ToDouble(txtSinIGV.Text);

            double conIgv = Igv * 0.18;

            txtIGV.Text = Convert.ToString(conIgv);

            //////////////////////////////////////////////////////////////////////////////////////////////
            //CALCULANDO EL DESCUENTO

            //Variable total_auxiliar
            double total_auxiliar = (Igv + conIgv);
            double descuento = (total_auxiliar * 0.1528);
            txtDescuento.Text = Convert.ToString(descuento);

            //////////////////////////////////////////////////////////////////////////////////////////////
            //Total a pagar + Descuento  + igv

            double TotalPagarIgvDesc = total_auxiliar - descuento;
            txtTotalPagar.Text = Convert.ToString(TotalPagarIgvDesc);

        }

        private void txtTotalProductos_TextChanged(object sender, EventArgs e)
        {

        }

        private void numINKA_ValueChanged(object sender, EventArgs e)
        {
            numINKA.Focus();
            numINKA.Maximum = 999999999;

        }

        private void numCOCA_ValueChanged(object sender, EventArgs e)
        {
            numCOCA.Maximum = 999999999;
        }

        private void numGloria_ValueChanged(object sender, EventArgs e)
        {
            numGloria.Maximum = 99999999;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txtIGV_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
