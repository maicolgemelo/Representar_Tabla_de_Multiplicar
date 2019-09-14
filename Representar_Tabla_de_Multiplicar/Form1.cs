using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Representar_Tabla_de_Multiplicar
{
    public partial class Form1 : Form
    {
        int i = 1;

        public Form1()
        {
            InitializeComponent();
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            
            int valor, total;
            valor = int.Parse(txtNumero.Text);
            
            for (int i = 1; i <= 11 -1 ; i++)
            {
                

                total = valor * i ;
                dgTablaMultiplicacion.Rows.Add(txtNumero.Text, i.ToString(),total.ToString());



               

            }

            i = i + 1;

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            dgTablaMultiplicacion.Rows.Clear();


            txtNumero.Text = "";
            txtNumero.Focus();

        }
    }
}
