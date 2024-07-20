using System;
using System.Windows.Forms;

namespace Simulacion
{
    public partial class Form1 : Form
    {
        private double resultado;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {

            if (int.TryParse(textBox1.Text, out int iteraciones) && iteraciones > 0)
            {
                int dentroCirculo = 0;
                Random rand = new Random();

                // Random rand = new Random(); = Devuelve un valor de coma flotante mayor o igual que 0 y menor o igual que 1

                for (int i = 0; i < iteraciones; i++)
                {
                    // Generar coordenadas aleatorias entre 0 y 1

                    double x = rand.NextDouble();
                    double y = rand.NextDouble();

                    // Rand.NextDouble(); = Vuelve un número de punto flotante aleatorio que es mayor o igual que 0,0 y menor que 1,0 .

                    // Calcular la distancia desde el punto (x, y) al centro (0.5, 0.5)

                    double distancia = Math.Sqrt(Math.Pow((x - 0.5), 2) + Math.Pow((y - 0.5), 2));

                    // Math.Sqrt = Devuelve la raíz cuadrada de un número especificado.
                    // Math.Pow = Devuelve un número especificado elevado a la potencia especificada.

                    // Punto está dentro del círculo.
                    if (distancia <= 0.5)
                    {
                        dentroCirculo++;
                    }
                }

                // Calcular la aproximación de pi.
                double piAproximado = 4.0 * dentroCirculo / iteraciones;

                // Mostrar el Resultado.
                resultado = piAproximado;
                MessageBox.Show($"Aproximación de π: {piAproximado:F6}", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Muestra un mensaje de error
                MessageBox.Show("Por favor ingrese un número válido de iteraciones.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
