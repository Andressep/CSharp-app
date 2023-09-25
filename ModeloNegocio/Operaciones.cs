using System.Diagnostics;

namespace ModeloNegocio
{
    public class Operaciones
    {
        public Operaciones() {
        }
        public void primeNumbers(int min, int max)
        {
            int minPrime;
            int maxPrime;
            int counter = 0;
            List<int> primes = new List<int>();
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();

            for (int number = min; number <= max; number++)
            {
                bool isPrime = true;
                for (int divisor = 2; divisor < number; divisor++)
                {
                    if (number % divisor == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
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
    }
}