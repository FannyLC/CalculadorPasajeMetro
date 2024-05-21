namespace CalculadorPasajeMetro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Verificar si los valores ingresados son n�meros v�lidos
            if (double.TryParse(txtDistance.Text, out double distance) && int.TryParse(txtDays.Text, out int days))
            {
                // Definir el precio por kil�metro
                double pricePerKm = 0.80;
                double totalPrice = distance * pricePerKm * 2; // Ida y vuelta

                // Verificar si se aplica la reducci�n
                if (days > 7 && distance > 800)
                {
                    totalPrice *= 0.7; // Aplicar reducci�n del 30%
                }

                // Mostrar el resultado
                lblResult.Text = $"El precio del pasaje de ida y vuelta es: ${totalPrice:F2}";
            }
            else
            {
                // Mostrar un mensaje de error si los valores ingresados no son v�lidos
                lblResult.Text = "Por favor, ingrese valores num�ricos v�lidos.";
            }
        }
    }
}
  