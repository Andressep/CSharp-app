using System.Diagnostics;

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
            void primeNumbers(int min, int max)
            {
                int minPrime;
                int maxPrime;
                int counter = 0;
                List<int> primes = new List<int>();
                Stopwatch stopwatch = new Stopwatch();

                stopwatch.Start();

                for(int number = min; number <= max; number++)
                {
                    bool isPrime = true;
                    for(int divisor = 2; divisor < number;  divisor++)
                    {
                        if(number % divisor == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                    if(isPrime)
                    {
                        primes.Add(number);
                        counter += 1;
                    }
                }

                minPrime = primes.Min();
                maxPrime = primes.Max();
                stopwatch.Stop();
                long tiempo = stopwatch.ElapsedMilliseconds;

                dataGridView1.Rows[0].Cells[0].Value = min;
                dataGridView1.Rows[0].Cells[1].Value = max;
                dataGridView1.Rows[0].Cells[2].Value = minPrime;
                dataGridView1.Rows[0].Cells[3].Value = maxPrime;
                dataGridView1.Rows[0].Cells[4].Value = counter;
                dataGridView1.Rows[0].Cells[5].Value = tiempo + " Milisegundos";
                dataGridView1.Rows[0].Cells[6].Value = "En proceso";
            }

            dataGridView1.Rows.Add();

            if(radioButton1.Checked == true)
            {
                primeNumbers(1, 99);
            }
            if (radioButton3.Checked == true)
            {
                primeNumbers(99, 999);
            }
            if (radioButton2.Checked == true)
            {
                primeNumbers(1000, 9999);
            }
            if (radioButton4.Checked == true)
            {
                primeNumbers(10000, 999999);
            }
            if (radioButton5.Checked == true)
            {
                primeNumbers(100000, 999999);
            }
            if (radioButton6.Checked == true)
            {
                primeNumbers(1000000, 9999999);
            }
        }
    }
}