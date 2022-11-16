using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraSoft
{
    public partial class Form1 : Form
    { bool op = false; 

        public Form1()
        {
            InitializeComponent();
        }

        private void btnfechar_Click(object sender, EventArgs e)
        {  //fechar programa
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
         
        } 
        private void numeroPressionado (object sender, EventArgs e)
        {    //registro do num
            Button numero = (Button)sender;
            txbtela.Text += numero.Text;
            op = false; 
        }
        private void operacao(object sender, EventArgs e)
        {
            Button operador = (Button)sender;
           

         
              

            if (op == false)
            {
                if (txbaux.Text != "")
                {   //converter a string em num com concatenaçao 
                    DataTable dt = new DataTable();

                    var v = dt.Compute(txbaux.Text + txbtela.Text, "");
                    txbaux.Text = v.ToString() + " " + operador.Text;
                    txbtela.Text = ""; //limpar
                }
                else

                {
                    txbaux.Text = txbtela.Text + " " + operador.Text;
                    txbtela.Text = "";
                }
                op = true; 

            }




        }

        private void btnLimpa_Click(object sender, EventArgs e)
        { //limpar dados com o botao 
            txbtela.Text = "";
            txbaux.Text = ""; 

           
        }


        private void btnigual_Click(object sender, EventArgs e)
        {    //mostrar resultado 
            if (txbtela.Text != "")

            {
                DataTable dt = new DataTable();

                var v = dt.Compute(txbaux.Text + txbtela.Text, "");
                txbaux.Text = "";
                txbtela.Text = v.ToString(); 

            }

        } 
    }
   
}
