namespace Ejercicio5._03
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.inputDescuento.Text = string.Empty;
            this.inputTotal.Text = string.Empty;
            this.inputImporte.Text = string.Empty;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            float descuento; 
            int importe = int.Parse(this.inputImporte.Text);

            if(importe >= 3000 && importe <= 5000)
            {
                descuento = 0.1f;

            }else if(importe > 5000)
            {
                descuento = 0.2f;
            }else { descuento = 0; }

            float precioDescuento = descuento * importe;
            this.inputDescuento.Text = (precioDescuento).ToString();
            this.inputTotal.Text = (importe + precioDescuento).ToString();
        }
    }
}