using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void calcularPromediobutton_Click(object sender, EventArgs e)
        {
            decimal nota1 = Convert.ToDecimal(Nota1textBox.Text);
            decimal nota2 = Convert.ToDecimal(Nota2textBox.Text);
            decimal nota3 = Convert.ToDecimal(Nota3textBox.Text);
            decimal nota4 = Convert.ToDecimal(Nota4textBox.Text);

            decimal promedio = await SumarAsyn(nota1, nota2, nota3, nota4);
            MessageBox.Show($"Su promedio final es: {promedio}");

        }

        private async Task<decimal> SumarAsyn(decimal n1, decimal n2, decimal n3, decimal n4)
        {
            decimal promedio = await Task.Run(() =>
            {
                return (n1 + n2 + n3 + n4) / (4);
            });
            return promedio;

        }
  
    }
}
