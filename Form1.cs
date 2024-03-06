using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP_EJERCICIO_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            // Convertir los valores de los campos de texto a números
            double valor1 = Convert.ToDouble(txt_Valor1.Text);
            double valor2 = Convert.ToDouble(txt_Valor2.Text);
         
            double suma = valor1 + valor2;
            double resta = valor1 - valor2;
            double multiplicacion = valor1 * valor2;
            double division = valor1 / valor2;
            
            txt_Suma.Text = suma.ToString();
            txt_Resta.Text = resta.ToString();
            txt_Multiplicacion.Text = multiplicacion.ToString();

            // Verificar si el segundo valor es cero antes de realizar la división
            if (valor2 != 0)
            {
                txt_Division.Text = division.ToString();
            }
            else
            {
                txt_Division.Text = "Error: división por cero";
            }
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txt_Division.Clear();
            txt_Suma.Clear();
            txt_Resta.Clear();
            txt_Multiplicacion.Clear();
            txt_Valor1.Clear();
            txt_Valor2.Clear();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
