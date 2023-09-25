using Datos;
using ModeloNegocio;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace EvaSolUnidad2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Operaciones operaciones = new Operaciones();
            Dato dato = new Dato();

            dataGridView1.Rows.Add();

            if (radioButton1.Checked == true)
            {
                operaciones.primeNumbers(1, 99);
            }
            if (radioButton2.Checked == true)
            {
                operaciones.primeNumbers(99, 999);
            }
            if (radioButton3.Checked == true)
            {
                operaciones.primeNumbers(1000, 9999);
            }
            if (radioButton4.Checked == true)
            {
                operaciones.primeNumbers(10000, 999999);
            }
            if (radioButton5.Checked == true)
            {
                operaciones.primeNumbers(100000, 999999);
            }
            if (radioButton6.Checked == true)
            {
                operaciones.primeNumbers(1000000, 9999999);
            }
        }
    }
}