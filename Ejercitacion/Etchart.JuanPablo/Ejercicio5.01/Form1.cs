namespace Ejercicio5._01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// al iniciar el formulario se ejecua esta 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            this.lblSaludo.Text = string.Empty;
            this.Text = "Saludo desde un Form";
            this.button1.Text = "Haga click aquí";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.lblSaludo.Text = "HOLA MUNDO WINDOWS FORMMM!!!";
        }
    }
}